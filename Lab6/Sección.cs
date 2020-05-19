using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    [Serializable()]
    public class Sección : División
    {

        List<Bloque> divisiones = new List<Bloque>();


        public Sección(string Name) : base(Name)
        {

        }
    }
}
