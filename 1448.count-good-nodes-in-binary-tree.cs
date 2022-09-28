using System;
using System.Xml.Xsl.Runtime;
/*
 * @lc app=leetcode id=1448 lang=csharp
 *
 * [1448] Count Good Nodes in Binary Tree
 */

// @lc code=start
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
    public int GoodNodes(TreeNode root) {
        int[] result = {0};
		List<int> ancestors = new List<int>();

		dfs(root, ancestors, result);
		return result[0];
    }

	public void dfs(TreeNode curNode, List<int> ancestors, int[] result)
	{
		if (curNode == null) return;

		bool good = true;		 
		foreach (int ancestor in ancestors)
		{
			if (ancestor > curNode.val)
			{
				good = false;
				break;
			}
		}

		if (good) {
			result[0] += 1;
		}
		ancestor.Add(curNode.val);
		dfs(curNode.left, ancestor, result);
		dfs(curNode.right, ancestor, result);
	}
}
// @lc code=end

