﻿using System;

using NUnit.Framework;

using SkyNinja.Core.Classes;

namespace SkyNinja.Core.Test.Classes
{
    [TestFixture]
    public class GroupTest
    {
        [TestCase("1", "2", false)]
        [TestCase("3", "3", true)]
        public void TestEquals(string group1, string group2, bool equals)
        {
            Assert.AreEqual(equals, new Group(group1).Equals(new Group(group2)));
        }
    }
}
