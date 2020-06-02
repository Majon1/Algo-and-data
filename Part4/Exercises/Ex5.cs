using System;

namespace Part4
{
    public class BinarySearchTree
    {
        int count = 0;
        Node root = null;
        public void Add(int x)
        {
            if ((root == null) || (root.value == x))
            {
                return;
            }
            else if (x < root.value)
            {
                //left
                if (root.previous != null)
                {
                    Add(root.value);
                }
                else{
                    root.previous = this;
                }
            }
            else if (x > root.value)
            {
                //right
                if (root.next != null)
                {

                }
                else{
                    root.next = this;
                }
            }
           
        }
        public int Height()
        {
            return count;
        }
    }
}