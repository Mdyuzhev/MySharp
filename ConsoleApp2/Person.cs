namespace ConsoleApp2
{
    public class Person
    {
        private string name;
        private int age;
        private string address;

        public Person()
        {
        }

        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }
    }
}