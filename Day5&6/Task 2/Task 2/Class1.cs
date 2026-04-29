using System;

namespace Task_2
{
    public class Vehicle
    {
        private string Brand;
        private string Model;
        private double RentalPricePerDay;
        private int LateDays;

        public void SetBrand(string brand)
        {
            this.Brand = brand;
        }

        public void SetModel(string model)
        {
            this.Model = model;
        }

        public void SetRentalPricePerDay(double rentalPricePerDay)
        {
            this.RentalPricePerDay = rentalPricePerDay;
        }

        public string GetBrand()
        {
            return this.Brand;
        }

        public string GetModel()
        {
            return this.Model;
        }

        public double GetRentalPricePerDay()
        {
            return this.RentalPricePerDay;
        }

        public virtual double CalculateRentalCost(int days)
        {
            //return RentalPricePerDay * days;
            double baseCost = RentalPricePerDay * days;

            double latePenalty = LateDays * RentalPricePerDay * 0.2;

            return baseCost + latePenalty;
        }


        public void SetLateDays(int lateDays)
        {
            this.LateDays = lateDays;
        }

        public int GetLateDays()
        {
            return this.LateDays;
        }
    }

    public class Car : Vehicle
    {
        public override double CalculateRentalCost(int days)
        {
            //return GetRentalPricePerDay() * days * 1.5;

            double baseCost = GetRentalPricePerDay() * days * 1.5;

            double latePenalty = GetLateDays() * GetRentalPricePerDay() * 0.5;

            return baseCost + latePenalty;
        }
    }

    public class Bike : Vehicle
    {
        public override double CalculateRentalCost(int days)
        {
            //return GetRentalPricePerDay() * days * 1.2;

            double baseCost = GetRentalPricePerDay() * days * 1.2;

            double latePenalty = GetLateDays() * GetRentalPricePerDay() * 0.2;

            return baseCost + latePenalty;
        }
    }

    public class Truck : Vehicle
    {
        public override double CalculateRentalCost(int days)
        {
            //return GetRentalPricePerDay() * days * 1.8;

            double baseCost = GetRentalPricePerDay() * days * 1.8;

            double latePenalty = GetLateDays() * GetRentalPricePerDay() * 0.8;

            return baseCost + latePenalty;
        }
    }
}