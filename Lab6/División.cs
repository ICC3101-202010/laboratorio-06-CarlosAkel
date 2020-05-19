using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab6
{
    [Serializable()]
    public class División
    {
        protected string Name { get; set; }




        public División(string Name)
        {
            this.Name = Name;
        }

        public string get_name()
        {
            return Name;
        }






    }
}
