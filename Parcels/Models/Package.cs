using System.Collections.Generic;

namespace Parcels.Models
{
  public class Package
  {
    public string PackageType { get; set; }
    public int SizeX { get; set; }
    public int SizeY { get; set; }
    public int SizeZ { get; set; }
    public int WeightOZ { get; set; }

    public Package(int side1, int side2, int side3, int weight)
    {
      SizeX = side1;
      SizeY = side2;
      SizeZ = side3;
      WeightOZ = weight;
    }

    public int Volume()
    {
      int volume = SizeX * SizeY * SizeZ;
      return volume;
    }

    public int CostToShip()
    {
      int cost = 20;
      if (Volume() >= 1000)
      {
        cost = cost + 5;
      }
      if (WeightOZ >= 160)
      {
        cost = cost + 5;
      }
      return cost;
    }

  }
}