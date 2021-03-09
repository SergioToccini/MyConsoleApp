using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4.Example
{
    // Интерфейс - именнованный набор сигнатур методов
    // Наследование - механизм ООП, позволяющий описать новый(производный) класс на основе уже существующего(базового).
    // При этом своиства и функциональность базового класса, наследуются производным
    // Реализация интерфейса - обязательство производного класса реализовать все поля и методы на основе интерфейса
    // Отличие реализации интерфейса от наследования в том, что класс может реализовать более одного интерфейса
    // Класс может реализовывать сколько угодно интерфейсов
    // Интерфейсы могут наследоваться друг от друга, в такм случае принято говорить интерфейс A расширяет интерфейс B
    // Поля и методы интерфейсов имеют тот же можификатор доступа что и сам интерфейс
    public interface ICar
    {
        string Move(int distance);
        string Stop(bool isMove);
    }

    public interface IHaveSiren
    {
        void MakeWow();
        string Stop(bool isMove);
    }

    public class PoliceCar : ICar, IHaveSiren
    {
        public string Move(int distance)
        {
            throw new NotImplementedException();
        }

        public string Stop(bool isMove)
        {
            throw new NotImplementedException();
        }



        public void MakeWow()
        {
            throw new NotImplementedException();
        }
    }

    public class TaxiCar : ICar
    {
        public string Move(int distance)
        {
            throw new NotImplementedException();
        }

        public string Stop(bool isMove)
        {
            throw new NotImplementedException();
        }


    }

}
