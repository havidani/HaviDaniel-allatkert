using System.Xml.Linq;

namespace _02282
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<object> items = new List<object>();
			List<string> nevek = new List<string>();
			List<int> sebesseg = new List<int>();
			Random random = new Random();

			Viziallatok v1 = new Viziallatok("cápa", 5);
			Hidegallatok h1 = new Hidegallatok("jegesmedve", 3);
			Mediallatok k1 = new Mediallatok("zerge", 7);
			Melegallatok m1 = new Melegallatok("gekkó", 1);
			Tropusiallatok t1 = new Tropusiallatok("zsiráf", 4);
            
			items.Add(v1);
			items.Add(h1);
			items.Add(k1);
			items.Add(m1);
			items.Add(t1);

			nevek.Add(v1.Nev);
			nevek.Add(h1.Nev);
			nevek.Add(k1.Nev);
			nevek.Add(m1.Nev);
			nevek.Add(t1.Nev);

			sebesseg.Add(v1.Sebesseg);
			sebesseg.Add(h1.Sebesseg);
			sebesseg.Add(k1.Sebesseg);
			sebesseg.Add(m1.Sebesseg);
			sebesseg.Add(t1.Sebesseg);


			int szamlalo = 0;

			for (int i = 0; i < items.Count; i++)
			{
				Console.WriteLine(items[i]);
				szamlalo++;
			}
			Console.WriteLine();
            Console.WriteLine($"Állatok: {szamlalo}");

            int randomszam = random.Next(5, 16);
            Console.WriteLine($"Férőhely: {randomszam}");

            Console.Write("__");
			for (int i = 0; i < randomszam; i++)
			{
				Console.Write("_");
			}

            Console.WriteLine();
            Console.Write("|");

			for (int i = 0; i < items.Count; i++)
			{
				if (items[i] != null)
				{
					Console.BackgroundColor = ConsoleColor.Green;
				}
				else
				{
					Console.BackgroundColor = ConsoleColor.Black;
				}
				Console.Write(" ");
			}
			Console.BackgroundColor = ConsoleColor.Black;
			Console.WriteLine("|");
			Console.Write("__");
			for (int i = 0; i < randomszam; i++)
			{
				Console.Write("_");
			}
            Console.WriteLine();
            Console.WriteLine();

            int maxLength = 0;
			foreach (var element in nevek)
			{
				if (element.Length > maxLength)
				{
					maxLength = element.Length;
				}
			}

			
			for (int i = 0; i < nevek.Count; i++)
			{
				
				Console.Write(nevek[i]);

				
				int spaces = maxLength + 2 - nevek[i].Length;

				Console.Write(new string(' ', spaces));

				Console.WriteLine("O");
			}


			//int[] haladas = new int[items.Count];

			//for (int i = 0; i < 8; i++)
			//{
			//	Thread.Sleep(2000);
			//	Console.Clear();

			//	for (int j = 0; j < items.Count; j++)
			//	{
			//		haladas[j] += sebesseg[i];
			//		Console.SetCursorPosition(haladas[j], j);
			//		Console.WriteLine($"{nevek[j]} O");
			//	}
			//}

		}

		static void Verseny()
		{
			Console.WriteLine("O\nO");
			int haladas = 0;
			int haladas2 = 0;
			for (int i = 0; i < 5; i++)
			{
				Thread.Sleep(1000);
				Console.Clear();
				Console.SetCursorPosition(haladas += 2, 0);
				Console.WriteLine("O");
				Console.SetCursorPosition(haladas2 += 3, 1);
				Console.WriteLine("O");

			}
		}

		static void Szazalek()
		{
			string[] szavak = new string[5];
			szavak[0] = "alma";
			szavak[1] = "béla";
			szavak[2] = "cecil";

			Console.WriteLine("_______");
			Console.Write("|");

			for (int i = 0; i < szavak.Length; i++)
			{
				if (szavak[i] != null)
				{
					Console.BackgroundColor = ConsoleColor.Green;
				}
				else
				{
					Console.BackgroundColor = ConsoleColor.Black;
				}
				Console.Write(" ");
			}
			Console.BackgroundColor = ConsoleColor.Black;
			Console.WriteLine("|");
			Console.WriteLine("_______");
		}
	}
}
