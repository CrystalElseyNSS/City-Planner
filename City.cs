using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        private string _cityName;

        public int YearEst { get; set; }

        public string Mayor { get; set; }

        private List<Building> _cityBuildings = new List<Building>();

        public City (string newCity) {
            _cityName = newCity;
        }

        public void BuildInTheCity(Building builtBuilding)
        {
            _cityBuildings.Add(builtBuilding);
        }
    }
}