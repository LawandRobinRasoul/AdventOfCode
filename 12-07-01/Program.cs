namespace _12_07_01;
class Program
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("C:\\AdventCode\\12-07-01\\input7.txt");
        Dictionary<string, long> dict = new Dictionary<string, long>();
        int indexer = 0;
        string[] command;
        string fullPath = "";
        string parentPath = "";
        List<string> path = new List<string>();

        foreach (string line in lines)
        {
            command = line.Split(" ");

            if (command[0] == "$")
            {
                if (command[1] == "cd")
                {
                    if (command[2] == "..")
                    {
                        indexer = indexer - 1;
                        path.RemoveAt(path.Count - 1);

                    }
                    else if (command[2] == "/")
                    {
                        indexer = 0;
                        path.Clear();
                    }
                    else
                    {
                        fullPath = "";
                        parentPath = "";
                        path.Add(command[2] + "/");
                        indexer = indexer + 1;

                        foreach (var item in path)
                        {
                            fullPath = fullPath + item;

                        }
                        dict.Add(fullPath, 0);
                    }
                }
            }
            else if (command[0] != "dir")
            {

                parentPath = "";
                dict[fullPath] = dict[fullPath] + long.Parse(command[0]);
                for (int i = 0; i < path.Count - 1; i++)
                {
                    parentPath = parentPath + path[i];
                    dict[parentPath] = dict[parentPath] + long.Parse(command[0]);

                }
                // Console.WriteLine(fullPath);
            }
        }

        long answer = 0;

        foreach (var item in dict.Values)
        {
            if (item < 100000)
            {
                answer += item;
            }
        }

        Console.WriteLine(answer);
        
        long spaceNeeded = 30000000 - (70000000 - dict["C/"]);
        long closest = 0;

        dict = dict.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        foreach (var item in dict)
        {
          if(closest < spaceNeeded && item.Value > closest)
          {
               closest = item.Value;
          }

        }
        Console.WriteLine(closest);
    }

    // answer < 1955982
}