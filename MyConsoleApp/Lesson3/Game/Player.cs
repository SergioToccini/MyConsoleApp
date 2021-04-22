using System;

namespace Lesson3.Game
{
    public class Player
    {
        private IWeapon _weapon;
        private Armor _armor;

        public Player()
        {
            Console.WriteLine("Я конструктор без параметров");
        }

        public Player(IWeapon weapon) : this()
        {
            _weapon = weapon;
        }

        public void SetArmor(Armor armor)
        {
            _armor = armor;
        }

        public void SetWeapon(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void ShowArmor()
        {
            _armor.Show();
        }

        public void UseWeapon()
        {
            _weapon.Use();
        }



    }
}
