using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class InputParser
    {
        public bool ParseInput(string[] args, out List<int> parsedInput)
        {
            parsedInput = new List<int>();
            if (args == null || args.Length == 0)
            {                
                return false;
            }

            var listOfStrings = args[0].Split(",", StringSplitOptions.RemoveEmptyEntries);            
            foreach (var stringInput in listOfStrings)
            {
                int num;
                if (int.TryParse(stringInput, out num))
                {
                    if (num >= 0)
                    {
                        parsedInput.Add(num);                        
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            if (parsedInput.Count == 0)
            {
                return false;
            }
            return true;
        }
    }
}
