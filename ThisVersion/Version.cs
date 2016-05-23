using System;
using System.Diagnostics;

namespace ThisVersion {
	public class Version {
		public static string GetCallingAssemblyVersion() {
			var assembly = System.Reflection.Assembly.GetCallingAssembly();
			var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
			var version = fvi.FileVersion;
			return version;
		}

		public static string GetAssemblyVersion(string path) {
			var versionInfo = FileVersionInfo.GetVersionInfo(path);
			return versionInfo.FileVersion;
		}
	}
}


