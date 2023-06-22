class Program
{
    static void Result(int prOne, int vrOne, int prTwo, int vrTwo)
    {
        int jump = 0;
        int lowPosition = prOne;
        int lowVelocity = vrOne;
        int highPosition = prTwo;
        int highVelocity = vrTwo;

        if (prOne > prTwo)
        {
            lowPosition = prTwo;
            lowVelocity = prTwo;
            highPosition = prOne;
            highVelocity = prOne;
        }

        if (lowVelocity <= highVelocity) 
        {
            Console.WriteLine("Result => No");
        }
        else 
        {
            while (lowPosition != highPosition)
            {
                lowPosition += lowVelocity;
                highPosition += highVelocity;
                jump++;
            }

            Console.WriteLine("Result => Yes (after " + $"{jump}" + " jump )");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("posisi rabbit 1 : ");
        int pRabbitOne = int.Parse(Console.ReadLine()!);
        Console.WriteLine("velocity rabbit 1 : ");
        int vRabbitOne = int.Parse(Console.ReadLine()!);
        Console.WriteLine("posisi rabbit 2 : ");
        int pRabbitTwo = int.Parse(Console.ReadLine()!);
        Console.WriteLine("velocity rabbit 2 : ");
        int vRabbitTwo = int.Parse(Console.ReadLine()!);

        Console.WriteLine("\nresult :");
        Result(pRabbitOne,vRabbitOne,pRabbitTwo,vRabbitTwo);
    }
}