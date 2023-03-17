using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2___Reto___Interfaz_List_e_Iterator_en_Cs.src.LinkedList
{
    internal class LinkedListIterator<K> : Iterator<K>
    {
        private Node<K>? currentNode;
        public LinkedListIterator(Node<K> head)
        {
            currentNode = head;
        }
        public bool hasNext()
        {
            if (currentNode == null)
            {
                return false;
            }
            return true;
        }
        public K next()
        {
            K data = currentNode.getData();
            currentNode = currentNode.getNext();
            return data;
        }
    }
}
