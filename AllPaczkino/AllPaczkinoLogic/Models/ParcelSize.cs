﻿namespace Parcels.Parcels
{
    public class ParcelSize
    {
        public string Name { get; set; }
        //public double? Length { get; private set; }

        //public double? Width { get; private set; }

        //public double? Height { get; private set; }

        //public double? Weight { get; private set; }

        //public double? Price { get; private set; }

        public ParcelSize(string name/*, double length, double width, double height, double weight, double price*/)
        {
            Name = name;
            //Length = length;
            //Width = width;
            //Height = height;
            //Weight = weight;
            //Price = price;
        }

        public ParcelSize() { }
    }
}

