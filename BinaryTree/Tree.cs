using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    public class Tree
    {
        public Tree(int num)
        {
            Value = num;
        }
        public Tree()
        {
            
        }

        public void Insert(int num)
        {
            if(num <= Value)
            {
                if(LeftNode == null)
                {
                    LeftNode = new Tree(num);
                }
                else
                {
                    LeftNode.Insert(num);
                }
            }
            else
            {
                if (RightNode == null)
                {
                    RightNode = new Tree(num);
                }
                else
                {
                    RightNode.Insert(num);
                }
            }
        }

        public IEnumerable<int> WalkTree()
        {
            if(LeftNode != null)
            {
                foreach(var value in LeftNode.WalkTree())
                {
                    yield return value;
                }
            }
            
            if(RightNode != null)
            {
                foreach (var value in RightNode.WalkTree())
                {
                    yield return value;
                }
            }

            yield return Value;
        }

        public int Value { get; set; }

        public Tree? LeftNode { get; set; }
        public Tree? RightNode { get; set; }
    }
}
