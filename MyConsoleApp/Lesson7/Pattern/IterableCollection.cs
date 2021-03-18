// "Aggregate"

namespace Lesson7.Pattern
{
    public abstract class IterableCollection
    {
        public abstract IIterator CreateIterator();
        public abstract object this[int index] { get; set; }
    }
}
