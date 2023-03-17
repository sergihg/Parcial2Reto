using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Parcial_2___Reto___Interfaz_List_e_Iterator_en_Cs.src
{
    internal interface List<T>
    {
        void addAtTail(T data);
        void addAtFront(T data);
        void remove(int index);
        void removeAll();
        void setAt(int index, T data);
        T getAt(int index);
        void removeAllWithValue(T data);
        int getSize();
        Iterator<T> getIterator();
    }
}
