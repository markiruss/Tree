using BinaryTree.Interfaces;

namespace BinaryTree
{
    public class Node
    {
        public Node(int num)
        {
            Value = num;
        }
        
        public Node()
        {
            
        }

        public void Insert(int num)
        {
            if(num <= Value)
            {
                if(LeftNode == null)
                {
                    LeftNode = new Node(num);
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
                    RightNode = new Node(num);
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

        public Node? LeftNode { get; set; }
        public Node? RightNode { get; set; }
    }
}
