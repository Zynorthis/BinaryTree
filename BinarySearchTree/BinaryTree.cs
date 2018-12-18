using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        private int height;
        private Node<int> rootNode = new Node<int>();
        private Node<int> referenceNode = new Node<int>();
        private bool rootNodeSet;
        private bool newNodeSet;

        public void Add()
        {
            Console.Write("Enter in your node interger: ");
            string userInput = Console.ReadLine();
            string result = UserInputValidation(userInput);
            newNodeSet = false;
            if (result == "Fail")
            {
                Add();
            }
            else if (result == "Pass")
            {
                int parsedUserInput = Int32.Parse(userInput);
                if (rootNodeSet == false)
                {
                    rootNode.Data = parsedUserInput;
                    rootNodeSet = true;
                }
                else if (rootNode.left == null && rootNode.right == null)
                {
                    var node = new Node<int>() { Data = parsedUserInput };
                    if (node.Data <= rootNode.Data)
                    {
                        rootNode.left = node;
                        height++;
                    }
                    else if (node.Data > rootNode.Data)
                    {
                        rootNode.right = node;
                        height++;
                    }
                    else
                    {
                        string error = "Error setting node: node data out of bounds.";
                        ErrorMessage(error);
                    }
                }
                else
                {
                    referenceNode = rootNode;
                    var node = new Node<int>() { Data = parsedUserInput };
                    while (newNodeSet == false)
                    {
                        if (node.Data <= referenceNode.Data && referenceNode.left == null)
                        {
                            referenceNode.left = node;
                            node.Level = (referenceNode.Level + 1);
                            height++;
                            newNodeSet = true;
                        }
                        else if (node.Data > referenceNode.Data && referenceNode.right == null)
                        {
                            referenceNode.right = node;
                            node.Level = (referenceNode.Level + 1);
                            height++;
                            newNodeSet = true;
                        }
                        else if (referenceNode.Data >= node.Data)
                        {
                            referenceNode = referenceNode.left;
                        }
                        else if (referenceNode.Data < node.Data)
                        {
                            referenceNode = referenceNode.right;
                        }
                        else
                        {
                            string error = "Error setting node: node data out of bounds.";
                            ErrorMessage(error);
                        }
                    }
                }
            }
            else
            {
                string error = "Validation Error: User input somehow did not pass or fail parse check???";
                ErrorMessage(error);
                Add();
            }
        }

        public void Search()
        {
            bool endResult = false;
            Console.WriteLine("What number would you like to search for?");
            string userInput = Console.ReadLine();
            string result = UserInputValidation(userInput);
            if (result == "Fail")
            {
                Search();
            }
            else if (result == "Pass")
            {
                int parsedUserInput = Int32.Parse(userInput);
                if (rootNode.Data == parsedUserInput)
                {
                    endResult = true;
                }
                else
                {
                    referenceNode = rootNode;
                    bool loopKiller = false;
                    while (loopKiller == false)
                    {
                        if (parsedUserInput <= referenceNode.Data)
                        {
                            if (referenceNode.left == null)
                            {
                                loopKiller = true;
                            }
                            else if (parsedUserInput == referenceNode.left.Data)
                            {
                                endResult = true;
                                loopKiller = true;
                            }
                            else
                            {
                                referenceNode = referenceNode.left;
                            }
                        }
                        else if (parsedUserInput > referenceNode.Data)
                        {
                            if (referenceNode.right == null)
                            {
                                loopKiller = true;
                            }
                            else if (parsedUserInput == referenceNode.right.Data)
                            {
                                endResult = true;
                                loopKiller = true;
                            }
                            else
                            {
                                referenceNode = referenceNode.right;
                            }
                        }
                    }
                }
                if (endResult == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your number was found in the set!");
                    Console.ResetColor();
                    Console.ReadKey();
                }
                else if (endResult == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your number was not found in the set.");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
            else
            {
                string error = "Validation Error: User input somehow did not pass or fail parse check???";
                ErrorMessage(error);
                Search();
            }
        }

        private string UserInputValidation(string userInput)
        {
            try
            {
                int testedUserInput = int.Parse(userInput);
                string result = "Pass";
                return result;
            }
            catch
            {
                string errorMessage = "Input Error: Could not convert user input into Int32.";
                ErrorMessage(errorMessage);
                string result = "Fail";
                return result;
            }
        }

        private void ErrorMessage(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
