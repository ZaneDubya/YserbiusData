using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapReader {
    internal class Tile {
        public byte[] Data = new byte[13];
        public Tile() {}

        public override string ToString() => $"{Data[0]:X2} {Data[1]:X2} {Data[2]:X2} {Data[3]:X2} {Data[4]:X2} {Data[5]:X2} {Data[6]:X2} {Data[7]:X2} {Data[8]:X2} {Data[9]:X2} {Data[10]:X2} {Data[11]:X2} {Data[12]:X2}";
    }
}
