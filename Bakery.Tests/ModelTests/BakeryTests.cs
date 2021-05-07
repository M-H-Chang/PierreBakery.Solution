using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Loaf_ReturnsBreadCost_Five()
    {
      Assert.AreEqual(5, Bread.Loaf(1));
    }
  }
}