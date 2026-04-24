namespace oop_task1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Student ahmed = new Student("Ahmed" , 23 , 89);
            ahmed.DisplayInfo();
            ahmed.setGrade(105);
            ahmed.DisplayInfo();
        }
    }
}
