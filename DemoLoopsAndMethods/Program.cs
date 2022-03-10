namespace loopsMethodsDemo
{
    class Demo
    {
        static void Main()
        {
            // TODO: implement method to check if a number is in range of another number
        }
        // access modifier - static (no not) -return type-name(parms in here)
        private static bool IsWithinRange(int num, int target, int range)
        {
            return (num - target) <= range;
        }
    }
}