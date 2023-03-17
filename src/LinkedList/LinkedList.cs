using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2___Reto___Interfaz_List_e_Iterator_en_Cs.src.LinkedList
{
    internal class LinkedList<T> : List<T>
    {
        private Node<T>? head;
        private Node<T>? tail;
        private int size;
        public void addAtTail(T data)
        {
            Node<T> node = new Node<T>();
            node.setData(data);

            if (size == 0)
            {
                head = node;
            }
            else
            {
                node.setPrevious(tail);
                tail.setNext(node);
            }
            tail = node;
            size++;
        }
        public void addAtFront(T data)
        {
            Node<T> node = new Node<T>();
            node.setData(data);
            if (size == 0)
            {
                tail = node;
            }
            else
            {
                node.setNext(head);
                head.setPrevious(node);
            }
            head = node;
            size++;
        }
        public void remove(int index)
        {
            if (index < size)
            {
                Node<T> node = head;
                for (int currentIndex = 0; currentIndex < index; currentIndex++)
                {
                    node = node.getNext();
                }
                if (node.getNext() == null)
                {
                    node.getPrevious().setNext(null);
                }
                else if (node.getPrevious() == null)
                {
                    node.getNext().setPrevious(null);
                }
                else
                {
                    node.getPrevious().setNext(node.getNext());
                    node.getNext().setPrevious(node.getPrevious());
                }

                size--;
            }
        }
        public void removeAll()
        {
            head = null;
            tail = null;
            size = 0;
        }
        public void setAt(int index, T data)
        {
            if (index <= size)
            {
                Node<T> nodo = head;
                for (int currentIndex = 0; currentIndex < index; currentIndex++)
                {
                    nodo = nodo.getNext();
                }
                nodo.setData(data);
            }
        }
        public T? getAt(int index)
        {
            if (index < 0 || index >= size)
            {
                return default;
            }
            Node<T> currentNode = head;
            for (int currentIndex = 0; currentIndex < index; currentIndex++)
            {
                currentNode = currentNode.getNext();
            }
            return currentNode.getData();
        }
        public void removeAllWithValue(T data)
        {
            Node<T> node = head;
            for (int currentIndex = 0; currentIndex < size; currentIndex++)
            {
                if(node.getData().Equals(data))
                {
                    if (node.getNext() == null)
                    {
                        node.getPrevious().setNext(null);
                        tail = node.getPrevious();
                    }
                    else if (node.getPrevious() == null)
                    {
                        node.getNext().setPrevious(null);
                        head = node.getNext();
                    }
                    else
                    {
                        node.getPrevious().setNext(node.getNext());
                        node.getNext().setPrevious(node.getPrevious());
                    }
                    size--;
                }
                node = node.getNext();
            }
        }

        public int getSize()
        {
            return size;
        }
        public Iterator<T> getIterator()
        {
            return new LinkedListIterator<T>(head);
        }
    }
}
