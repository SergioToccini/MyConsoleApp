using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4.Example
{
    public abstract class MyAbstractClass
    {
        public abstract void MyAbstractMethod();

        public virtual void MyVirtualMethod()
        {
            Console.WriteLine(nameof(MyVirtualMethod));
        }

        public void MyMethod()
        {
            Console.WriteLine(nameof(MyMethod));
        }
    }

    public class MySimpleClass : MyAbstractClass
    {
        public override void MyAbstractMethod()
        {
            throw new NotImplementedException();
        }

        public override void MyVirtualMethod()
        {
            base.MyVirtualMethod();
        }
    }
}
