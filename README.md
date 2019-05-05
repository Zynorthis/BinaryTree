# Binary Search Tree

A binary search tree algorithm which allows users to add nodes to the tree and search for existing nodes.

## Classes and Functionality
The binary search tree class has two member methods, one for adding nodes to the tree, and another for searching the tree for existing nodes with a given value. Both methods contain a time complextity of BigO(n). The tree also holds member variables for a root node and a reference node. The root node is used as a base line to begin adding and searching, while the reference node is used as a reference and is consistantly changed in the add and search methods.

The node class is a generic class that holds generic member variables, one for the represented data, and two for the other node classes. In the binary tree class, the add and search methods are tailored for intergers but can be modified to compare any data because they are generic. The node also holds an interger value that represents the level in the tree that it sits in.

## Additional Notes

This project was created as a proof of concept to show the capabilities of a binary search algorithm. With this in mind, I believe there is still room for improvement in cutting down on the time complexity to be a linear add and search. As mentioned above, the binary tree was tailored to handle intergers but can be changed to compare any datatype.
