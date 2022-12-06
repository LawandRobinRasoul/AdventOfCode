  List<int> CaloriesList = new List<int>();
        int Calories = 0;

        string[] lines = File.ReadAllLines("C:\\AdventCode\\12-01-1\\calories.txt");

        foreach (string line in lines)
        {

            if (line == "")
            {
              CaloriesList.Add(Calories);
              Calories = 0;
            }
            else
            {
                 Calories += int.Parse(line);
            }


        }
          
        var SortedCaloriesList = CaloriesList.OrderByDescending(ob => ob).ToList();


        Console.WriteLine(SortedCaloriesList[0] + SortedCaloriesList[1] + SortedCaloriesList[2]);