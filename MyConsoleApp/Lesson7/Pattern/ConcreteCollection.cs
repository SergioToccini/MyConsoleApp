using System.Collections;

// "ConcreteAggregate" 

namespace Lesson7.Pattern
{
    public class ConcreteCollection : IterableCollection
    {
        private readonly ArrayList elements = new ArrayList();

        private ConcreteIterator iterator;

        public override IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return elements.Count; }
        }

        public override object this[int index]
        {
            get { return elements[index]; }
            set { elements.Insert(index, value); }
        }
    }
}
