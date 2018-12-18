using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cons_Kassenbon_c_sharp
{
	class Program
	{
		static void Main(string[] args)
		{
		string eingabe;
		int anzahl;
		string[] artikel;
		double[] preis;
		int[] menge;

		Console.WriteLine("Wie viele Artikel sollen erfasst werden=");
		eingabe = Console.ReadLine();
			if (int.TryParse(eingabe, out anzahl))
			{
				// Artikel
				artikel = new string [anzahl]; //aufruf des Konstruktors für den Array vom Typ Objekt.
				preis = new double[anzahl];
				menge = new int[anzahl];

				for (int i = 0; i < anzahl; i++)
				{
					Console.WriteLine("Bitte Artikel eingeben:");
					artikel[i] = Console.ReadLine();
					Console.WriteLine();
					Console.WriteLine("Bitte Preis eingeben:");
					eingabe = Console.ReadLine();
					if (!double.TryParse(eingabe, out preis[i]))
					{
						Console.WriteLine("Falscher Preis!");
						preis[i] = 0.0;
					}
					Console.WriteLine("Bitte Menge eingeben:");
					eingabe = Console.ReadLine();
					if (!int.TryParse(eingabe, out menge[i]))
					{
						Console.WriteLine("Falscher Preis!");
						menge[i] = 0;
					}
					Console.WriteLine();
				}
				//

				//Ausgabe

				Console.WriteLine("**************************************************************************");
				Console.WriteLine("++++++++++++++++++++++++++++++++KASSENBON+++++++++++++++++++++++++++++++++");
				for (int i = 0; i < anzahl; i++)
				{
					Console.WriteLine("Artikel: " + artikel[i]+ "    " + "Preis: " +
					preis[i] +",-  " + "  Menge: "+ menge[i] +"St.   " + "   Pos Gesamt: " +
					positionspreis(menge[i], preis[i]));
				}
				Console.WriteLine("**************************************************************************");
			}
			else
			{
				Console.WriteLine("Eingabe Fehlerhaft! Bitte wiederholen!");
			}
		Console.ReadKey();

		}

		static double positionspreis(int menge, double preis)
		{
			return menge * preis;
		}
	}
}
