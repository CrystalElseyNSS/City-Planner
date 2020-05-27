using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building myFirstBuilding = new Building("123 4th Street")
            {
                Stories = 10,
                Width = 100.5,
                Depth = 200.5,
            };
            myFirstBuilding.ConstructedOn();
            myFirstBuilding.DesignedBy("Crystal Elsey");
            myFirstBuilding.BuildingReport();

            Building mySecondBuilding = new Building("456 7th Street")
            {
                Stories = 30,
                Width = 300.6,
                Depth = 250.4,
            };
            myFirstBuilding.ConstructedOn();
            myFirstBuilding.DesignedBy("Mo Silvera");
            myFirstBuilding.BuildingReport();
        }
    }
}
