﻿using GUI;
using NUnit.Framework;

namespace Tests
{
    public class Test
    {
        // A Test behaves as an ordinary method
        [Test]
        public void TestSimplePasses()
        {
            InfoPanel infoPanel = new InfoPanel();
           // Assert.AreEqual(1, infoPanel.Cost());
        }
    }
}