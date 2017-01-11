/*Write Code to Determine if Two Trees are Identical
Two trees are identical when they have same data and arrangement of data is also same.

To identify if two trees are identical, we need to traverse both trees simultaneously, 
and while traversing we need to compare data and children of the trees.*/

/*Algorithm:
sameTree(tree1, tree2)
1. If both trees are empty then return 1.
2. Else If both trees are non -empty
     (a) Check data of the root nodes (tree1->data ==  tree2->data)
     (b) Check left subtrees recursively  i.e., call sameTree( 
          tree1->left_subtree, tree2->left_subtree)
     (c) Check right subtrees recursively  i.e., call sameTree( 
          tree1->right_subtree, tree2->right_subtree)
     (d) If a,b and c are true then return 1.
3  Else return 0 (one is empty and other is not)*/

// Java program to see if two trees are identical
  
// A binary tree node
class Node 
{
    int data;
    Node left, right;
  
    Node(int item) 
    {
        data = item;
        left = right = null;
    }
}
  
class BinaryTree 
{
    Node root1, root2;
  
    /* Given two trees, return true if they are
       structurally identical */
    boolean identicalTrees(Node a, Node b) 
    {
        /*1. both empty */
        if (a == null && b == null)
            return true;
             
        /* 2. both non-empty -> compare them */
        if (a != null && b != null) 
            return (a.data == b.data
                    && identicalTrees(a.left, b.left)
                    && identicalTrees(a.right, b.right));
  
        /* 3. one empty, one not -> false */
        return false;
    }
  
    /* Driver program to test identicalTrees() function */
    public static void main(String[] args) 
    {
        BinaryTree tree = new BinaryTree();
  
        tree.root1 = new Node(1);
        tree.root1.left = new Node(2);
        tree.root1.right = new Node(3);
        tree.root1.left.left = new Node(4);
        tree.root1.left.right = new Node(5);
  
        tree.root2 = new Node(1);
        tree.root2.left = new Node(2);
        tree.root2.right = new Node(3);
        tree.root2.left.left = new Node(4);
        tree.root2.left.right = new Node(5);
  
        if (tree.identicalTrees(tree.root1, tree.root2))
            System.out.println("Both trees are identical");
        else
            System.out.println("Trees are not identical");
  
    }
}

/*Time Complexity:
Complexity of the identicalTree() will be according to the tree with lesser number of nodes. 
Let number of nodes in two trees be m and n then complexity of sameTree() is O(m) where m < n.*/