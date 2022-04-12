/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p == null && q == null) return true; // If both are null the tree is the same
        if (p == null || q == null) return false; // If only one is null the tree is not the same
        if (p != null && q != null && p.val != q.val) return false; // If p & q exist but p.val is not equal to q.val then return false
        
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right); // Recurse the tree with DFS
    }
}
