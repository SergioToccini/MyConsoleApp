using System;

namespace Lesson3.Game
{
    public class Sword : IWeapon, IName
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Use()
        {
            Console.WriteLine("Sword slash!");
        }
    }
}
