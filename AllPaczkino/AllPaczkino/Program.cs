using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcels.Parcels;

namespace AllPaczkino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ParcelSize> parcels = new List<ParcelSize>();

            ParcelSize smallParcel = new ParcelSize("Small Parcel", 10, 20, 30, 5, 7.99);
            ParcelSize mediumParcel = new ParcelSize("Medium Parcel", 20, 30, 50, 10, 10.99);
            ParcelSize largeParcel = new ParcelSize("Large Parcel", 40, 40, 70, 20, 14.99);

            parcels.Add(smallParcel);
            parcels.Add(mediumParcel);
            parcels.Add(largeParcel);

            Console.WriteLine("Choose your parcel size by typing S, M or L: ");

            foreach (ParcelSize parcelSize in parcels)
            {
                Console.WriteLine(parcelSize.Name + " max length: " + parcelSize.Length + " cm, max width: " + parcelSize.Width + " cm, max height: " + parcelSize.Height + " cm, max weight " + parcelSize.Weight + " kg, Price: " + parcelSize.Price);
            }



        }
    }
}