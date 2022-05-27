using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Heap_Tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaxHeap h = new MaxHeap(10);
            h.Add(1);
            h.Add(2);
            h.Add(15);
            h.Add(5);
            int[] Heap = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Heap[0] = h.Pop();
            }
            HeapSort hs = new HeapSort(Heap);
            Heap = hs.Sort();
            string heap = "";
            for (int i = 0; i < 4; i++)
            {
                heap += " " + Heap[0].ToString();
            }
            MessageBox.Show(heap);
        }
    }
}
