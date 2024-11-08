namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Convert.ToInt32(Console.ReadLine());
            var result = false;
            for (var i = 3; i <= number; i *= 3)
            {
                if (i == number)
                {
                    result = true;
                }
            }
            Console.WriteLine("Son 3 ning darajasimi: " + result);
        }
    }
}
