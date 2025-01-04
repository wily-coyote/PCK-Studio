using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace PckStudio.Internal {
	/** <summary>General-purpose function class.</summary> **/
	public class Utilities {
		[DllImport("user32.dll")]
		/** <summary>Win32 SendMessage function</summary> **/
		public static extern uint SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);
		
		[DllImport("user32.dll")]
		/** <summary>Win32 SetForegroundWindow function</summary> **/
		public static extern int SetForegroundWindow(IntPtr hwnd);
		
		private static readonly Regex sWhitespace = new Regex(@"\s+");
		
		/** <summary>Replaces all whitespace using regular expressions.</summary> **/
		public static string ReplaceWhitespace(string input, string replacement) {
			return sWhitespace.Replace(input, replacement);
		}
	}
}
