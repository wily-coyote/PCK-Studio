using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

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
		private static RNGCryptoServiceProvider random = new RNGCryptoServiceProvider();
		
		/** <summary>Replaces all whitespace using regular expressions.</summary> **/
		public static string ReplaceWhitespace(string input, string replacement) {
			return sWhitespace.Replace(input, replacement);
		}

		/** <summary>Returns the last component of a path. Useful for getting filenames without their path.</summary> **/
		public static string Basename(string filepath) {
			return filepath.Substring(filepath.LastIndexOf('\\')+1);
		}
		
		/** <summary>Returns a human-readable string for a count of objects.</summary> **/
		public static string Pluralize(int count, string singular, string plural) {
			if(count == 1)
				return String.Format(singular, count);
			else
				return String.Format(plural, count);
		}
		
		/** <summary>Turns on "What's This?" mode from Win32.</summary> **/
		public static void DoContextHelp(IntPtr hWnd) {
			// WM_SYSCOMMAND SC_CONTEXTHELP
			SendMessage(hWnd, 0x0112, 0xf180, 0x0);
		}
		
		/** <summary>Generates a random number sequence of <paramref name="length"/>.</summary> **/
		public static string RandomNumberSequence(int length) {
			byte[] seq = new byte[length];
			random.GetBytes(seq);
			for(int i=0; i < length; i++){
				// '0'
				seq[i] = (byte)(0x30 + (seq[i] % 10));
			}
			return Encoding.ASCII.GetString(seq);
		}
	}
}
