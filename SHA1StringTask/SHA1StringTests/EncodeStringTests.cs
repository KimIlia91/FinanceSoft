namespace SHA1StringTests
{
    public class EncodeStringTests
    {
        [Fact]
        public void EncodeString_WithOutSHA1_ReturnsCorrectResult()
        {
            // Arrange
            bool useSHA1 = false;
            string input = "hello world";
            string expected = "";
            foreach (char ch in input)
            {
                char s = ch;
                s++;
                expected += s;
            }

            string inputWirhNumber = "hello world123123123";
            string expectedWirhNumber = "";
            foreach (char ch in inputWirhNumber)
            {
                char s = ch;
                s++;
                expectedWirhNumber += s;
            }

            string inputSymbols = "hello world!@#$";
            string expecteSymbols = "";
            foreach (char ch in inputSymbols)
            {
                char s = ch;
                s++;
                expecteSymbols += s;
            }

            string inputWirhNumberAndSymbols = "hello world!@#$1456459890";
            string expecteWirhNumberAndSymbols = "";
            foreach (char ch in inputWirhNumberAndSymbols)
            {
                char s = ch;
                s++;
                expecteWirhNumberAndSymbols += s;
            }

            // Act
            string result = SHA1String.Encoder.EncodeString(input, useSHA1);
            string resultWirhNumber = SHA1String.Encoder.EncodeString(inputWirhNumber, useSHA1);
            string resultSymbols = SHA1String.Encoder.EncodeString(inputSymbols, useSHA1);
            string resultWirhNumberAndSymbols = SHA1String.Encoder.EncodeString(inputWirhNumberAndSymbols, useSHA1);

            // Assert
            Assert.Equal(expected, result);
            Assert.Equal(expectedWirhNumber, resultWirhNumber);
            Assert.Equal(expecteSymbols, resultSymbols);
            Assert.Equal(expecteWirhNumberAndSymbols, resultWirhNumberAndSymbols);
        }

        [Fact]
        public void EncodeString_WithSHA1_ReturnsCorrectResult()
        {
            // Arrange
            bool useSHA1 = true;
            string input = "hello world";
            var expected = "";
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                expected = Convert.ToBase64String(hash);
            }

            string inputWirhNumber = "hello world123436678";
            var expectedWirhNumber = "";
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(inputWirhNumber));
                expectedWirhNumber = Convert.ToBase64String(hash);
            }

            string inputSymbols = "hello world!@#$%^&*(";
            var expecteSymbols = "";
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(inputSymbols));
                expecteSymbols = Convert.ToBase64String(hash);
            }

            string inputWirhNumberAndSymbols = "hello world!@#$%^&*(";
            var expecteWirhNumberAndSymbols = "";
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(inputWirhNumberAndSymbols));
                expecteWirhNumberAndSymbols = Convert.ToBase64String(hash);
            }

            // Act
            var result = SHA1String.Encoder.EncodeString(input, useSHA1);
            var resultWirhNumber = SHA1String.Encoder.EncodeString(inputWirhNumber, useSHA1);
            var resultSymbols = SHA1String.Encoder.EncodeString(inputSymbols, useSHA1);
            var resultWirhNumberAndSymbols = SHA1String.Encoder.EncodeString(inputWirhNumberAndSymbols, useSHA1);

            // Assert
            Assert.Equal(expected, result);
            Assert.Equal(expectedWirhNumber, resultWirhNumber);
            Assert.Equal(expecteSymbols, resultSymbols);
            Assert.Equal(expecteWirhNumberAndSymbols, resultWirhNumberAndSymbols);
        }

        [Fact]
        public void EncodeString_WithEmptyString_ReturnsEmptyString()
        {
            // Arrange
            string input = "";
            bool useSHA1False = false;
            bool useSHA1True = true;

            // Act
            string resultSHA1False = SHA1String.Encoder.EncodeString(input, useSHA1False);
            string resultSHA1True = SHA1String.Encoder.EncodeString(input, useSHA1True);

            // Assert
            Assert.Empty(resultSHA1False);
            Assert.Empty(resultSHA1True);
        }

        [Fact]
        public void EncodeString_WithNullString_ThrowsArgumentNullException()
        {
            // Arrange
            string input = null;
            bool useSHA1False = false;
            bool useSHA1True = false;

            // Act
            string resultSHA1False = SHA1String.Encoder.EncodeString(input, useSHA1False);
            string resultSHA1True = SHA1String.Encoder.EncodeString(input, useSHA1True);

            // Assert
            Assert.Null(resultSHA1False);
            Assert.Null(resultSHA1True);
        }
    }
}