using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.VS2010
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Assert.IsTrue(true);
		}

		[TestMethod]
		public void TestMethod2()
		{
			Assert.IsTrue(false);
		}
	}
}
