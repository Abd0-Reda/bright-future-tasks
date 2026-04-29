namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            DigitalProduct digital = new DigitalProduct();
            digital.setName("Course");
            digital.setPrice(100);
            digital.setQuantity(2);
            digital.setLink("www.course.com");

            PhysicalProduct physical = new PhysicalProduct();
            physical.setName("Phone");
            physical.setPrice(5000);
            physical.setQuantity(1);
            physical.setShippingCost(50);

            cart.AddProduct(digital);
            cart.AddProduct(physical);

            int total = cart.CalculateTotal();

            Console.WriteLine("Total Price = " + total);
        }
    }
}
