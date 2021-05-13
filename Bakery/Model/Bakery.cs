using System;

namespace Bakery
{
  public class Bread
  {
    public int LoafPrice { get; set; }
    public static int Loaf(int loaf)
    {
      Bread breadPrice = new Bread();
      breadPrice.LoafPrice = 5;

      if (loaf > 2)
      {
        return breadPrice.LoafPrice * loaf - 5;
      }
      else
      {
        return breadPrice.LoafPrice * loaf;
      }
    }
  }

  public class Pastry
  {
    public int PastryPrice { get; set; }

    public static int PricePastry(int pas)
    {
      Pastry pasPrice = new Pastry();
      pasPrice.PastryPrice = 2;
      if (pas >= 3)
      {
        return pas * pasPrice.PastryPrice - 1;
      }
      else
      {
        return pas * pasPrice.PastryPrice;
      }
    }
  }
}