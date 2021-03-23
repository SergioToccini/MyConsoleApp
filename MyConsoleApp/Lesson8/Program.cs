using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Lesson8
{
    class Program
    {
        // IEnumerable, IEnumerable<T>	Единственное, что вам нужно, это перебирать элементы в коллекции. Вам нужен только доступ только для чтения к этой коллекции.
        // ICollection, ICollection<T> Вы хотите изменить коллекцию или заботитесь о ее размере.
        // IList, IList<T> Вы хотите изменить коллекцию, и вы заботитесь о порядке и / или расположении элементов в коллекции.

        #region ВАЖНО! ОБЯЗАТЕЛЬНО К ПРОЧТЕНИЮ!
        /*
        IDictionary - для карт ключ->значение, ICollection - для наборов похожих объектов.

        IDictionary - это интерфейс для сопоставления одного типа объекта или значения с другим. 
        Он работает как настоящий словарь или телефонная книга: у вас есть "key" в уме, как имя человека, и когда вы ищете его, 
        вы получаете некоторую информацию, которая идентифицируется этим ключом, например адрес или номер телефона. 
        Каждый ключ может быть указан только один раз, хотя два разных ключа по-прежнему могут иметь одно и то же значение. 
        Cловарь, ключи которого являются строками, a значения-целыми числами, будет IDictionary<string,int> .

        Словарь на самом деле представляет собой набор пар ключ/значение: вы можете использовать IDictionary<int,string> 
        как ICollection<KeyValuePair<int,string>> , и вы можете получить доступ к ключам и значениям как к отдельным коллекциям 
        со свойствами ключей и значений.

        И ICollection , и IDictionary неупорядочены, что означает, что, хотя вы можете получить элементы в некотором порядке 
        с помощью метода CopyTo или цикла foreach, этот порядок не имеет особого значения и может измениться без видимой причины. 
        В этом и заключается основное различие между ICollection и IList : список позволяет помещать элементы в определенные позиции, 
        как массив, и они остаются там до тех пор, пока вы их не переместите.

        List<> и Dictionary<,> -довольно разные структуры данных, которые используются для разных целей, 
        список - это просто набор элементов, а словарь - это набор пар ключ-значение.
        List
        Когда заканчивается место во внутреннем массиве создается новый, в два раза больше, и в него копируются данные со старого.
        + доступ по индексу быстрый. Добавление в конец быстрое.
        - доступ по значению медленный. Удаление меленное. Вставка медленная.


        Словарь довольно полезен, когда у вас есть набор сложных объектов и вы хотите иметь быстрый доступ, скажем, 
        к ObjectName/ObjectId,, в этом случае вы создаете IDictionary<string, TObject> , 
        где ключ будет ObjectId, а значение будет самим объектом.

        Некоторые отличия:

        Список сохраняет порядок элементов, словарь - нет
        Список позволяет быстро получить доступ по индексу
        Поддержка списка встроенный алгоритм QuickSort для быстрой сортировки данных
        Словарь позволяет ~ O(n * k) временной сложности получить доступ к элементу (значению) с помощью ключа

        Dictionary<K,V> -ассоциативный массив, или карта. Это контейнер, который может быть проиндексирован значениями любого типа.
        List<T> -это целочисленный индексированный массив. Это контейнер, который индексируется смежными целыми числами.

        Таким образом, существенная разница заключается в том, как индексируются контейнеры.

        Не попадайтесь в ловушку, полагая, что Dictionary<int,T> семантически эквивалентно List<T> . 
        Разница в том, что индексация List<T> является непрерывной, тогда как в индексации Dictionary<int,T> могут быть пробелы .
        */
        #endregion

        // Big O - https://www.youtube.com/watch?v=ZRdOb4yR0kk

        static void Main(string[] args)
        {
 
            //TryUserCollection();
            //TryGenericUserCollection();
            //TryCustomList();
            //EncapsulateLogic();
            //TryDictionary();
            //TryHashtable1();
            TryHashtable2();


            Console.ReadKey();
        }

        private static void TryUserCollection()
        {
            var collection = new UserCollection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(new string('-', 2));

            var array = new object[collection.Count];

            collection.CopyTo(array, 0);

            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
        }

        private static void TryGenericUserCollection()
        {
            var collection = new GenericUserCollection<int> {1, 2, 3};

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(collection.Contains(2));
        }

        private static void TryCustomList()
        {
            var test = new CustomList {"one", "two", "three", "four", "five", "six", "seven", "eight"};

            test.PrintContents();

            Console.WriteLine("Удаление элементов из списка");
            test.Remove("six");
            test.Remove("eight");
            test.PrintContents();

            Console.WriteLine("Добавить элемент в конец списка");
            test.Add("nine");
            test.PrintContents();

            Console.WriteLine("Вставить элемент в середине списка");
            test.Insert(4, "number");
            test.PrintContents();

            Console.WriteLine("Проверка конкретных элементов в списке:");
            Console.WriteLine("Список содержит \"three\": {0}", test.Contains("three"));
            Console.WriteLine("Список содержит \"ten\"  : {0}", test.Contains("ten"));

            Console.WriteLine("\nПеречисление всех элементов в коллекции:");
            foreach (string s in test)
            {
                Console.WriteLine(s);
            }

        }

        private static void EncapsulateLogic()
        {
            var account = new Account("xxx@mail.ru", "xxxpassword");
            // Доступ по методу
            account.AddRole(new Role("Хорошая роль 1"));
            account.AddRole(new Role("Хорошая роль 2"));
            account.AddRole(new Role("Хорошая роль 3"));
            // Доступ по индексу
            //account.Roles[1].Name = "Негодяй";
            //account.Roles[2].Name = "Инжектит";
            //account.Roles[3].Name = "Шляпу";

            Console.WriteLine(string.Join(", ", account.Roles.Select(x => x.Name)));
        }

        private static void TryDictionary()
        {
            var dict = new Dictionary<int, string>();
            dict[3] = "Three";
            dict[4] = "Four";
            dict[1] = "One";
            dict[2] = "Two";
            dict[2] = "Tw1o";
            string str = dict[3];

            foreach (var i in dict)
            {
                Console.WriteLine("{0} = {1}", i.Key, i.Value);
            }

            Console.WriteLine(new string('-', 25));

            foreach (var value in dict.Values)
            {
                Console.WriteLine(value);
            }
        }

        private static void TryHashtable1()
        {
            var emailLookup = new Hashtable();

            // Метод Add принимает в качестве первого параметра ключ,
            // а в качестве второго - значение
            emailLookup.Add("sbishop@contoso.com", "Bishop, Scott");

            // Невозможно добавить элемент с уже имеющимся в хэш-таблице ключом.
            //emailLookup.Add("sbishop@contoso.com", "Bishop, Scott2");

            // Особенности использования индексаторов.

            // Использование индексатора эквивалентно вызову Add, 
            // если такого индекса не существует.
            emailLookup["s.bishop@contoso.com"] = "Bishop, Scott";

            // Если такой индекс существует, то происходит только замена значения.
            emailLookup["sbishop@contoso.com"] = "-------------";


            Console.WriteLine(emailLookup["sbishop@contoso.com"]);
            Console.WriteLine(emailLookup["s.bishop@contoso.com"]);
        }

        private static void TryHashtable2()
        {
            var duplicates = new Hashtable();

            duplicates["First"] = "1st";
            duplicates["First"] = "the first";

            Console.WriteLine(duplicates["First"]);

            Console.WriteLine(duplicates.Count);

            // Delay.
            Console.ReadKey();
        }

    }
}
