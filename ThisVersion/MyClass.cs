using System;
using System.Diagnostics;

namespace ThisVersion {
	public class ExecutingAssembly { 
		public static string Version {
			get {
				var assembly = System.Reflection.Assembly.GetExecutingAssembly();
				var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
				var version = fvi.FileVersion;
				return version;
			}
		}
	}
}

