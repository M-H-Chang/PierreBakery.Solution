using System;

namespace Bakery
{
  public class Bread
  {
    public static int Loaf(int loaf)
    {
      int priceOfLoaf = 5;
      return loaf * priceOfLoaf;
    }
  }

  public class Pastry
  {
    public static int PricePastry(int pas)
    {
      int priceOfPastry = 2;
      return pas * priceOfPastry;
    }
  }
}