using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment10_3.Models;
using Assignment10_3.Data;

namespace Assignment10_3.Services
{
    public class CRUD
    {
        private static readonly string VinCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public void AddRecord(Car car)
        {
            // object getting added in dbset (local copy)
            Data.Records.carContext.Cars.Add(car);
            Records.carContext.SaveChanges();
        }
        public void DeleteRecord(string VIN)
        {
            var car = Records.carContext.Cars.Find(VIN);
            if (car != null)
            {
                Records.carContext.Cars.Remove(car);
            }
            Records.carContext.SaveChanges();

        }
        public void UpdateRecord(string VIN, Car car)
        {
            var cartoupdate = Records.carContext.Cars.Find(VIN);
            if (cartoupdate != null)
            {
                cartoupdate.Vin = car.Vin;
                cartoupdate.Make = car.Make;
                cartoupdate.Model = car.Model;
                cartoupdate.Year = car.Year;
                cartoupdate.Price = car.Price;

                Records.carContext.SaveChanges();
            }
        }
        
        public ICollection<Car> GetCars()
        {
            return Records.carContext.Cars.ToList();
        }
        
        public Car FindCar(string VIN)
        {
            return Records.carContext.Cars.Find(VIN);
        }
        public string GetVIN()
        {
            Random random = new Random();
            StringBuilder vin = new StringBuilder(17);

            for (int i = 0; i < 17; i++)
            {
                vin.Append(VinCharacters[random.Next(VinCharacters.Length)]);
            }

            return vin.ToString();
        }
    }
}
