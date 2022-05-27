using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class LinkedHashMap<K, V> where K : IComparable
    {
        public readonly int NumBuckets;
        readonly List<LinkedList<K, V>> BucketList;
        public LinkedHashMap(int NumBuckets)
        {
            //linkedlist added to array location
            //Numbuckets is Array size
            this.NumBuckets = NumBuckets;
            BucketList = new List<LinkedList<K, V>>(NumBuckets);

            for (int i = 0; i < this.NumBuckets; i++)
                BucketList.Add(null);
        }
        public V Get(K key)
        {
            //check value of particular key(word)
            int index = GetBucketIndex(key);
            //check particular linkedlist at array position
            LinkedList<K, V> linkedList = BucketList[index];
            if (linkedList == null)
                return default;
            //check particular key mymapnode in linkedlist at array position
            MyMapNode<K, V> myMapNode = linkedList.Search(key);
            return (myMapNode == null) ? default : myMapNode.value;
        }
        public int GetBucketIndex(K key)
        {
            //reutrn the absolute value because hashcode contain negative value sometime
            int hashcode = Math.Abs(key.GetHashCode());
            //to get the hashcode within range
            int index = hashcode % NumBuckets;
            return index;
        }
        public void Add(K key, V value)
        {
            //adding the particular value and key at linked list
            int index = this.GetBucketIndex(key);
            LinkedList<K, V> linkedList = BucketList[index];
            //check linkedlist is null or not
            if (linkedList == null)
            {
                linkedList = new LinkedList<K, V>();
                BucketList[index] = linkedList;
            }
            //check mymapnode is present or not if not then create new, else add value in previous mymapnode
            MyMapNode<K, V> myMapNode = linkedList.Search(key);
            if (myMapNode == null)
            {
                myMapNode = new MyMapNode<K, V>(key, value);
                linkedList.Append(myMapNode);
            }
            else myMapNode.value = value;
        }
        public void Remove(K key)
        {
            int index = GetBucketIndex(key);
            LinkedList<K, V> myLinkedList = BucketList[index];

            if (myLinkedList != null)
            {
                MyMapNode<K, V> myMapNode = myLinkedList.Search(key);
                if (myMapNode != null)
                {
                    myLinkedList.DeleteNode(myMapNode);
                }
            }
        }
    }
}
