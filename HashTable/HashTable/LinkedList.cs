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
        public bool IsEmpty()
        {
            return head == null && tail == null;
        }
        public MyMapNode<K, V> Pop()
        {
            //temp assign to the first node
            MyMapNode<K, V> temp = head;
            if (head != null)
            {
                //moving head to next node and remove first node
                head = head.next;
            }
            return temp;
        }
        public MyMapNode<K, V> PopLast()
        {
            MyMapNode<K, V> tailTemp = tail;
            if (!IsEmpty())
            {
                //head is assigned as temp
                MyMapNode<K, V> temp = head;
                while (temp.next != null)
                {
                    //traversing the tail
                    temp = temp.next;
                }
                temp.next = null;
                tail = temp;
            }
            return tailTemp;
        }
        public bool DeleteNode(MyMapNode<K, V> DeleteNode)
        {
            MyMapNode<K, V> temp = head;
            if (!IsEmpty())
            {
                //if removing node is first
                if (DeleteNode.key.Equals(head.key))
                {
                    Pop();
                    return true;
                }
                //if removing node s last
                if (DeleteNode.key.Equals(tail.key))
                {
                    PopLast();
                    return true;
                }
                while (temp != null)
                {
                    //if removing node rahter than first or last
                    if (temp.next != null && temp.next.key.Equals(DeleteNode.key))
                    {
                        temp.next = DeleteNode.next;
                        return true;
                    }
                    temp = temp.next;
                }
            }
            return false;
        }
    }
}
