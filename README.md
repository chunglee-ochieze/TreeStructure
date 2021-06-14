# TreeStructure

This is a simple Binary Tree Structure console app implementation in .NET5.

Run console app and specify the intended depth of the tree.

Application constructs the tree, however, it randomly alternates the positioning of the next value in the next node, either using a normal traversal, or a reversed normal traversal.

While forming the binary tree, a zero value is passed to one of the leaf nodes.

Thereafter, the label of the zero valued leaf node is predicted.

To validate the prediction, a zero value search is run on the tree, to confirm the prediction.