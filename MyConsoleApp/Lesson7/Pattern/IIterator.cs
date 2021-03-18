// "Iterator"

namespace Lesson7.Pattern
{    
    public interface IIterator
    {
        object First();
        object MoveNext();
        bool IsDone();
        void Reset();
        object Current();
    }
}
