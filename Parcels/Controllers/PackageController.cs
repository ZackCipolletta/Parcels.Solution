using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcel.Controllers
{
  public class PackageController : Controller
  {

    // [HttpGet("/items")]
    // public ActionResult Index()
    // {
    //   List<Item> allItems = Item.GetAll();
    //   return View(allItems);
    // }

    [HttpGet("package")]
    public ActionResult CostToShip()
    {
      return View();
    }

    [Route("/package")]
    public ActionResult Package(int size1, int size2, int size3, int weight)
    {
      Package thePackage = new Package(size1, size2, size3, weight);
      thePackage.SizeX = size1;
      thePackage.SizeY = size2;
      thePackage.SizeZ = size3;
      thePackage.WeightOZ = weight;
      return View(thePackage);
    }

    // [HttpPost("/items")]
    // public ActionResult Create(string description)
    // {
    //   Item myItem = new Item(description);
    //   return RedirectToAction("Index");
    // }
  }
}