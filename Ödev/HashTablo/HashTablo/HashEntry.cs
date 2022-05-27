using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablo
{
    public class HashEntry
    {
        public int Anahtar { get; set; }
        public object Deger { get; set; }
        public HashEntry(int key,object value )
        {
            Anahtar = key;
            Deger = value;
        }
    }
}
