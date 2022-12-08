namespace _12_08_01;
class Program
{
    //Fyfan hur kan jag göra detta bättre?
    static void Main(string[] args)
    {
        List<int[]> allTrees = new List<int[]>();
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        List<int> up = new List<int>();
        List<int> down = new List<int>();
        int visibleTrees = 0;
        bool isVisibleRow = true;
        int MaxScore = 0;
        

        string[] lines = File.ReadAllLines("C:\\AdventCode\\12-08-01\\input8.txt");

        foreach (string line in lines)
        {
            int[] array = new int[line.Count()];

            for (int i = 0; i < line.Count(); i++)
            {
                array[i] = int.Parse(line[i].ToString());
            }

            allTrees.Add(array);


        }

        for(int i = 1; i < allTrees.Count() - 1; i++ )
        {
           for(int x = 1; x < allTrees[0].Count() - 1; x++ )
           {
            
            for(int rowCount = 0; rowCount < allTrees[i].Count(); rowCount++)
            {
                if(rowCount < x)
                {
                   left.Add(allTrees[i][rowCount]);
                }
                else if(rowCount > x)
                {
                    right.Add(allTrees[i][rowCount]);
                }
            }

            for(int colCount = 0; colCount < allTrees.Count(); colCount++)
            {
                if(colCount < i)
                {
                   up.Add(allTrees[colCount][x]);
                }
                else if(colCount > i)
                {
                    down.Add(allTrees[colCount][x]);
                }
            }

            int numberup = up.FindLastIndex(a => a >= allTrees[i][x]);
            int numberleft = left.FindLastIndex(a => a >= allTrees[i][x]);

            int numberdown = down.FindIndex(a => a >= allTrees[i][x]);
            int numberright = right.FindIndex(a => a >= allTrees[i][x]);
            
           
           
            if(numberup == -1)
            {
                numberup = up.Count();
            }
            else
            {
               numberup =  (up.Count()) - (numberup);
            }

            if(numberleft == -1)
            {
                numberleft = left.Count();
            }
            else
            {
              numberleft =  (left.Count()) - (numberleft);
            }

            if(numberdown == -1)
            {
                numberdown = down.Count();
            }
            else
            {
                numberdown += 1;
            }
            if(numberright == -1)
            {
                numberright = right.Count();
            }
            else
            {
                 numberright += 1;
            }
          
            int score = (numberup * numberleft * numberdown * numberright);

            if(MaxScore < score)
            {
                MaxScore = score;
            }


            left.Clear();
            right.Clear();
            up.Clear();
            down.Clear();
           }
        }


        Console.WriteLine(MaxScore);

    }
}
