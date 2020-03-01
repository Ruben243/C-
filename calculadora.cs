using System;

namespace prueba1
{
    class calculadora
    {
        static void Main(string[] args)
        {

            String opcion = " "; //Declaro el string de control
            int num1 = 0;//primer numero entero
            int num2 = 0;//segundo numero entero
            int resul = 0;//variable para el resultado
            Console.WriteLine("Bienvenido a la calculadora en c#");//doy la bienvenida
            Console.WriteLine("Escriba una opcion");//pido el primer numero
            Console.WriteLine("1-Suma\n2-Resta\n3-Multiplicacion\n4-Division\n5-Exit");//muestro las opciones
            opcion = Console.ReadLine();//Leo el string que introduce el usuario

            while (opcion != "Exit")//inicio el bucle con la salida
            {
                //switch con la variable de control 
                switch (opcion)
                {
                    case "Suma"://si escribe Suma se ejecuta este codigo
                        Console.WriteLine("Introduce el primer numero");//pido el primer numero
                        num1 = Convert.ToInt32(Console.ReadLine());//Leo el string que introduce el usuario y lo convierto a int
                        Console.WriteLine("Introduce el segundo numero");//pido el segundo numero
                        num2 = Convert.ToInt32(Console.ReadLine());//Leo el string que introduce el usuario y lo convierto a int
                        resul = num1 + num2;//realizo la operacion y la asigno a la variable resultado
                        Console.WriteLine("El resultado de la suma es {0}", resul);//muestro el resultado

                        break;

                    case "Resta":
                        Console.WriteLine("Introduce el primer numero");//pido el primer numero
                        num1 = Convert.ToInt32(Console.ReadLine());//Leo el string que introduce el usuario y lo convierto a int
                        Console.WriteLine("Introduce el segundo numero");//pido el segundo numero
                        num2 = Convert.ToInt32(Console.ReadLine());//Leo el string que introduce el usuario y lo convierto a int
                        if (num1 > num2)//controlo si el numero 1 es mayor que el numero2
                        {
                            resul = num1 - num2;//asigno la operacion a la variable result

                        }
                        else if (num2 > num1)//controlo si el numero 2 es mayor que numero 1
                        {
                            resul = num2 - num1;//asigno la operacion a la variable result


                        }
                        else
                        {
                            resul = num2 - num1;//asigno la operacion a la variable result

                        }
                        Console.WriteLine("El resultado de la resta es {0}", resul);//muestro por pantalla el resultado

                        break;

                    case "Multiplicacion":
                        Console.WriteLine("Introduce el primer numero");//pido el primer numero
                        num1 = Convert.ToInt32(Console.ReadLine());//Leo el string que introduce el usuario y lo convierto a int
                        Console.WriteLine("Introduce el segundo numero");//pido el segundo numero
                        num2 = Convert.ToInt32(Console.ReadLine());//Leo el string que introduce el usuario y lo convierto a int
                        resul = num1 * num2;//asigno la operacion a la variable

                        Console.WriteLine("El resultado de la multiplicacion es {0}\n", resul);//muestro el resultado por pantalla
                        break;

                    case "Division":
                        Console.WriteLine("Introduce el primer numero");//pido el primer numero
                        num1 = Convert.ToInt32(Console.ReadLine());//Leo el string que introduce el usuario y lo convierto a int
                        Console.WriteLine("Introduce el segundo numero");//pido el segundo numero
                        num2 = Convert.ToInt32(Console.ReadLine());//Leo el string que introduce el usuario y lo convierto a int
                        if (num1 == 0 || num2 == 0)//controlo que ninguno de los numeros sean cero
                        {
                            Console.WriteLine("ERROR el numero no puede ser cero");//muestro el error
                            break;
                        }
                        else if (num2 > num1)//controlo el mayor numero de los dos
                        {
                            resul = num2 / num1;//asigno la operacion a la variable result

                        }
                        else if (num1 > num2)//controlo el mayor numero de los dos
                        {
                            resul = num1 / num2;//asigno la operacion a la variable result
                        }

                        Console.WriteLine("El resultado de la division es {0}\n", resul);//muestro el resultado por pantalla


                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta");//muestro la opcion por defecto si no se ejecuta ninguna de las anteriores

                        break;

                }


                Console.WriteLine("1-Suma\n2-Resta\n3-Multiplicacion\n4-Division\n5-Exit");//vuelvo a pedir la opcion para operar y/o salir
                opcion = Console.ReadLine();//leo la opcion





            }



            Console.WriteLine("Fin del programa");//muestro que el programa se acabo


        }
    }
}
