using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tkey,Tval>
    {
        Tkey[] plakalar;
        Tval[] iller;
        public MyDictionary()
        {
            plakalar = new Tkey[0];
            iller = new Tval[0];
        }
        public void Add(Tkey plaka ,Tval il )
        {
            Tkey[] tmpplaka = plakalar;
            Tval[] tmpil = iller;
            plakalar = new Tkey[plakalar.Length + 1];
            iller = new Tval[iller.Length + 1];

            for (int i = 0; i < tmpplaka.Length; i++)
            {
                plakalar[i] = tmpplaka[i];
                iller[i] = tmpil[i];
            }
            plakalar[plakalar.Length - 1] = plaka;
            iller[iller.Length - 1] = il;
        }

        public Tkey[] Plakalar
        {
            get { return plakalar; }
        }
        public Tval[] Iller
        {
            get { return iller; }
        }
        public int Length
        {
            get { return iller.Length; }
        }
    }
}
