
using System;
using Lists;

namespace Trees
{
    public class TreeNode<T>
    {
        private T Value;
        //TODO #1: Declare a member variable called "Children" as a list of TreeNode<T> objects
       List<TreeNode<T>> Children;

        public TreeNode(T value)
        {
            //TODO #2: Initialize member variables/attributes
            //Value = value;
            Children = new List<TreeNode<T>>();

            }

        public string ToString(int depth, int index)
        {
            //TODO #3: Uncomment the code below

            string output = null;
            string leftSpace = null;
            for (int i = 0; i < depth; i++) leftSpace += " ";
            if (leftSpace != null) leftSpace += "->";

            output += $"{leftSpace}[{Value}]\n";

            for (int childIndex = 0; childIndex < Children.Count(); childIndex++)
            {
                TreeNode<T> child = Children.Get(childIndex);
                output += child.ToString(depth + 1, childIndex);
            }
            return output;

            //return null; 
        }

        public TreeNode<T> Add(T value)
        {
            //TODO #4: Add a new instance of class TreeNode<T> with Value=value. Return the instance we just created
            TreeNode<T> Value = new TreeNode<T>(value);
            return Value;
            
        }

        public int Count()
        {
            //TODO #5: Return the total number of elements in this tree
            int total = 0;
            foreach (TreeNode<T> value in Children)
            {
                while (value != null)
                {
                    total++;
                }
            }
            return total;
            
        }

        public int Height()
        {
            //TODO #6: Return the height of this tree
            if (Children.Count() == 0)
            {
                return 1;
            }
            int maxHeight = 0;
            foreach (TreeNode<T> child in Children)
            {
                int childH = child.Height();
                if (childH > maxHeight)
                {
                    maxHeight = childH;
                }
            }
            return maxHeight + 1;
        }
        
        
       public void Remove(T value)
       {
            for (int i =0 ; i< Children.Count(); i++)
            {
                if (Children.Get(i).Equals(value))
                {
                    Children.Remove(i);
                    
                }
               
            }
       }

        public TreeNode<T> Find(T value)
        {
            //TODO #8: Return the node that contains this value (it might be this node or a child). Apply recursively
            if (Children.Count() == 0)
            {
                return null;
            }
            else
            {
                for (int i=0 ; i < Children.Count(); i++)
                {
                    TreeNode<T> result = Children.Get(i);
                   if(result != null)
                    {
                        return result;
                    }

                }
                return null;
            }
        }


        public void Remove(TreeNode<T> node)
        {
            //TODO #9: Same as #6, but this method is given the specific node to remove, not the value
            foreach (TreeNode<T> ch in Children)
            {
                if (ch == node)
                {
                    Remove(ch);
                }
            }
        }
    }
}