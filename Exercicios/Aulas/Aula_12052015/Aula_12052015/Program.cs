using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_12052015
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var heigth = int.Parse(Console.ReadLine());

            Console.WriteLine("----------");

            int badTiles = 0;
            int[] badTilesPerColumn = new int[width];
            int[] badTilesPerRow = new int[heigth];

            for (int y = 0; y < heigth; y++)
            {
                var cursorTop = Console.CursorTop;
                for (int x = 0; x < width; x++)
                {
                    Console.CursorLeft = x * 2;
                    Console.CursorTop = cursorTop;
                    var condition = int.Parse(Console.ReadLine());
                    if(condition == 1)
                    {
                        badTiles++;
                        badTilesPerColumn[x]++;
                        badTilesPerRow[y]++;
                    }
                }
            }

           
            Console.WriteLine();
            Console.WriteLine("{0} azulejos quebrados ao total", badTiles);

            for (int i = 0; i < badTilesPerRow.Length; i++)
            {
                Console.WriteLine("Linha {0}: {1} azulejos quebrados.", i, badTilesPerRow[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < badTilesPerColumn.Length; i++)
            {
                Console.WriteLine("Coluna {0}: {1} azulejos quebrados.", i, badTilesPerColumn[i]);
            }
        }
    }
}
