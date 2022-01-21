using System;
using System.Collections.Generic;
using System.Text;

namespace sepathu_enum
{
    class Sepatu
    {
        public Gaya Style
        {
            get; private set;
        }

        public string Warna
        {
            get; private set;
        }

        public Sepatu (Gaya gaya, string warna)
        {
            this.Style = gaya;
            this.Warna = warna;
        }

        public string Gambaran
        {

            get {return $"A {this.Warna} {this.Style}"; }
        }
    }
}
