namespace Task2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[]{ 4, 4, 4, 4, 5 };
            
            Student student1 = new Student("Firdavs Jumayev", "+998900751455", 712, marks);

            Console.WriteLine($"{student1.FullName} avegare grade : " + student1.AverageGrade);

            Teacher teacher1 = new Teacher("Xudazarov Ravshan", "+9980000000", 123, 10_000);

            Console.WriteLine($"{teacher1.FullName},monthly income : " + teacher1.CalculateMonyhlyIncome());

            Employee employee1 = new Employee("Jasur Otaboyev", "+998909099996", 555, 5_000_000);

            Console.WriteLine($"{employee1.FullName} salary : " + employee1.CalculateTax());
        }

        class Person
        {
            public string FullName { get; set; }
            public string PhoneNumber { get; set; }
            public int ID { get; set; }
            public void DisplayInfo()
            {
                Console.WriteLine("FullName : " + FullName);
                Console.WriteLine("Phone number : " + PhoneNumber);
                Console.WriteLine("ID : " + ID);
            }
            //constructor
            public Person(string fullName, string phoneNumber , int ID)
            {
                FullName = fullName;
                PhoneNumber = phoneNumber;
                this.ID = ID;
            }
        }
        class Student : Person
        {
            public int[] Marks { get; set; }
            public double AverageGrade { get; }

            public Student(string fullName, string phoneNumber, int ID, int[] marks) :
                base(fullName, phoneNumber, ID)
            {
                Marks = marks;
                AverageGrade = marks.Sum() / marks.Length;
            }


        }
        class Teacher : Person
        {
            public decimal HourlyRate { get; set;}
            public decimal CalculateMonyhlyIncome()
            {
                return 26 * 8 * HourlyRate;
            }
            public Teacher(string fullName, string phoneNumber, int ID, decimal hourlyRate) :
                base(fullName, phoneNumber, ID)
            {
                HourlyRate = hourlyRate;
            }
        }
        class Employee : Person
        {
            public decimal Salary { get; set; }
            public decimal CalculateTax()
            {
                return Salary - Salary * 13/100;
            }
            public Employee(string fullName,string phoneNumber,int ID,decimal salary) :
                base(fullName, phoneNumber, ID)
            {
                Salary = salary;
            }
        }
    }
}