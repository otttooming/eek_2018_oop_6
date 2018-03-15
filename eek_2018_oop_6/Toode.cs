using System;
namespace eek_2018_oop_6
{
    class Toode
    {
        public string nimi { get; set; }
        public double hind { get; set; }

        public Toode(string nimi="---", double hind = 0)
        {
            this.nimi = nimi;
            this.hind = hind;
        }

        public override string ToString()
        {
            return nimi + "   " + hind.ToString();
        }
    }
}
