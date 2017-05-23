using Nancy;
using CarDealer.Objects;
using System.Collections.Generic;

namespace CarDealer
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_car.cshtml"];
      Get["/view_all_cars"] = _ => {
        List<Car> allCars = Car.GetAll();
        return View["view_all_cars.cshtml", allCars];
      };
      Post["/car_added"] = _ => {
        Car newCar = new Car(Request.Form["new-car"], Request.Form["new-price"], Request.Form["new-miles"]);
        newCar.Save();
        return View["car_added.cshtml", newCar];
      };
      // // Post["/cars_cleared.cshtml"] = _ => {
      //   Car.ClearAll();
      //   return View["cars_cleared.cshtml"];
      // };
    }
  }
}

// add car is not reading GetMakeModel
