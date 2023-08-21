using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
          //Declaracion de variables 

          //Declaracion de variables de tipo texto con captura desde consola

          string? universidad="";

          //Declarar variables de tipo texto con asignacion desde codigo 

          string facultad = "Ingenieria y Arquitectura";
          string profesion = "Tecnico en Desarrollo de Sofware";

         //Declaracion de variables entera captura desde consola 

         int anioIngreso=0;

         //Declaracion de variables enteras asignando valores
         int edadIngreso= 19;
         int edadEgreso= 21;

         //Declaracion de variables double asignando desde consola

         double coutaUniversidad=0.0;

         //Declaracion de variable decimales asignando valores 
         double gastoTransporte=35.50;

         ///CAPTURA DE DATOS DESDE CONSOLA 
         Console.WriteLine("\n***********************************************");
         Console.WriteLine("\n-------Capturando datos de tipo de texto ------");
         Console.WriteLine("Ingrese el nombre de la Universidad donde estudia >> ");
         universidad=Convert.ToString(Console.ReadLine());
         Console.WriteLine("\n---------Fin de captura de tipo texto -------\n");

         Console.WriteLine("\n----------Capturando datos de tipo enteros-------\n");
         Console.WriteLine("Ingrese el año que inicio la carrera >> ");
         anioIngreso=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("\n----------Fin de captura de tipo enteros------\n");

         Console.WriteLine("\n--------Capturando datos de tipo decimal-------\n");
         Console.WriteLine("Ingrese la cuota de la Universidad >> ");
         coutaUniversidad=Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("\n-------------Fin de captura de tipo decimal--------");
         Console.WriteLine("*****************************************************\n");

         //IMPRESION DE DATOS EN CONSOLA
         Console.WriteLine("******************************************\n\n");
         Console.WriteLine("\n-------IMPRESION DE DATOS DE TIPO DE TEXTO---------");
         Console.WriteLine("\n La Universidad en la que estudia es >> "+ universidad);
         Console.WriteLine("\n Pertenece a la facultad de >> "+ facultad);
         Console.WriteLine("\n Estudiando la carrera de >> "+ profesion);
         Console.WriteLine("\n*******************************************************\n");

         Console.WriteLine("*************************************************\n\n");
         Console.WriteLine("\n-------IMPRESION DE DATOS DE ENTERO---------");
         Console.WriteLine("\n El año que ingreso a la universidad fue >> "+ anioIngreso);
         Console.WriteLine("\n La edad cuando inicio sus estudios es >> "+ edadIngreso + " años");
         Console.WriteLine("\n La edad cuando finalice sus estudios sera >> "+ edadEgreso + " años");
         Console.WriteLine("\n*******************************************************\n");
         
         Console.WriteLine("*************************************************\n\n");
         Console.WriteLine("\n-------IMPRESION DE DATOS DE DOUBLE------");
         Console.WriteLine("\n La cuota de su universidad es >> "+ "$"+ coutaUniversidad);
         Console.WriteLine("\n Su gasto en transporte es >> "+ "$"+ gastoTransporte);
         Console.WriteLine("\n*******************************************************\n");

         Console.ReadKey();



        }
    }
}
