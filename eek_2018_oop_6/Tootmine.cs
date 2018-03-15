using System;
using System.Collections;
using System.Collections.Generic;

namespace eek_2018_oop_6
{
    class Tootmine
    {
        public Hashtable tooted = new Hashtable();

        public Toode this[string nimi]
        {
            get { return (Toode) tooted[nimi]; }
            set { tooted[nimi] = value; }
        }
    }
}
