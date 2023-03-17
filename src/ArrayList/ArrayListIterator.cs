using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2___Reto___Interfaz_List_e_Iterator_en_Cs.src.ArrayList
{
    internal class ArrayListIterator<T> : Iterator<T>
    {
        private ArrayList<T> iterator;
        private int currentIndex;
        public ArrayListIterator(ArrayList<T> array)
        {
            iterator = array;
            currentIndex = 0;
        }
        public bool hasNext()
        {
            if (currentIndex < iterator.getSize())
            {
                return true;
            }
            return false;
        }
        public T next()
        {

            T data = iterator.getAt(currentIndex);
            currentIndex++;
            return data;
        }
    }
}
