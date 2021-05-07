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
    [TestMethod]
    public void Loaf_ReturnsFreeLoafCost_SubtractsFive()
    {
      Assert.AreEqual(10, Bread.Loaf(3));
    }
  }
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void pricePastry_ReturnsPastryCost_Two()
    {
      Assert.AreEqual(2, Pastry.PricePastry(1));
    }
  }
}