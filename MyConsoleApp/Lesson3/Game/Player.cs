namespace Lesson3.Game
{
    public class Player
    {
        private IWeapon _weapon;
        private Armor _armor;

        public Player(IWeapon weapon, Armor armor)
        {
            _weapon = weapon;
            _armor = armor;
        }

        public void UseWeapon()
        {
            _weapon.Use();
        }

        public void ShowArmor()
        {
            _armor.Show();
        }


    }
}
