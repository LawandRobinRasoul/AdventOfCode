         int countIndex = 1;
         int indexMaxCalories = 1;
         int MaxCalories = 0;
         int Calories = 0;

        string[] lines = File.ReadAllLines("C:\\AdventCode\\12-01-1\\calories.txt");


        foreach (string line in lines)
        {

            if (line == "")
            {
                if(Calories >= MaxCalories)
                {
                    MaxCalories =  Calories;
                    indexMaxCalories = countIndex;
                    
                }
                
                countIndex ++;
                Calories = 0;
            }
            else
            {
                Calories += int.Parse(line);
            }

        }


        Console.WriteLine("Elf {0} is carrying the most calories: {1} calories", indexMaxCalories, MaxCalories );