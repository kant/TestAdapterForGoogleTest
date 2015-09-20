﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoogleTestAdapter.Helpers
{
    [TestClass]
    public class ProcessUtilsTests : AbstractGoogleTestExtensionTests
    {

        [TestMethod]
        public void ReturnsOutputOfCommand()
        {
            List<string> output = new ProcessUtils(MockOptions.Object).GetOutputOfCommand(MockLogger.Object, ".", "cmd.exe", "/C \"echo 2\"", false, false, null, null);

            Assert.AreEqual(1, output.Count);
            Assert.AreEqual("2", output[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ThrowsIfProcessFails()
        {
            new ProcessUtils(new GoogleTestAdapterOptions()).GetOutputOfCommand(MockLogger.Object, ".", "cmd.exe", "/C \"exit 2\"", false, true, null, null);
        }

        [TestMethod]
        public void DoesNotThrowIfProcessFails()
        {
            new ProcessUtils(MockOptions.Object).GetOutputOfCommand(MockLogger.Object, ".", "cmd.exe", "/C \"exit 2\"", false, false, null, null);
        }

    }

}