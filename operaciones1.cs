using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculadora
{




	class suma
	{

		static void Suma(){
			int n1, n2, r;
			Console.WriteLine("Ingrese el primer numero: ");
			n1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el segundo numero: ");
			n2 = int.Parse(Console.ReadLine());
			r = n1+ n2;
			Console.WriteLine("El resultados es: " + r);
			Console.ReadLine();
		}

		static void resta(){
			int n1, n2, r;
			Console.WriteLine("Ingrese el primer número: ");
			n1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el segundo número: ");
			n2 = int.Parse(Console.ReadLine());
			r = n1 - n2;
			Console.WriteLine("El resultados es: " + r);
			Console.ReadLine();
		}

		static void multiplicacion(){
			int n1, n2, r;
			Console.WriteLine("Ingrese el primer número: ");
			n1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el segundo número: ");
			n2 = int.Parse(Console.ReadLine());
			r = n1 * n2;
			Console.WriteLine("El resultados es: " + r);
			Console.ReadLine();
		}

		static void division(){
			int n1, n2, r;
			Console.WriteLine("Ingrese el primer número: ");
			n1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el segundo número: ");
			n2 = int.Parse(Console.ReadLine());
			r = n1 / n2;
			Console.WriteLine("El resultados es: " + r);
			Console.ReadLine();
		}

		static void AreaCuadrado(){
			int bas,altura,resultado ;
			Console.WriteLine("Ingrese la base : ");
			bas = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese la altura : ");
			altura = int.Parse(Console.ReadLine());
			resultado=bas * altura ;
			Console.WriteLine("el area es:"+resultado);

		}

		static void AreaTriangulo(){
			int bas, altura, resultado ;
			Console.WriteLine("Ingrese la base : ");
			bas = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese la altura : ");
			altura = int.Parse(Console.ReadLine());
			resultado=(bas * altura) / 2 ;
			Console.WriteLine("el area es:"+resultado);

		}
		static void AreaCirculo(){
			double  radio, resultado ;
			Console.WriteLine("Ingrese la radio : ");
			radio = double.Parse(Console.ReadLine());

			resultado= (radio*2)*3.1416;
			Console.WriteLine("el area es:"+resultado);

		}

		static void Main(string[] args)
		{ 
			int opc;

			do{
				Console.WriteLine("1-suma\n 2-resta\n 3-multiplicacion\n 4-division\n5-area cuadrado\n6-area triangulo\n7-area circulo\n8-salir\n");
				opc = int.Parse(Console.ReadLine());
				switch(opc){

				case 1: Suma();
					break;
				case 2: resta();
					break;
				case 3: multiplicacion();
					break;
				case 4: division();
					break;
				case 5:AreaCuadrado();
					break;
				case 6: AreaTriangulo();
					break;
				case 7: AreaCirculo();
					break;

				}

			}while(opc<8);
		}

	}
}