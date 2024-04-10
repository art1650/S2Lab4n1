using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2Lab4n1
{
    public class Truck
    {
        public int LoadCapacity;
        public int Weight;

        public void SetLoadCapacity(int LoadCapacity)
        {
            this.LoadCapacity = LoadCapacity;
        }
        public int GetLoadCapacity()
        {
            return LoadCapacity;
        }
        public void SetWeighr(int Weight)
        {
            this.Weight = Weight;
        }

        public override string ToString()
        {
            return $"Вантажопідйомність = {LoadCapacity}, вага = {Weight}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Truck truck)
            return LoadCapacity == truck.LoadCapacity && Weight == truck.Weight;
            return false;
        }
    }
    public class LightweightCar: Truck
    {
        public string Brand;

        public string GetBrend()
        {
            return Brand;
        }
        public void SetBrend(string Brend)
        {
            this.Brand = Brend;
        }

        public override string ToString()
        {
            return $"Вантажопідйомність = {LoadCapacity}, вага = {Weight}, марка - {Brand}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is LightweightCar truck)
                return LoadCapacity == truck.LoadCapacity && Weight == truck.Weight && Brand == truck.Brand;
            return false;
        }

        
       
    }

    public class Car : LightweightCar
    {
       
        public string Color ;

        public Car(int LoadCapacity, int Weight, string Brand, string Color)
        {
            this.LoadCapacity = LoadCapacity;
            this.Weight = Weight;
            this.Brand = Brand;
            this.Color = Color;
        }

        public override bool Equals(object? obj)
        {
            if (obj is LightweightCar truck)
                return LoadCapacity == truck.LoadCapacity && Weight == truck.Weight && Brand == truck.Brand && Color == Color;
            return false;
        }

        public void SetColor(string Color)
        {
            this.Color = Color;
        }

        public void Write()
        {
            Console.WriteLine($"груз на = {LoadCapacity} вага = {Weight} марка - {Brand} колір - {Color}");
        }

        public void ChangeColor(Car Color, string s )
        {
            Color.SetColor(s);
        }
        public void ChangeBrend(Car brend, string s)
        {
            brend.SetBrend(s);
        }
        public void ChangeLoadCapacity(Car LoadCapacity, int x)
        {
            LoadCapacity.SetLoadCapacity(x + GetLoadCapacity());
        }
        public void ChangeWeight(Car Weight, int x)
        {
            Weight.SetWeighr(x);
        }
    }
}
