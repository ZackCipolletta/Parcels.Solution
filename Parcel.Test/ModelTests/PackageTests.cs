using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Parcels.Models;
using System;

namespace Parcels.Tests
{
  [TestClass]
  public class PackageTests
  {
    [TestMethod]
    public void PackageConstructor_CreatesInstanceOfParcel_Volume()
    {
      int sidex = 4;
      Package newPackage = new Package(sidex, 3, 8, 40);
      int result = newPackage.SizeX;
      Assert.AreEqual(sidex, result);
    }

    [TestMethod]
    public void GetVolume_ReturnsVolume_Package()
    {
      Package newPackage = new Package(4, 5, 6, 0);
      // Act
      int packageVolume = newPackage.Volume();
      // Assert
      Assert.AreEqual(120, packageVolume);
    }
    [TestMethod]
    public void GetCost_ReturnsCost_Package()
    {
      Package newPackage = new Package(10, 20, 6, 100000);
      // Act
      int packageCost = newPackage.CostToShip();
      // Assert
      Assert.AreEqual(30, packageCost);
    }
  }
}