namespace Lesson3.Game
{
    public abstract class Armor : IName
    {
        public string Name { get; set; }
        public int Defence { get; set; }
        public bool IsEquipped { get; set; }

        public abstract void Show();

        public void SayHello()
        {
            System.Console.WriteLine("Hello!");
        }
    }
}
