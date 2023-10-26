using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace nepesseg
{
    class Orszag
    {
        public string Orszagnev { get; private set; }
        public int Terulet { get; private set; }
        public int Nepesseg { get; private set; }
        public string Fovaros { get; private set; }
        public int FovarosNepesseg { get; private set; }

        public int Nepsuruseg => (int)Math.Round(Nepesseg / (double)Terulet);

        public bool Koncetralt => FovarosNepesseg * 1000 > Nepesseg * .3;

        public Orszag(string s)
        {
            string[] v = s.Split(';');
            this.Orszagnev = v[0];
            this.Terulet = int.Parse(v[1]);
            this.Nepesseg = int.Parse(v[2].Replace("g", "0000"));
            this.Fovaros = v[3];
            this.FovarosNepesseg = int.Parse(v[4]);
        }

        public override string ToString()
        {
            return "";
        }

    }
}