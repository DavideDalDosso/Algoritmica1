using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryTree<T> where T : IComparable<T>
{
    BinaryNode<T>? root;

    public void Add(T value)
    {
        var node = new BinaryNode<T>();
        node.value = value;
        Add(node, null);
    }

    private void Add(BinaryNode<T> node, BinaryNode<T>? parent)
    {
        if(parent == null)
        {
            if (root == null)
            {
                root = node;
                return;
            }
            Add(node, root);

            if(root.left.imbalance < -1)
            {

            }
            if(root.right.imbalance > 1)
            {

            }
        }
        else
        {
            if (node.value.CompareTo(parent.value) == -1)
            {
                if (parent.left != null)
                {
                    Add(node, parent.left);
                }
                else
                {
                    parent.left = node;
                }
                parent.imbalance = parent.left.imbalance - 1;
            }
            else
            {
                if (parent.right != null)
                {
                    Add(node, parent.right);
                }
                else
                {
                    parent.right = node;
                }
                parent.imbalance = parent.right.imbalance + 1;
            }
        }
    }
    public override string ToString()
    {
        string result = "";

        if(root != null)
        {
            result += ToString(root);
        }

        return result;
    }

    private string ToString(BinaryNode<T> node)
    {
        string result = "";

        result += node.imbalance;
        result += " ( ";

        if(node.left != null)
        {
            result += ToString(node.left);
        } else result += "NIL";
        if (node.right != null)
        {
            result += ToString(node.right);
        }
        else result += "NIL";

        result += " ) ";

        return result;
    }
    public void Balance(BinaryNode<T> node)
    {

    }
}
