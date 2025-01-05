using OMI.Formats.Languages;
using OMI.Formats.Pck;
using OMI.Workers.Language;
using PckStudio.Extensions;
using PckStudio.Forms.Additional_Popups.Loc;
using PckStudio.Properties;
using PckStudio.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace PckStudio.Forms.Editor {
	public partial class LOCEditor : Form {
		LOCFile locFile;
		PckAsset pckAsset;
		TreeNode node;
		string lang;

		public LOCEditor(PckAsset asset) {
			InitializeComponent();
			pckAsset = asset;
			locFile = asset.GetData(new LOCFileReader());
			saveToolStripMenuItem.Visible = !Settings.Default.AutoSaveChanges;
		}

		private void Loaded(object sender, EventArgs e) {
			foreach(string locKey in locFile.LocKeys.Keys)
				treeViewLocKeys.Nodes.Add(locKey);
		}
		
		private void MouseTouchedAtKey(object sender, MouseEventArgs e) {
			var hit = treeViewLocKeys.HitTest(e.X, e.Y);
			node = hit.Node;
			treeViewLocKeys.SelectedNode = node;
			ReloadTranslationTable();
		}
		
		private void MouseTouchedAtLanguage(object sender, MouseEventArgs e) {
			var hit = dataGridViewLocEntryData.HitTest(e.X, e.Y);
			if(hit.RowIndex != -1) {
				var row = dataGridViewLocEntryData.Rows[hit.RowIndex];
				lang = row.Cells[0].Value as string;
			} else { lang = null; }
			removeLanguageToolStripMenuItem.Enabled = lang != null;
		}

		private void KeyAdded(object sender, EventArgs e) {
			TextPrompt prompt = new TextPrompt();
			prompt.OKButtonText = "Add";
			if(prompt.ShowDialog(this) == DialogResult.OK &&
				locFile.AddLocKey(prompt.NewText, "")) {
				treeViewLocKeys.Nodes.Add(prompt.NewText);
			}
		}
		
		private void KeyEdited(object sender, EventArgs e) {
			if(!node.IsEditing) {
				node.BeginEdit();
			}
		}

		private void KeyDeleted(object sender, EventArgs e) {
			if(node != null && locFile.RemoveLocKey(node.Text)) {
				node.Remove();
				ReloadTranslationTable();
			}
		}

		private void ValueEdited(object sender, DataGridViewCellEventArgs e) {
			if(e.ColumnIndex != 1 || node is null) {
				MessageBox.Show(this, "something went wrong");
				return;
			}
			DataGridViewRow row = dataGridViewLocEntryData.Rows[e.RowIndex];
			string locKey = node.Text;
			string language = row.Cells[0].Value.ToString();
			string value = row.Cells[1].Value.ToString();
			locFile.SetLocEntry(locKey, language, value);
		}

		private void KeyboardTouched(object sender, KeyEventArgs e) {
			switch(e.KeyData) {
				case Keys.Delete:
					KeyDeleted(sender, e);
					break;
				case Keys.F2:
					KeyEdited(sender, e);
					break;
			}
		}

		private void ReplaceAll(object sender, EventArgs e) {
			for(int i = 0; i < dataGridViewLocEntryData.Rows.Count; i++) {
				dataGridViewLocEntryData.Rows[i].Cells[1].Value = textBoxReplaceAll.Text;
			}

			locFile.SetLocEntry(node.Text, textBoxReplaceAll.Text);
		}

		private void ReloadTranslationTable() {
			var exists = node != null;
			deleteDisplayIDToolStripMenuItem.Enabled = exists;
			dataGridViewLocEntryData.Rows.Clear();
			if(node is null)
				return;
			foreach(KeyValuePair<string, string> locEntry in locFile.GetLocEntries(node.Text))
				dataGridViewLocEntryData.Rows.Add(locEntry.Key, locEntry.Value);
		}

		private IEnumerable<string> GetAvailableLanguages() {
			foreach(var lang in LOCFile.ValidLanguages) {
				if(locFile.Languages.Contains(lang))
					continue;
				yield return lang;
			}
			yield break;
		}

		private void LanguageAdded(object sender, EventArgs e) {
			string[] avalibleLang = GetAvailableLanguages().ToArray();
			var dialog = new AddLanguage(avalibleLang);
			if(dialog.ShowDialog(this) == DialogResult.OK) {
				locFile.AddLanguage(dialog.SelectedLanguage);
				ReloadTranslationTable();
			}
		}

		private void Save(object sender, EventArgs e) {
			pckAsset.SetData(new LOCFileWriter(locFile, 2));
			DialogResult = DialogResult.OK;
		}

		private void Exiting(object sender, FormClosingEventArgs e) {
			if(Settings.Default.AutoSaveChanges) {
				Save(sender, EventArgs.Empty);
			}
		}

		private void AfterEdit(object sender, NodeLabelEditEventArgs e) {
			if(e.Label != null) {
				if(e.Label.Length > 0) {
					// This API makes zero sense.
					// this code creates a new entry with the new name
					// then copies everything from the old entry
					// to the new entry
					// then nukes the old entry
					// i shouldn't have to do this
					locFile.AddLocKey(e.Label, "");
					Dictionary<string, string> newDict = locFile.GetLocEntries(e.Label);
					Dictionary<string, string> oldDict = locFile.GetLocEntries(e.Node.Text);
					newDict.Clear();
					foreach(var key in oldDict.Keys) {
						newDict.Add(key, oldDict[key]);
					}
					locFile.RemoveLocKey(e.Node.Text);
					e.Node.EndEdit(false);
				} else {
					e.CancelEdit = true;
					SystemSounds.Exclamation.Play();
					e.Node.BeginEdit();
				}
			}
		}

		private void LanguageRemoved(object sender, EventArgs e) {
			if(lang != null) {
				locFile.RemoveLanguage(lang);
				ReloadTranslationTable();
			}
		}

		private void DoContextHelp(object sender, EventArgs e) {
			Utilities.DoContextHelp(this.Handle);
		}
	}
}
