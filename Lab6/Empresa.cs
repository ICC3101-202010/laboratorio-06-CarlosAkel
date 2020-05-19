using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Lab6
{
    [Serializable()]
    public class Empresa
    {
        private string Name { get; set; }
        private int Rut { get; set; }

        List<División> divisiones = new List<División>();
        List<Persona> persona = new List<Persona>();
        List<Persona> personal = new List<Persona>();
        //List<string> div = { Area, Departamento, Sección, Bloque };




        public Empresa(string Name,int Rut)
        {
            this.Name = Name;
            this.Rut = Rut;
        }
        public void add_division(División div)
        {
            divisiones.Add(div);
        }
        public static void serializar(Empresa empresa)
        {
            //Empresa empresa = new Empresa(Nombre, Rut);

            Console.WriteLine("Por favor ahora ingrese los nombres de las siguientes divisiones con sus encargados");
            Console.WriteLine("Departamento");
            string Departamento = Console.ReadLine();
            Console.WriteLine("Encargado del Departamento:");
            Console.WriteLine("Nombre");
            string Nombre_Encargado_Departamento = Console.ReadLine();
            Console.WriteLine("Apellido");
            string Apellido_Encargado_Departamento = Console.ReadLine();
            int Rut_Encargado_Departamento = 0;
            while (Rut_Encargado_Departamento == 0)
            {
                Console.WriteLine("ingrese rut");
                int.TryParse(Console.ReadLine(), out Rut_Encargado_Departamento);
            }
            Console.WriteLine("Sección ");
            string Seccion = Console.ReadLine();
            Console.WriteLine("Encargado de la Sección");
            Console.WriteLine("Nombre");
            string Nombre_Encargado_Seccion = Console.ReadLine();
            Console.WriteLine("Apellido");
            string Apellido_Encargado_Seccion = Console.ReadLine();
            int Rut_Encargado_Seccion = 0;
            while (Rut_Encargado_Seccion == 0)
            {
                Console.WriteLine("ingrese rut");
                int.TryParse(Console.ReadLine(), out Rut_Encargado_Seccion);
            }
            Console.WriteLine("Bloque 1");
            string Bloque1 = Console.ReadLine();
            Console.WriteLine("Encargado del Bloque 1:");
            Console.WriteLine("Nombre");
            string Nombre_Encargado_Bloque1 = Console.ReadLine();
            Console.WriteLine("Apellido");
            string Apellido_Encargado_Bloque1 = Console.ReadLine();
            int Rut_Encargado_Bloque1 = 0;
            while (Rut_Encargado_Bloque1 == 0)
            {
                Console.WriteLine("ingrese rut");
                int.TryParse(Console.ReadLine(), out Rut_Encargado_Bloque1);
            }
            Console.WriteLine("personal del bloque1 numero 1");
            Console.WriteLine("Nombre");
            string Nombre_Personal1_Bloque1 = Console.ReadLine();
            Console.WriteLine("Apellido");
            string Apellido_Personal1_Bloque1 = Console.ReadLine();
            int Rut_Personal1_Bloque1 = 0;
            while (Rut_Personal1_Bloque1 == 0)
            {
                Console.WriteLine("ingrese rut");
                int.TryParse(Console.ReadLine(), out Rut_Personal1_Bloque1);
            }
            Console.WriteLine("personal del bloque1 numero 2");
            Console.WriteLine("Nombre");
            string Nombre_Personal2_Bloque1 = Console.ReadLine();
            Console.WriteLine("Apellido");
            string Apellido_Personal2_Bloque1 = Console.ReadLine();
            int Rut_Personal2_Bloque1 = 0;
            while (Rut_Personal2_Bloque1 == 0)
            {
                Console.WriteLine("ingrese rut");
                int.TryParse(Console.ReadLine(), out Rut_Personal2_Bloque1);
            }
            Console.WriteLine("Bloque 2");
            string Bloque2 = Console.ReadLine();
            Console.WriteLine("Encargado del Bloque 2:");
            Console.WriteLine("Nombre");
            string Nombre_Encargado_Bloque2 = Console.ReadLine();
            Console.WriteLine("Apellido");
            string Apellido_Encargado_Bloque2 = Console.ReadLine();
            int Rut_Encargado_Bloque2 = 0;
            while (Rut_Encargado_Bloque2 == 0)
            {
                Console.WriteLine("ingrese rut");
                int.TryParse(Console.ReadLine(), out Rut_Encargado_Bloque2);
            }

            Console.WriteLine("personal del bloque2 numero 1");
            Console.WriteLine("Nombre");
            string Nombre_Personal1_Bloque2 = Console.ReadLine();
            Console.WriteLine("Apellido");
            string Apellido_Personal1_Bloque2 = Console.ReadLine();
            int Rut_Personal1_Bloque2 = 0;
            while (Rut_Personal1_Bloque2 == 0)
            {
                Console.WriteLine("ingrese rut");
                int.TryParse(Console.ReadLine(), out Rut_Personal1_Bloque2);
            }

            Console.WriteLine("personal del bloque2 numero 2");
            Console.WriteLine("Nombre");
            string Nombre_Personal2_Bloque2 = Console.ReadLine();
            Console.WriteLine("Apellido");
            string Apellido_Personal2_Bloque2 = Console.ReadLine();
            int Rut_Personal2_Bloque2 = 0;
            while (Rut_Personal2_Bloque2 == 0)
            {
                Console.WriteLine("ingrese rut");
                int.TryParse(Console.ReadLine(), out Rut_Personal2_Bloque2);
            }

            Departamento departamento = new Departamento(Departamento);
            Persona departamento_persona = new Persona(Nombre_Encargado_Departamento, Apellido_Encargado_Departamento, Rut_Encargado_Departamento, "Encargado del Departamento");
            empresa.add_division(departamento);
            empresa.persona.Add(departamento_persona);
            Sección seccion = new Sección(Seccion);
            Persona seccion_persona = new Persona(Nombre_Encargado_Seccion, Apellido_Encargado_Seccion, Rut_Encargado_Seccion, "Encargado del Departamento");
            empresa.add_division(seccion);
            empresa.persona.Add(seccion_persona);

            Bloque bloque1 = new Bloque(Bloque1);
            Persona bloque1_persona = new Persona(Nombre_Encargado_Bloque1, Apellido_Encargado_Bloque1, Rut_Encargado_Bloque1, "Encargado del Bloque 1");
            Persona bloque1_persona_personal1 = new Persona(Nombre_Personal1_Bloque1, Apellido_Personal1_Bloque1, Rut_Personal1_Bloque1, "Personal bloque1");
            Persona bloque1_persona_personal2 = new Persona(Nombre_Personal2_Bloque1, Apellido_Personal2_Bloque1, Rut_Personal2_Bloque1, "Personal bloque1");
            empresa.add_division(bloque1);
            empresa.persona.Add(bloque1_persona);
            empresa.personal.Add(bloque1_persona_personal1);
            empresa.personal.Add(bloque1_persona_personal2);



            Bloque bloque2 = new Bloque(Bloque2);
            Persona bloque2_persona = new Persona(Nombre_Encargado_Bloque2, Apellido_Encargado_Bloque2, Rut_Encargado_Bloque2, "Encargado del Bloque 2");
            Persona bloque2_persona_personal1 = new Persona(Nombre_Personal1_Bloque2, Apellido_Personal1_Bloque2, Rut_Personal1_Bloque2, "Personal bloque2");
            Persona bloque2_persona_personal2 = new Persona(Nombre_Personal2_Bloque2, Apellido_Personal2_Bloque2, Rut_Personal2_Bloque2, "Personal bloque2");
            empresa.add_division(bloque2);
            empresa.persona.Add(bloque2_persona);
            empresa.personal.Add(bloque2_persona_personal1);
            empresa.personal.Add(bloque2_persona_personal2);



            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, empresa);
            stream.Close();
        }

        public static void deserializar()
        {
            IFormatter formatter2 = new BinaryFormatter();
            
            try
            {
                Stream stream2 = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                Empresa obj = (Empresa)formatter2.Deserialize(stream2);
                Console.WriteLine("Empresa " + obj.Name);
                int a = 0;
                for (int i = 0; i < obj.divisiones.Count; i++)
                {
                    if(obj.divisiones[i].GetType() == typeof(Bloque))
                    {
                        Console.WriteLine(obj.divisiones[i].get_name());
                        Console.WriteLine(obj.persona[i].get_position() +" "+ obj.persona[i].get_name());
                        Console.WriteLine("Personal : " + obj.personal[a].get_name());
                        Console.WriteLine("Personal : " + obj.personal[a+1].get_name());
                        a += 2;


                    }
                    else
                    {
                        Console.WriteLine(obj.divisiones[i].get_name());
                        Console.WriteLine(obj.persona[i].get_position() + " " + obj.persona[i].get_name());
                    }

                    

                }
                stream2.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("No existen datos de la empresa por favor ingreselos");
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


        }
        public void agregar_div(División div)
        {
            divisiones.Add(div);
        }

    }
}
