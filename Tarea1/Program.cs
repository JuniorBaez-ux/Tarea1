using System;

namespace Tarea1
{
    class Program
    {
        const double PI = 3.1416; 
        static void Main(string[] args)
        {
            int seleccion;
            Console.WriteLine("Seleccione el ejercicio que desea realizar: \n1-Capitulo 1 Ejercicio 1\n2-Capitulo 1 Ejercicio 5\n3-Capitulo 2 Ejercicio 1\n4-Capitulo 2 Ejercicio 3\n5-Capitulo 2 Ejercicio 4\n6-Capitulo 2 Ejercicio 5\n7-Capitulo 3 Ejercicio 1\n8-Capitulo 3 Ejercicio 4");
            seleccion = Convert.ToInt32(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    Cap1Ejercicio1();
                    break;

                case 2:
                    Cap1Ejercicio5();
                    break;

                case 3:
                    double lado;
                    double longitud;
                    Console.WriteLine("Inserte el numero de lados: ");
                    lado = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Inserte la longitud: ");
                    longitud = double.Parse(Console.ReadLine());
                    Cap2Ejercicio1(lado, longitud);
                    break;

                case 4:
                    double grados;
                    Console.WriteLine("Inserte la cantidad de grados a convertir a Radianes: ");
                    grados = Double.Parse(Console.ReadLine());
                    Cap2Ejercicio3(grados);
                    break;

                case 5:
                    double gradosC;
                    Console.WriteLine("Inserte la cantidad de grados Celsius que desea convertir a Farenheit: ");
                    gradosC = Double.Parse(Console.ReadLine());
                    Cap2Ejercicio4(gradosC);
                    break;

                case 6:
                    int eleccion;
                    Console.WriteLine("Que desea cambiar? \n1-Dolar\n2-Euro");
                    eleccion = Convert.ToInt32(Console.ReadLine());
                    if (eleccion == 1)
                    {
                        double dolar;
                        Console.WriteLine("Inserte la cantidad de dolares que desea cambiar a euros: ");
                        dolar = Double.Parse(Console.ReadLine());
                        Cap2Ejercicio5EURO(dolar);
                    }
                    else if (eleccion == 2)
                    {
                        double euro;
                        Console.WriteLine("Inserte la cantidad de euros que desea convertir a dolares: ");
                        euro = Double.Parse(Console.ReadLine());
                        Cap2Ejercicio5DOLAR(euro);
                    }
                    break;

                case 7:
                    int numero;
                    Console.WriteLine("Inserte el numero del cual desea comprobar si es par o impar");
                    numero = Convert.ToInt32(Console.ReadLine());
                    Cap3Ejercicio1(numero);
                    break;

                case 8:
                    int dia;
                    Console.WriteLine("Inserte el numero del dia de la semana que desea saber: ");
                    dia = Convert.ToInt32(Console.ReadLine());
                    Cap3Ejercicio4(dia);
                    break;

                default:
                    break;
            }
        }

        public static void Cap1Ejercicio1()
        {
            Console.WriteLine("Junior Emmanuel Baez Tavarez");
        }

        public static void Cap1Ejercicio5()
        {
            Console.WriteLine("Junior Emmanuel Baez Tavarez");
            Console.WriteLine("Es un duro");
            Console.WriteLine("Y come mangu.");
        }

        public static void Cap2Ejercicio1(double lado, double longitud)
        {
            double perimetro;
            perimetro = lado * longitud;

            Console.WriteLine("El perimetro es: " + perimetro);
        }

        public static void Cap2Ejercicio3(double grados)
        {
            double radianes;
            radianes = grados * PI / 180;

            Console.WriteLine("Su cantidad en radianes es: " + radianes);
        }

        public static void Cap2Ejercicio4(double gradosC)
        {
            double farenheit;
            farenheit = (gradosC * 9 / 5) + 32;

            Console.WriteLine("Su cantidad en Farenheit es: " + farenheit);
        }

        public static void Cap2Ejercicio5EURO(double dolar)
        {
            double euro;
            euro = dolar / 0.84;

            Console.WriteLine("Su cantidad en euro es: " + euro);
        }

        public static void Cap2Ejercicio5DOLAR(double euro)
        {
            double dolar;
            dolar = euro * 1.19;

            Console.WriteLine("Su cantidad en dolares es: " + dolar);
        }

        public static void Cap3Ejercicio1(int numero)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }

        public static void Cap3Ejercicio4(int dia)
        {
            if (dia == 1)
            {
                Console.WriteLine("Hoy es Domingo");
            }
            else if (dia == 2)
            {
                Console.WriteLine("Hoy es Lunes");
            }
            else if (dia == 3)
            {
                Console.WriteLine("Hoy es Martes");
            }
            else if (dia == 4)
            {
                Console.WriteLine("Hoy es Miercoles");
            }
            else if (dia == 5)
            {
                Console.WriteLine("Hoy es Jueves");
            }
            else if (dia == 6)
            {
                Console.WriteLine("Hoy es Viernes");
            }
            else if (dia == 7)
            {
                Console.WriteLine("Hoy es Sabado");
            }
            else
            {
                Console.WriteLine("Dia no valido...");
            }
        }
    }
}
