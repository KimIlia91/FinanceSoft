namespace SHA1String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Encoder.EncodeStringV2("Hello, World!");
            Console.WriteLine(result);
            var input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                result = Encoder.EncodeStringV2(input);
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}