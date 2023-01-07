namespace BinaryTree.Tests
{
    [TestClass]
    public class InputParserTests
    {
        [TestMethod]
        public void CorrectInput_Validates()
        {            
            var input = new string[] { "4, 12, 10, 18, 24, 22, 15" };
            bool expected = true;
            
            var inputValidator = new InputParser();
            List<int> validatedInput;
            var actual = inputValidator.ParseInput(input, out validatedInput);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectInput_BuildsCorrectArray()
        {
            var input = new string[] { "4, 12, 10, 18, 24, 22, 15" };
            var expected = new int[] { 4, 12, 10, 18, 24, 22, 15 };

            var inputValidator = new InputParser();
            List<int> actual;
            inputValidator.ParseInput(input, out actual);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NonNumber_FailsValidation()
        {
            var input = new string[] { "R, 12, 10, 18, 24, 22, 15" };
            bool expected = false;

            var inputValidator = new InputParser();
            List<int> validatedInput;
            var actual = inputValidator.ParseInput(input, out validatedInput);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NegativeNumber_FailsValidation()
        {
            var input = new string[] { "-4, 12, 10, 18, 24, 22, 15" };
            bool expected = false;

            var inputValidator = new InputParser();
            List<int> validatedInput;
            var actual = inputValidator.ParseInput(input, out validatedInput);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EmptyArgs_FailsValidation()
        {
            var input = new string[] {  };
            bool expected = false;

            var inputValidator = new InputParser();
            List<int> validatedInput;
            var actual = inputValidator.ParseInput(input, out validatedInput);

            Assert.AreEqual(expected, actual);
        }
    }
}