using BinaryTree.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BinaryTree.Tests
{
    [TestClass]
    public class InputParserTests
    {
        IInputParser _inputParser;

        public InputParserTests()
        {
            var serviceProvider = new ServiceCollection()
               .AddSingleton<IInputParser, InputParser>()
               .BuildServiceProvider();

            _inputParser = serviceProvider.GetService<IInputParser>();
        }

        [TestMethod]
        public void CorrectInput_Validates()
        {            
            var input = new string[] { "4, 12, 10, 18, 24, 22, 15" };
            bool expected = true;
                        
            List<int> validatedInput;
            var actual = _inputParser.ParseInput(input, out validatedInput);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectInput_BuildsCorrectArray()
        {
            var input = new string[] { "4, 12, 10, 18, 24, 22, 15" };
            var expected = new int[] { 4, 12, 10, 18, 24, 22, 15 };
                        
            List<int> actual;
            _inputParser.ParseInput(input, out actual);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NonNumber_FailsValidation()
        {
            var input = new string[] { "R, 12, 10, 18, 24, 22, 15" };
            bool expected = false;
                        
            List<int> validatedInput;
            bool actual = _inputParser.ParseInput(input, out validatedInput);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NegativeNumber_FailsValidation()
        {
            var input = new string[] { "-4, 12, 10, 18, 24, 22, 15" };
            bool expected = false;
                        
            List<int> validatedInput;
            bool actual = _inputParser.ParseInput(input, out validatedInput);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EmptyArgs_FailsValidation()
        {
            var input = new string[] {  };
            bool expected = false;

            List<int> validatedInput;
            bool actual = _inputParser.ParseInput(input, out validatedInput);

            Assert.AreEqual(expected, actual);
        }
    }
}