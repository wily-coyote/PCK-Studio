using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using PckStudio.Internal;
using PckStudio.Internal.App;
using PckStudio.ToolboxItems;

namespace PckStudio.Forms
{
    public partial class ContributorsForm : Form
    {
        public ContributorsForm()
        {
            InitializeComponent();
            string buildConfig = "";
#if BETA
            buildConfig = "Beta";
#elif DEBUG
            buildConfig = "Debug";
#elif RELEASE
            buildConfig = "Release";
#else
            buildConfig = "unknown";
#endif
            buildLabel.Text = $"PCK Studio version {ApplicationScope.CurrentVersion}\nBuild type: {buildConfig}\nGit revision: {CommitInfo.BranchName}@{CommitInfo.CommitHash}";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            foreach (Octokit.RepositoryContributor contributorsName in ApplicationScope.Contributors)
            {
                if (InvokeRequired)
                    Invoke(() => contributorsLayoutPanel.Controls.Add(new GithubUserPanel(contributorsName)));
                else
                    contributorsLayoutPanel.Controls.Add(new GithubUserPanel(contributorsName));
            }
        }
    }
}
