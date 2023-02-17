namespace ReverseString
{
    public class Reverse
    {
        //Немного лучше показатель по Benchmark
        public string ReverseStrUseWhile(string input)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                return input;
            var inputToСharArray = input.ToCharArray();
            var start = 0;
            var end = inputToСharArray.Length - 1;
            while (start < end)
            {
                var temp = inputToСharArray[start];
                inputToСharArray[start++] = inputToСharArray[end];
                inputToСharArray[end--] = temp;
            }
            return new string(inputToСharArray);
        }

        //Незначительно уступает по тестам Benchmark
        public string ReverseStrUseFor(string input)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                return input;
            var inputToСharArray = input.ToCharArray();
            var end = inputToСharArray.Length - 1;
            for (var start = 0; start < inputToСharArray.Length / 2; start++)
            {
                var temp = inputToСharArray[start];
                inputToСharArray[start] = inputToСharArray[end];
                inputToСharArray[end] = temp;
                end--;
            }
            return new string(inputToСharArray);
        }
    }
}
