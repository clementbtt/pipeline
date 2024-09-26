namespace Logic
{
    public class Person
    {
        private string name;
        private string fname;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Fname { get => fname; set => fname = value; }
        public int Age { get => age; set => age = value; }


        public Person(string name, string fname, int age)
        {
            this.name = name;
            this.fname = fname;
            this.age = age;
        }
    }
}
