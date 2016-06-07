using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._2
{
    class TreeNode
    {
        private int value;
        private TreeNode left;
        private TreeNode right;
        public TreeNode parent;
        private int size = 0;

        public int getValue() { return this.value; }

        public TreeNode getLeft(){ return this.left; }
        public void setLeft(TreeNode left) { 
            this.left = left;
            if (left != null)
                left.parent = this;
        }

        public TreeNode getRight() { return this.right; }
        public void setRight(TreeNode right) { 
            this.right = right;
            if (right != null)
                right.parent = this;
        }

        public TreeNode(int value) {
            this.value = value;
            left = right = null;
            size = 1;
        }

        public int getSize() {
            return this.size;
        }

        public static TreeNode CreateMinimalBST(int[] array)
        {
            return CreateMinimalBST(array, 0, array.Length - 1);
        }

        private static TreeNode CreateMinimalBST(int[] array, int start, int end) {
            if (end < start)
                return null;

            int mid = (start + end) / 2;
            TreeNode root = new TreeNode(array[mid]);
            root.setLeft(CreateMinimalBST(array, start, mid-1));
            root.setRight(CreateMinimalBST(array, mid+1, end));

            return root;
        }

    }
}
