using System;
using System.Collections.Generic;

namespace CarDealer.Objects
{

  public class Car
  {
    private string _makeModel;
    private string _price;
    private string _miles;
    private static List<Car> _carDealer = new List<Car> {};

    public Car(string makeModel, string price, string miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }
    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }
    public string GetPrice()
    {
      return _price;
    }
    public void SetPrice(string newPrice)
    {
      _price = newPrice;
    }
    public string GetMiles()
    {
      return _miles;
    }
    public void SetMiles(string newMiles)
    {
      _miles = newMiles;
    }
    public static List<Car> GetAll()
    {
      return _carDealer;
    }
    public void Save()
    {
      _carDealer.Add(this);
    }
  }
}
