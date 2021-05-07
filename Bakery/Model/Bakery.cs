using System;

namespace Bakery
{
  public class Bread
  {
    public static int LoafPrice { get; set; } = 5;
    public static int Loaf(int loaf)
    {
      LoafPrice = priceOfLoaf;
      if (loaf >= 2)
      {
        return loaf * priceOfLoaf - 5;
      }
      return loaf * priceOfLoaf;
    }
  }

  public class Pastry
  {
    public static int PastryPrice { get; set; } = 2;

    public static int PricePastry(int pas)
    {
      int priceOfPastry = 2;
      if (pas >= 3)
      {
        return pas * priceOfPastry - 1;
      }
      return pas * priceOfPastry;
    }
  }
}