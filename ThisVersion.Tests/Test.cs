using NUnit.Framework;
using System;
using ThisVersion;

namespace ThisVersion.Tests {
	[TestFixture()]
	public class Test {
		[Test()]
		public void TestCase() {
			var version = ExecutingAssembly.Version; 
			Assert.AreEqual("1.0.1.0", version);
		}
	}
}

