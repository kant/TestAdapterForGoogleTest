﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static GoogleTestAdapter.TestMetadata.TestCategories;

namespace GoogleTestAdapter.Helpers
{

    [TestClass]
    public class DebugUtilsTests
    {

        [TestMethod]
        [TestCategory(Unit)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AssertIsNotNull_Null_ThrowsException()
        {
            DebugUtils.AssertIsNotNull(null, "foo");
        }

        [TestMethod]
        [TestCategory(Unit)]
        [ExpectedException(typeof(ArgumentException))]
        public void AssertIsNull_NotNull_ThrowsException()
        {
            DebugUtils.AssertIsNull("", "foo");
        }

    }

}