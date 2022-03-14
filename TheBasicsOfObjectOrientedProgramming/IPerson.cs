namespace TheBasicsOfObjectOrientedProgramming
{
    public interface IPerson
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Sex { get; set; }
        Teacher Teacher { get; set; }
        Student Student { get; set; }

        public void PrintInfo();
    }
}
