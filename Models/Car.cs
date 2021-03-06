using System;

namespace Dealership.Models {

 public class Car
{
    // Public auto-implemented properties
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    // Constructor
    public Car(string makeModel, int price, int miles)
    {
        MakeModel = makeModel;
        Price = price;
        Miles = miles;
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like" + sound;
    }

    public void SetPrice(int newPrice)// use void as the return type because SetPrice() does not return a value. Name setter methods by prepending Set
    {
      Price = newPrice;//  takes our private field price and sets it to newPrice.
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }
  }

}