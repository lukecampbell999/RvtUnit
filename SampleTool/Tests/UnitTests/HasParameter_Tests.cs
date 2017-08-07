using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SampleTool.Helper;
using Autodesk.Revit.DB;

namespace SampleTool.Tests.UnitTests
{
	[TestFixture]
	public class HasParameter_Tests
	{
		[SetUp]
		public void Setup()
		{
			// setup pre-test environment
		}

		[TearDown]
		public void Cleanup()
		{
			// cleanup
		}

		[Test]
		public void ShouldNotHaveParameter_Test()
		{
			Document document = Helpers.GeneralHelper.ActiveUIDocument.Document;
			IParameterHelper parameterHelper = new ParameterHelper(document);
			Assert.That(parameterHelper.HasParameter("SomeParameterThatNormallyDoesnotExist"), Iz.False);
		}

		[Test]
		public void ShouldHaveParameter_Test()
		{
			Document document = Helpers.GeneralHelper.ActiveUIDocument.Document;
			IParameterHelper parameterHelper = new ParameterHelper(document);
			Assert.That(parameterHelper.HasParameter("Project Name"), Iz.True);
		}

        [Test]
        public void ShouldNotHaveParameter2_Test()
        {
            Document document = Helpers.GeneralHelper.ActiveUIDocument.Document;
            IParameterHelper parameterHelper = new ParameterHelper(document);
            Assert.That(parameterHelper.HasParameter("SomeParameterThatNormallyDoesnotExist"), Iz.False);
            Assert.AreEqual(1, 2);
        }

        [Test]
        public void ExpectBroken_Test()
        {
            Assert.AreEqual(1, 2);
        }
    }
}
