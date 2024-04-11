using System.IO.Pipes;
using Microsoft.VisualBasic;

public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {

        if (value == this.Data) {
            return;
        }
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value == this.Data) {
            return true;
        }
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                return false;
            else
                Left.Contains(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                return false;
            else
                Right.Contains(value);
        }
        return false;
    }

    public int GetHeight() {
        // TODO Start Problem 4
        if(this.Left is null && this.Right is null)
        {
            return 1;
        }
        else if (this.Left is null && this.Right is not null)
            {   
                return 1 + this.Right.GetHeight();
            }
            else if (this.Right is null && this.Left is not null)
            {
                return 1 + this.Left.GetHeight();
            }
            else if (this.Right is not null && this.Left is not null)
            {
                return 1 + Math.Max(this.Left.GetHeight(), this.Right.GetHeight());
            }
        
        return 0;  
    }
}