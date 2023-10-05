using System;
using System.Collections.Generic;

// Azubuike Ibe

namespace EntAppLab3
{
    // Interfaace for objects that has volume
    public interface IHasVolume
    {
        double CalcVolume();
        string ToString();
    }

    // Sphere class implementing IHasVolume
    public class Sphere : IHasVolume
    {
        private double radius;
        
        // Constructors
        public Sphere(double radius):base()
        {
            Radius = radius;
        }

        public Sphere() : this(0) { }

        // Property for radius
        public double Radius
        {
            get { return radius; }

            set
            {
                if(value >= 0)
                {
                    radius = value;
                }
                if(value < 0)
                {
                    throw new ArgumentException("Radius cannot be a negative number");
                }
            }
        }

        // Calculate bolume method (Implementation of IHasVolume)
        public double CalcVolume()
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 2);
            return Math.Round(volume, 2);
        }

        // Override ToString to display sphere information
        public override string ToString()
        {
            return $"Sphere - Radius: {Radius}, Volume: {CalcVolume()}";
        }

    }




    static class Text
    {
        static void Main(string[] args)
        {
           // Create a list of IHasVolume objects (including Sphere)
           List<IHasVolume> spheres = new List<IHasVolume>()
           {
                // Adding some Sphere objects to the list
                new Sphere(3.0),
                new Sphere(5.0),
                new Sphere(7.0)
            };

            // Calculate and display volumes using polymorphism
            foreach (var sphere in spheres)
            {
                Console.WriteLine(sphere.ToString());
                Console.WriteLine($"Volume: {sphere.CalcVolume()}");
                Console.WriteLine();
            }
        }
    }
       
    
}