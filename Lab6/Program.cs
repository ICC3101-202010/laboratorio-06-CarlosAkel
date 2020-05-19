using System;
using System.Threading;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Quiere utilizar un archivo para cargar la informcación de la empresa?(si/no)");
            string answ = Console.ReadLine();
            if (answ == "no" || answ == "NO")
            {
                Console.WriteLine("Se ha seleccionado que no, por favor ingrese los siguientes datos ");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Nombre de la Empresa");
                string Nombre = Console.ReadLine();
                int Rut = 0;
                while (Rut == 0)
                {
                    Console.WriteLine("Rut de la Empresa");
                    int.TryParse(Console.ReadLine(), out Rut);
                }
                Empresa empresa = new Empresa(Nombre, Rut);
                Empresa.serializar(empresa);
               
                
            }
            else if(answ == "si" || answ == "SI")
            {
                Console.WriteLine("ingresando archivo");
                Thread.Sleep(2000);
                Console.Clear();
                Empresa.deserializar();
                


            }

            
        }
    }
}
