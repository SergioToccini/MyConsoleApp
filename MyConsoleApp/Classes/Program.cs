using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var parent = new Parent("Sergey");
            var child = new Child("Alex", 30, true);

            parent.Name = "Sergey";
            parent.Age = 62;
            parent.IsMan = true;

            parent.WhoAmI();

            child.WhoAmI();

            Console.ReadKey();
        }
    }


    public class Parent 
    {
        public Parent(string name)
        {
            Name = name;
            Console.WriteLine("Конструктор Parent c 1 параметром");
        }

        public string Name { get; set; }
        public byte Age { get; set; }
        public bool IsMan { get; set; }

        public void WhoAmI()
        {
            Console.WriteLine("My name Parent");
        }
    }

    public class Child : Parent
    {
        public Child(string name) : base(name)
        {
            Console.WriteLine("Конструктор Child c 1 параметром");
        }

        public Child(string name, byte age) : this(name)
        {
            Name = name;
            Age = age;
            IsMan = true;

            Console.WriteLine("Конструктор Child с 2 параметрами");
        }

        public Child(string name, byte age, bool isMan) : this(name, age)
        {
            Name = name;
            Age = age;
            IsMan = isMan;

            Console.WriteLine("Конструктор Child с 3 параметрами");
        }


        public new void WhoAmI()
        {
            Console.WriteLine("My name Child");
        }
    }
}
