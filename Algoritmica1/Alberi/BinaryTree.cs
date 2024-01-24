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
            } else
            {

            }
            Add(node, root);
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
                parent.imbalance = parent.imbalance - 1;
                if (parent.imbalance == -2)
                {
                    if (parent.left.imbalance == -1)
                    {
                        LeftRotate(parent.left, parent, false);
                    } else
                    {
                        //LeftRightRotate(parent);
                    }
                }
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
                parent.imbalance = parent.imbalance + 1;
                if (parent.imbalance == 2)
                {
                    if (parent.right.imbalance == 1)
                    {
                        LeftRotate(parent.right, parent, false);
                    }
                    else
                    {
                        //RightRotate(node.right, parent, true);
                    }
                }
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

        result += node.value;
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
    public void RightRotate(BinaryNode<T> node, BinaryNode<T> parent, bool isLeft)
    {
        node.imbalance = 0;
        parent.imbalance = 0;
        if (parent == root) root = node.left;
        else
        {
            if (isLeft) parent.left = node.left;
            else parent.right = node.left;
        }
        var temp = node.left.right;
        node.left.right = node;
        node.left = temp;
    }
    public void LeftRotate(BinaryNode<T> node, BinaryNode<T> parent, bool isLeft)
    {
        Console.WriteLine(parent.value);
        node.imbalance = 0;
        parent.imbalance = 0;
        if (node == root) root = node.right;
        else
        {
            if (isLeft) parent.left = node.right;
            else parent.left = node.right;
        }
        var temp = node.right.left;
        node.right.left = node;
        node.right = temp;
    }
}
