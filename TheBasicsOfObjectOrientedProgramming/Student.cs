namespace TheBasicsOfObjectOrientedProgramming
{
    public class Student : IPerson
    {
        private int _age;
        private double _academicPerformance;
        private int _course;
        public int Age
        {
            get => _age;
            set
            {
                if (value < 16)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _age = value;
                }
            }
        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Sex { get; set; }
        public double AcademicPerformance
        {
            get => _academicPerformance;
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _academicPerformance = value;
                }
            }
        }
        public int Course
        {
            get => _course;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _course = value;
                }
            }
        }
        

        public Student()
        {
            Age = 17;
            FirstName = "";
            SecondName = "";
            Sex = "";
            Course = 1;
            AcademicPerformance = 0;
        }

        public Student(string firstName, string secondName, int age, string sex, int course, double academicPerformance)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
            Sex = sex;
            Course = course;
            AcademicPerformance = academicPerformance;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Фамилия - {SecondName}\n" +
                              $"Имя - {FirstName}\n" +
                              $"Возраст - {Age}\n" +
                              $"Пол - {Sex}\n" +
                              $"Курс - {Course}\n" +
                              $"Успеваемость - {AcademicPerformance}");
        }
    }
}
