namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetRentalPricePerDay(100);
            car.SetLateDays(2);

            Console.WriteLine(car.CalculateRentalCost(3));


            Console.ReadLine();
        }
    }
}
