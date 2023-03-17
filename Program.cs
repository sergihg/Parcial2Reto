
using System;

namespace Parcial_2___Reto___Interfaz_List_e_Iterator_en_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int option, index;
            string data;
            //List<String>? list = new ArrayList<>();
            src.List<string>? list = new src.LinkedList.LinkedList<string>();
            src.Iterator<string>? iterator;

            do
            {
                Console.WriteLine("Opcion 1: addAtTail");
                Console.WriteLine("Opcion 2: addAtFront");
                Console.WriteLine("Opcion 3: remove");
                Console.WriteLine("Opcion 4: removeAll");
                Console.WriteLine("Opcion 5: setAt");
                Console.WriteLine("Opcion 6: getAt");
                Console.WriteLine("Opcion 7: removeAllWithValue");
                Console.WriteLine("Opcion 8: getSize");
                Console.WriteLine("Opcion 9: getIterator\n");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("data: ");
                        data = Console.ReadLine();
                        list.addAtTail(data);
                        break;
                    case 2:
                        Console.WriteLine("data: ");
                        data = Console.ReadLine();
                        list.addAtFront(data);
                        break;
                    case 3:
                        Console.WriteLine("index: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        list.remove(index);
                        break;
                    case 4:
                        list.removeAll();
                        break;
                    case 5:
                        Console.WriteLine("data: ");
                        data = Console.ReadLine();
                        Console.WriteLine("index: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        list.setAt(index, data);
                        break;
                    case 6:
                        Console.WriteLine("index: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        data = list.getAt(index);
                        Console.WriteLine(data);
                        break;
                    case 7:
                        Console.WriteLine("data: ");
                        data = Console.ReadLine();
                        list.removeAllWithValue(data);
                        break;
                    case 8:
                        index = list.getSize();
                        Console.WriteLine("size: " + index);
                        break;
                    case 9:
                        iterator = list.getIterator();
                        while (iterator.hasNext())
                        {
                            Console.WriteLine(iterator.next());
                        }
                        break;
                }
            } while (option != 0||option <10);

        }
    }
}
