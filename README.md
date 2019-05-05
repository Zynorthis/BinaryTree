# BinaryTree

A binary search tree algorithm which allows users to add nodes to the tree and search for existing nodes.

## Classes and Functionality
The binary search tree class has two member methods, one for adding nodes to the tree, and another for searching the tree for existing nodes with a givening value. Both methods contain a time complextity of BigO(n). The tree also hold member variables for a root node and a reference node. the root node is used as a base line to begin adding and searching, and a reference node which is used a reference and consistantly changed in the add and search methods.

The node class is a generic class that holds generic member variables for the represented data and two other node classes. In the binary tree class, the add and search methods are tailored for intergers but can be modified to compare any data because of this. The node also hold an interger value that represents the level in the tree that that it sits in.

## Additional Notes

This project was created as a proof of concept to show the capabilities of a binary search algorithm, with this in mind, I believe there is still room for improvement in cutting down on the time complexity to be a linear add and search. As mentioned above, the binary tree was tailored to handle intergers but could be changed to compare any datatype.
