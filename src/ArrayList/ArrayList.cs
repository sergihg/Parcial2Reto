using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2___Reto___Interfaz_List_e_Iterator_en_Cs.src.ArrayList
{
    internal class ArrayList<T> : List<T>
    {
        private int size;
        private T[] array;

        public ArrayList()
        {
            array = new T[GlobalConstant.INITIAL_SIZE];
        }
        public void addAtTail(T data)
        {
            if (size == array.Length)
            {
                increaseSize();
            }
            array[size] = data;
            size++;
        }
        public void addAtFront(T data)
        {
            if (size == array.Length)
            {
                increaseSize();
            }
            for (int i = size; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = data;
            size++;
        }
        public void remove(int index)
        {
            if (index < size)
            {
                for (int i = index; i < (size - 1); i++)
                {
                    array[i] = array[i + 1];
                }
                array[size - 1] = default;
                size--;
            }
        }

        public void removeAll()
        {
            array = new T[GlobalConstant.INITIAL_SIZE];
            size = 0;
        }
        public void setAt(int index, T data)
        {
            if (index < size)
            {
                array[index] = data;
            }
        }
        public T getAt(int index)
        {
            if (index < size)
            {
                return array[index];
            }
            return default;
        }
        public void removeAllWithValue(T data)
        {
            for (int i = 0; i < size; i++)
            {
                if (array[i].Equals(data))
                {
                    for (int j = i; j < (size - 1); j++)
                    {
                        array[j] = array[j + 1];
                    }
                    array[size - 1] = default;
                    size--;
                }
            }
        }
        public int getSize()
        {
            return size;
        }
        public Iterator<T> getIterator()
        {
            return new ArrayListIterator<T>(this);
        }

        private void increaseSize()
        {
            T[] newArray = (new T[array.Length * 2]);
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
    }
    public static class GlobalConstant
    {
        public const int INITIAL_SIZE = 2;
    }
}
