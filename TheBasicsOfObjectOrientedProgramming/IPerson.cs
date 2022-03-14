namespace TheBasicsOfObjectOrientedProgramming
{
    public interface IPerson
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Sex { get; set; }

        public void PrintInfo();
    }
}
