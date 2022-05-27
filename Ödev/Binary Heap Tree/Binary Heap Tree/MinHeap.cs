using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Heap_Tree
{
    public class MinHeap
    {
        public int[] heapArray { get; set; }
        public int capacity { get; set; }
        public int current_heap_size { get; set; }
        public MinHeap(int n)
        {
            capacity = n;
            heapArray = new int[capacity];
            current_heap_size = 0;
        }
        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        public int Parent(int key)
        {
            return (key - 1) / 2;
        }
        public int Left(int key)
        {
            return 2 * key + 1;
        }
        public int Right(int key)
        {
            return 2 * key + 2;
        }
        public bool insertKey(int key)
        {
            if (current_heap_size == capacity)
            {

                // heap is full
                return false;
            }

            // First insert the new key at the end 
            int i = current_heap_size;
            heapArray[i] = key;
            current_heap_size++;

            // Fix the min heap property if it is violated 
            while (i != 0 && heapArray[i] <
                             heapArray[Parent(i)])
            {
                Swap(ref heapArray[i],
                     ref heapArray[Parent(i)]);
                i = Parent(i);
            }
            return true;
        }
        public void decreaseKey(int key, int new_val)
        {
            heapArray[key] = new_val;

            while (key != 0 && heapArray[key] <
                               heapArray[Parent(key)])
            {
                Swap(ref heapArray[key],
                     ref heapArray[Parent(key)]);
                key = Parent(key);
            }
        }
        public int getMin()
        {
            return heapArray[0];
        }
        public int extractMin()
        {
            if (current_heap_size <= 0)
            {
                return int.MaxValue;
            }

            if (current_heap_size == 1)
            {
                current_heap_size--;
                return heapArray[0];
            }

            // Store the minimum value, 
            // and remove it from heap 
            int root = heapArray[0];

            heapArray[0] = heapArray[current_heap_size - 1];
            current_heap_size--;
            MinHeapify(0);

            return root;
        }
        public void deleteKey(int key)
        {
            decreaseKey(key, int.MinValue);
            extractMin();
        }
        public void MinHeapify(int key)
        {
            int l = Left(key);
            int r = Right(key);

            int smallest = key;
            if (l < current_heap_size &&
                heapArray[l] < heapArray[smallest])
            {
                smallest = l;
            }
            if (r < current_heap_size &&
                heapArray[r] < heapArray[smallest])
            {
                smallest = r;
            }

            if (smallest != key)
            {
                Swap(ref heapArray[key],
                     ref heapArray[smallest]);
                MinHeapify(smallest);
            }
        }
        public void increaseKey(int key, int new_val)
        {
            heapArray[key] = new_val;
            MinHeapify(key);
        }
        public void changeValueOnAKey(int key, int new_val)
        {
            if (heapArray[key] == new_val)
            {
                return;
            }
            if (heapArray[key] < new_val)
            {
                increaseKey(key, new_val);
            }
            else
            {
                decreaseKey(key, new_val);
            }
        }
    }
}
