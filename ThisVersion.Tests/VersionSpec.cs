using NUnit.Framework;
using System;
using ThisVersion;
using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace ThisVersion.Tests {
	[TestFixture()]
	public class Test {

		[Test]
		public void GetVersionOfCallingAssembly() {
			var version = Version.GetCallingAssemblyVersion();
			Assert.AreEqual("1.0.8.0", version);
		}

		[Test]
		public void GetVersionOfSpecificDll() {
			var loc = new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.FullName;
			var version = Version.GetAssemblyVersion(Path.Combine(loc, "ThisVersion.dll"));
			Assert.AreEqual("1.0.2.0", version);
		}
	}
}

