class Student
{
    private string name;
    private int age;
    private int grade;

    public Student(string Name, int Age, int Grade)
    {
        setName(Name);
        setAge(Age);
        setGrade(Grade);
    }

    public void setName(string Name)
    {
        name = Name;
    }

    public void setAge(int Age)
    {
        while (Age < 6)
        {
            Console.WriteLine("Age must be greater than 5");
            Age = int.Parse(Console.ReadLine());
        }
        age = Age;
    }

    public void setGrade(int Grade)
    {
        while (Grade < 0 || Grade > 100)
        {
            Console.WriteLine("Grade must be between 0 and 100");
            Grade = int.Parse(Console.ReadLine());
        }
        grade = Grade;
    }

    public string getName() => name;
    public int getAge() => age;
    public int getGrade() => grade;

    public void DisplayInfo()
    {
        Console.WriteLine($"Student name is {name}");
        Console.WriteLine($"Student age is {age}");
        Console.WriteLine($"Student grade is {grade}");
    }
}