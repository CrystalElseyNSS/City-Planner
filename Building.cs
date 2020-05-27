using System;
using System.Collections.Generic;

namespace Planner
{
    public class Building 
    {
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume 
        {
            get {
                return Width * Depth * (3 * Stories);
            }
        }

        private string _designer = "Crystal Elsey";
        private DateTime _dateConstructed = new DateTime();
        private string _address = "303 Criddle Street";

        public Building(string newBuilding)
        {
            _address = newBuilding;
        }

        public void ConstructedOn()
        {
            _dateConstructed = DateTime.Now;
        }

        public void DesignedBy(string Designer)
        {
            _designer = Designer;
        }

        public void BuildingReport()
        {
            Console.WriteLine($"Designed by: {this._designer}");
            Console.WriteLine($"Constructed on: {this._dateConstructed}");
            Console.WriteLine($"Address: {this._address}");
            Console.WriteLine($"Volume: {this.Volume}");
        }
    }
}