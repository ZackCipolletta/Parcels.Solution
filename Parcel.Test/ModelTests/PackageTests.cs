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
  }
}