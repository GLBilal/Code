namespace loopsMethodsDemo
{
    class Demo
    {
        static void Main()
        {
            // TODO: implement method to check if a number is in range of another number
            // TODO: ask the user for target
            //Console.WriteLine("Please enter a initial number");
            //int startingNum = int.Parse(Console.ReadLine());

            // TODO: ask the user for rage
           // Console.WriteLine("Please enter a target number");
            //int targetNum = int.Parse(Console.ReadLine());

            // TODO: Wwrite the result by calling IsWithInRange
            //Console.WriteLine("Please enter a range");
           // int range = int.Parse(Console.ReadLine());
            // TODO: Print an 
           // string results = IsWithInRange(startingNum, targetNum, range) ? "Its within range." : "Its not within range";

            Console.Write("do we have power y/n: ");
            bool hasPower = Console.ReadLine() == "y";

            Console.Write("do we have paper y/n: ");
            bool hasPaper = Console.ReadLine() == "y";

            Console.Write("what is the ink level: ");
            int inkLevel = int.Parse(Console.ReadLine());

            PrintDoc(hasPower, hasPaper, inkLevel);

            // Console.WriteLine($"Given a string number of: {startingNum} and a target number: {targetNum}. It's {results}");
        }

        // access modifier - static (no not) -return type-name(parms in here)
       // private static bool IsWithInRange(int num, int target, int range)
       // {
          //  return (num - target) <= - range && (num -target) >= range;
        //}

        //TODO: Print a document hasPower, hasPaper and ink level >= 10.

        private static void PrintDoc(bool haspower, bool hasPaper, int inkLevel)
        { 
            Console.WriteLine( hasPaper && haspower && inkLevel >= 10 ? "Printing..." : "Unable to print");
        }   

    }
}