# Read-me
nested cycles




using System;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
			int x = 0;

			int xtwo = 9;

			int xthree = -1;
			int space = 10;

			int spacetwo = 0;
			int xfour = 10;


			for (int i = 0; i < 10; i++)      //first triangle
			{
				Console.Write("#");
				for (int f = 0; f < x; f++)
				{
					Console.Write("#");
				}
				Console.WriteLine("");
				x++;
			}

			Console.WriteLine("");
			Console.WriteLine("");

			for (int i = 0; i < 10; i++)   // second triangle
			{
				Console.Write("#");
				for (int g = 0; g < xtwo; g++)
				{
					Console.Write("#");
				}
				Console.WriteLine("");
				xtwo--;
			}

			Console.WriteLine("");
	

			for (int i = 0; i < 12; i++)  // third triangle
			{

				for (int p = 0; p < xthree; p++)
				{
					Console.Write("#");
					
				}
				Console.WriteLine("");
				for (int z = 0; z < space; z++)
				{
					Console.Write(" ");
				}
				space--;
				xthree++;
			}

			Console.WriteLine("");
			Console.WriteLine("");


			for (int i = 0; i < 11; i++)  //fourth triangle
			{
				Console.Write("");
				for (int p = 0; p < xfour; p++)
				{
					Console.Write("#");
				}
				Console.WriteLine("");
				for (int z = 0; z < spacetwo; z++)
				{
					Console.Write(" ");
				}
				Console.Write(" ");
				spacetwo++;
				xfour--;
			}


		}
    }
    
}

