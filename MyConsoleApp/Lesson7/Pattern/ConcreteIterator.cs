// "ConcreteIterator"

namespace Lesson7.Pattern
{
    public class ConcreteIterator : IIterator
    {
        private readonly ConcreteCollection _collection;
        private int _index;

        public ConcreteIterator(ConcreteCollection collection)
        {
            _collection = collection;
        }

        public object First()
        {
            return _collection[0];
        }

        public object MoveNext()
        {
            if (_index < _collection.Count)
            {
                return _collection[_index++];
            }

            return _collection[_index];
        }

        public void Reset()
        {
            _index = 0;
        }

        public object Current()
        {
            return _collection[_index];
        }

        public bool IsDone()
        {
            return _index > _collection.Count - 1;
        }
    }
}
