using System;
using Lesson5.Abstraction;

namespace Lesson5.Implementation
{
    public class Player : User
    {
        private IWeapon _weapon;
        private IWeapon _weapon1;





        public Player(IWeapon weapon, string name, int x, int y) : base(name, x)
        {
            _weapon = weapon;
            _weapon1 = new FireStaff();
        }
    }

    public class User
    {
        // Конструктор 1
        public User()
        {
            Console.WriteLine("Конструктор 1");
        }
        // Конструктор 2
        public User(int x) : this()
        {
            Console.WriteLine("Конструктор 2");
        }
        // Конструктор 3
        public User(string name, int x, int y = 28) : this(y)
        {
            Console.WriteLine("Конструктор 3");

            this.MMM(name);
        }

        public string Name { get; set; } = "Ivan";

        public void MMM(string xxx)
        {

        }
    }
}
