class Program
{
    static void Result(int input)
    {
        for(int i = 1; i <= input; i++)
        {
            if(i % 2 == 0 & i % 3 == 0)
            {
                Console.WriteLine("TwoThree");
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine("Two");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Three");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("input number : ");
        int input = int.Parse(Console.ReadLine()!);

        Console.WriteLine("\nresult :");
        Result(input);
    }
}