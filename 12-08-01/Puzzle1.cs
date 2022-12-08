using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _12_08_01
{
    public class Puzzle1
    {
        //  List<int[]> allTrees = new List<int[]>();
        // List<int> left = new List<int>();
        // List<int> right = new List<int>();
        // List<int> up = new List<int>();
        // List<int> down = new List<int>();
        // int visibleTrees = 0;
        // bool isVisibleRow = true;

        // string[] lines = File.ReadAllLines("C:\\AdventCode\\12-08-01\\input8.txt");

        // foreach (string line in lines)
        // {
        //     int[] array = new int[line.Count()];

        //     for (int i = 0; i < line.Count(); i++)
        //     {
        //         array[i] = int.Parse(line[i].ToString());
        //     }

        //     allTrees.Add(array);


        // }

        // for(int i = 1; i < allTrees.Count() - 1; i++ )
        // {
        //    for(int x = 1; x < allTrees[0].Count() - 1; x++ )
        //    {
            
        //     for(int rowCount = 0; rowCount < allTrees[i].Count(); rowCount++)
        //     {
        //         if(rowCount < x)
        //         {
        //            left.Add(allTrees[i][rowCount]);
        //         }
        //         else if(rowCount > x)
        //         {
        //             right.Add(allTrees[i][rowCount]);
        //         }
        //     }

        //     for(int colCount = 0; colCount < allTrees.Count(); colCount++)
        //     {
        //         if(colCount < i)
        //         {
        //            up.Add(allTrees[colCount][x]);
        //         }
        //         else if(colCount > i)
        //         {
        //             down.Add(allTrees[colCount][x]);
        //         }
        //     }

        //     if(left.Any(a => a >= allTrees[i][x]) && right.Any(a => a >= allTrees[i][x]) && up.Any(a => a >= allTrees[i][x]) && down.Any(a => a >= allTrees[i][x]))
        //     {
        //        isVisibleRow = false;
        //     }
        //     else
        //     {
        //         visibleTrees ++;
        //     }
        //     left.Clear();
        //     right.Clear();
        //     up.Clear();
        //     down.Clear();
        //    }
        // }

        // int outerTrees = ((allTrees.Count()) * 4) - 4;

        // Console.WriteLine(visibleTrees + outerTrees);
    }
}