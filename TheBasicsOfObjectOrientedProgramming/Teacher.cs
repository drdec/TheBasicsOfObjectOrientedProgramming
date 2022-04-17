namespace TheBasicsOfObjectOrientedProgramming
{
    public class Teacher : IPerson
    {
        private int _age;
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
        public string Discipline { get; set; }
        
        public Teacher()
        {
            Age = 17;
            FirstName = "";
            SecondName = "";
            Sex = "";
            Discipline = "";
        }

        public Teacher(string firstName, string secondName,int age, string sex, string discipline)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
            Sex = sex;
            Discipline = discipline;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Фамилия - {SecondName}\n" +
                              $"Имя - {FirstName}\n" +
                              $"Возраст - {Age}\n" +
                              $"Пол - {Sex}\n" +
                              $"Дисциплина - {Discipline}");
        }
    }
}
