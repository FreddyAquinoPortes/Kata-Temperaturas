using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Temperaturas
{
    class Program
    {

        static void Main(string[] args)
        {
            string Escala1="c";
            string Escala2 = "k";
            Console.WriteLine("Ingrese la primer temperatura:");
            double temp1Value = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la escala de la primer temperatura (K, C, F):");
             Escala1=Console.ReadLine();
            Escala1 = Escala1.ToUpper();
            Temperature.TemperatureScale temp1Scale = (Temperature.TemperatureScale)Enum.Parse(typeof(Temperature.TemperatureScale), Escala1, true);
            
            Temperature temp1 = new Temperature(temp1Value, temp1Scale);
           
            Console.WriteLine("Ingrese la segunda temperatura:");
            double temp2Value = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la escala de la segunda temperatura (K, C, F):");
            Escala2 = Console.ReadLine();
            Escala2 = Escala2.ToUpper();

            
            Temperature.TemperatureScale temp2Scale = (Temperature.TemperatureScale)Enum.Parse(typeof(Temperature.TemperatureScale), Escala2, true);
         
            Temperature temp2 = new Temperature(temp2Value, temp2Scale);
            //Convertir Temperatura
            if (Escala1 != Escala2)
            {
                if (Escala1 == "C")
                {
                   temp2= temp2.ToCelsius();

                }
                if (Escala1 == "F")
                {
                   temp2= temp2.ToFahrenheit();
                }
                if (Escala1 == "K")
                {
                    temp2 = temp2.ToKelvin();
                }

            }

            Console.WriteLine("Ingrese la operación a realizar (+, -, *, /):");
            string operation = Console.ReadLine();
            Temperature result = null;
            switch (operation)
            {
                case "+":
                    result = temp1.Add(temp2);
                    break;
                case "-":
                    result = temp1.Subtract(temp2);
                    break;
                case "*":
                    result = temp1.MultiplyBy(temp2);
                    break;
                case "/":
                    result = temp1.DivideBy(temp2);
                    break;
                default:
                    Console.WriteLine("Operación no válida");
                    break;
            }
            if (result != null)
                Console.WriteLine("Resultado: " + result);
            Console.ReadLine();
        }

    }
}
