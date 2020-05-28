using System;

namespace Planner {
    class Program {
        static void Main (string[] args) {
            Building buildingOne = new Building ("1 Marvel Ave") {
                Stories = 10,
                Width = 100.5,
                Depth = 200.5,
            };
            buildingOne.ConstructedOn ();
            buildingOne.DesignedBy ("Calvin Curry");
            buildingOne.PurchasedBy ("Crystal Elsey");
            buildingOne.BuildingReport ();

            Building buildingTwo = new Building ("2 Milky Way") {
                Stories = 30,
                Width = 300.6,
                Depth = 250.4,
            };
            buildingTwo.ConstructedOn ();
            buildingTwo.DesignedBy ("Mo Silvera");
            buildingTwo.PurchasedBy ("Kristen Howton");
            buildingTwo.BuildingReport ();

            Building buildingThree = new Building ("3 Abbey Road") {
                Stories = 20,
                Width = 250,
                Depth = 325.4,
            };
            buildingThree.ConstructedOn ();
            buildingThree.DesignedBy ("Sarah Hart Landolt");
            buildingThree.PurchasedBy ("Mark McCann");
            buildingThree.BuildingReport ();

            Building buildingFour = new Building ("4 Awesome Town Lane") {
                Stories = 15,
                Width = 101.2,
                Depth = 202.3,
            };
            buildingFour.ConstructedOn ();
            buildingFour.DesignedBy ("Sarah Hart Landolt");
            buildingFour.PurchasedBy ("Mark McCann");
            buildingFour.BuildingReport ();
        }
    }
}