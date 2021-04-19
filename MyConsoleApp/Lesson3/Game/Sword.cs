using System;

namespace Lesson3.Game
{
    public class Sword : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Sword slash!");
        }
    }
}
