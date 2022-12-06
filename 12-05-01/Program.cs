namespace _12_05_01;
class Program
{
    static void Main(string[] args)
    {
     Stack<string> stack1 = new Stack<string>(new[] {"C", "Z", "N", "B", "M", "W", "Q", "V"});
     Stack<string> stack2 = new Stack<string>(new[] {"H", "Z", "R", "W", "C", "B"});
     Stack<string> stack3 = new Stack<string>(new[] {"F", "Q", "R", "J"});
     Stack<string> stack4 = new Stack<string>(new[] {"Z", "S", "W", "H", "F", "N", "M", "T"});
     Stack<string> stack5 = new Stack<string>(new[] {"G", "F", "W", "L", "N", "Q", "P"});
     Stack<string> stack6= new Stack<string>(new[] {"L", "P", "W"});
     Stack<string> stack7 = new Stack<string>(new[] {"V", "B", "D", "R", "G", "C", "Q", "J"});
     Stack<string> stack8 = new Stack<string>(new[] {"Z", "Q", "N", "B", "W"});
     Stack<string> stack9 = new Stack<string>(new[] {"H", "L", "F", "C", "G", "T", "J"});
     List<Stack<string>> stacks = new List<Stack<string>>();
      stacks.Add(stack1);  stacks.Add(stack2); stacks.Add(stack3); stacks.Add(stack4); stacks.Add(stack5); stacks.Add(stack6); stacks.Add(stack7); stacks.Add(stack8); stacks.Add(stack9);
       string [] command;
       List<string> onCrane = new List<string>();

    string[] lines = File.ReadAllLines("C:\\AdventCode\\12-05-01\\Input5.txt");  
  
          foreach (string line in lines)  
          {

            command = line.Split(" ");
 
          for(int i = 0; i < int.Parse(command[1]); i++ )
          {
            
               onCrane.Add(stacks[int.Parse(command[3]) - 1].Pop());
               
          }


          for(int i = onCrane.Count(); i > 0; i--)
          {
            stacks[int.Parse(command[5]) - 1].Push(onCrane[i - 1]);
          }

             onCrane.Clear();
          }
         
          foreach(var item in stacks)
            {
                Console.WriteLine(item.Peek());
            }

    }
}


// [V]         [T]         [J]        
// [Q]         [M] [P]     [Q]     [J]
// [W] [B]     [N] [Q]     [C]     [T]
// [M] [C]     [F] [N]     [G] [W] [G]
// [B] [W] [J] [H] [L]     [R] [B] [C]
// [N] [R] [R] [W] [W] [W] [D] [N] [F]
// [Z] [Z] [Q] [S] [F] [P] [B] [Q] [L]
// [C] [H] [F] [Z] [G] [L] [V] [Z] [H]
//  1   2   3   4   5   6   7   8   9 