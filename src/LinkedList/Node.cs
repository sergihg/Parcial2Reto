using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2___Reto___Interfaz_List_e_Iterator_en_Cs.src.LinkedList
{
    internal class Node<T>
    {
        T? data;
        Node<T>? next;
        Node<T>? previous;

        public T? getData()
        {
            return data;
        }

        public Node<T>? getNext()
        {
            return next;
        }

        public Node<T>? getPrevious()
        {
            return previous;
        }

        public void setData(T data)
        {
            this.data = data;
        }

        public void setNext(Node<T>? next)
        {
            this.next = next;
        }

        public void setPrevious(Node<T>? previous)
        {
            this.previous = previous;
        }
    }
}
