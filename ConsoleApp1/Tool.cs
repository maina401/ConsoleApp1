using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment;


namespace ConsoleApp1
{


    public class Tool : iTool
    {
        public class BinarySearchTree
        {

            public class Node
            {
                public Tool Data;
                public Node Left;
                public Node Right;
            }
            public Node root;
            public BinarySearchTree()
            {
                root = null;
            }
            public void Insert(Tool tool)
            {
                Node newNode = new Node();
                newNode.Data = tool;
                if (root == null)
                    root = newNode;
                else
                {
                    Node current = root;
                    Node parent;
                    while (true)
                    {
                        parent = current;
                        if (tool.Equals(current.Data))
                        {
                            current = current.Left;
                            if (current == null)
                            { 
                                parent.Left = newNode;
                                break;
                            }

                            else
                            {
                                current = current.Right;
                                if (current == null)
                                {
                                    parent.Right = newNode;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

        }

            string iTool.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int iTool.Quantity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int iTool.AvailableQuantity { get ; set ; }
        int iTool.NoBorrowings { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        iMemberCollection iTool.GetBorrowers => throw new NotImplementedException();

        void iTool.addBorrower(iMember aMember)
        {
            Tool.BinarySearchTree.Node root = new BinarySearchTree.Node();
            
        }

        void iTool.deleteBorrower(iMember aMember)
        {
            throw new NotImplementedException();
        }

        string iTool.ToString()
        {

            return "";
        }
    }
}
