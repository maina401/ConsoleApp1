using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment;

namespace ConsoleApp1
{
    class Member : iMember
    {
        public class BinarySearchTree
        {

            public class Node
            {
                public iTool Data;
                public string title;
                public Node Left;
                public Node Right;
              
            }
            public Node root;
            public BinarySearchTree()
            {
                root = null;
            }
            public void Insert(iTool itool)
            {
                Node newNode = new Node();
                newNode.Data = itool;
                if (root == null)
                    root = newNode;
                else
                {
                    Node current = root;
                    Node parent;
                    while (true)
                    {
                        parent = current;
                        if (itool.Equals(current.Data))
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

            Node deleteRec(Node root, iTool tool)
            {

                // Base Case: If the tree is empty 
                if (root == null) return root;

                // Otherwise, recur down the tree 

                // Determine which branch should we continue to trace down.
                if (!tool.Equals(root.Data)){
                    root.Left = deleteRec(root.Left, tool); 
                }
                else if (!tool.Equals(root.Data))
                    root.Right = deleteRec(root.Right, tool);

                // if tool is same as root's tool, then This is the node   to be deleted  
                else
                {
                    // node with only one child or no child  
                    if (root.Left == null)
                        return root.Right;
                    else if (root.Right == null)
                        return root.Left;

                    // node with two children: Get the inorder successor (smallest in the Right subtree)

                    root.Data = minValue(root.Right);

                    // Delete the inorder successor  
                    root.Right = deleteRec(root.Right, root.Data);
                }
                return root;
            }
            iTool minValue(Node root)
            {
                iTool minv = root.Data;
                while (root.Left != null)
                {
                    minv = root.Left;
                    root = root.Left;
                }
                return minv;
            }

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string PIN { get; set; }

        string[] iMember.Tools => throw new NotImplementedException();

        public string[] Tools;

        public void addTool(iTool aTool)
        {
            BinarySearchTree tree = new BinarySearchTree()
                  ;
            tree.Insert(aTool);
            
        }

        public void deleteTool(iTool aTool)
        {
            throw new NotImplementedException();
        }
    }
}
