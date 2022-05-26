using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class LinkedList<K, V> where K : IComparable
    {
        //linkedlist node created with key-value pair
        public MyMapNode<K, V> head;
        public MyMapNode<K, V> tail;
        public LinkedList()
        {
            this.head = null;
            this.tail = null;
        }
        public MyMapNode<K, V> Search(K key)
        {
            //head assign as temp
            MyMapNode<K, V> temp = head;
            while (temp != null)
            {
                if (temp.key.Equals(key))
                    return temp;
                temp = temp.next;
            }
            return null;
        }
        public void Append(MyMapNode<K, V> node)
        {
            //check node present or not
            if (this.head == null && this.tail == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                //if present then node added from the end
                tail.next = node;
                tail = node;
            }
        }
    }
}
