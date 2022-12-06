namespace _12_06_01;
class Program
{
    static void Main(string[] args)
    {
        string text = File.ReadAllText("C:\\AdventCode\\12-06-01\\Input6.txt");
        int start_of_packet = 0;
        for (int i = 0; i < text.Length - 13; i++)
        {
            string four = text.Substring(i,14);
            
            if (four.Distinct().Count() == four.Count())
            {
                start_of_packet = i + 14;
                Console.WriteLine(start_of_packet);
            }
           
            

        }

    }
}
