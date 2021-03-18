using System.Collections;

// Создание простой пользовательской коллекции с использованием оператора yield.

namespace Lesson7
{
	// Класс, представляющий собой пользовательскую коллекцию.
	public class UserCollection3<T>
	{
	    readonly T[] elements = new T[4];

		public T this[int index]
		{
			get { return elements[index]; }
			set { elements[index] = value; }
		}

		int position = -1;

		// Создаем метод Reset().
		public void Reset()
		{
			position = -1;
		}

		// Создаем метод GetEnumerator(), используем оператор yield.
		public IEnumerator GetEnumerator()
		{
            // ---------- 1-й вариант. ----------

            while (true)
            {
                if (position < elements.Length - 1)
                {
                    position++;
                    // Оператор автоматической генерации кода для возврата итератора (создаст MoveNext()/Current())
                    // Этот оператор сигнализирует нам и компилятору,
                    // что данное выражение – итератор.Задача итератора перемещаться между элементами коллекции
                    // и возвращать значение текущего. Итераторы могут возвращать только тип IEnumerable<>.
                    yield return elements[position]; // Возвращаем итератор
                }
                else
                {
                    Reset();
                    yield break; // MoveNext(){return false;}
                }
            }

            // ---------- 2-й вариант. ----------

            //foreach (var element in elements)
            //{
            //    yield return element;
            //}

            // ---------- 3-й вариант. ----------

            //return elements.GetEnumerator();
        }
	}
}
