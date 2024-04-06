using System.Collections;
using System.ComponentModel.Design;

public class LinkedList : IEnumerable<int> {
    private Node? _head;
    private Node? _tail;

    /// <summary>
    /// Insert a new node at the front (i.e. the head) of the linked list.
    /// </summary>
    public void InsertHead(int value) {
        // Create new node
        Node newNode = new Node(value);
        // If the list is empty, then point both head and tail to the new node.
        if (_head is null) {
            _head = newNode;
            _tail = newNode;
        }
        // If the list is not empty, then only head will be affected.
        else {
            newNode.Next = _head; // Connect new node to the previous head
            _head.Prev = newNode; // Connect the previous head to the new node
            _head = newNode; // Update the head to point to the new node
        }
    }

    /// <summary>
    /// Insert a new node at the back (i.e. the tail) of the linked list.
    /// </summary>
    public void InsertTail(int value) {
        // TODO Problem 1
        // Create new node
        Node newNode = new Node(value);
        // If the list is empty, then point both head and tail to the new node.
        if (_tail is null) {  
            _head = newNode;  // Point head to new node
            _tail = newNode;  // // Point tail to new node
        }
        else {
            newNode.Prev = _tail;  // Connect new node to the previous tail
            _tail.Next = newNode;  // Connect the previous tail to the new node
            _tail = newNode;       // Update the tail to point to the new node
        }
    }


    /// <summary>
    /// Remove the first node (i.e. the head) of the linked list.
    /// </summary>
    public void RemoveHead() {
        // If the list has only one item in it, then set head and tail 
        // to null resulting in an empty list.  This condition will also
        // cover an empty list.  Its okay to set to null again.
        if (_head == _tail) {
            _head = null;
            _tail = null;
        }
        // If the list has more than one item in it, then only the head
        // will be affected.
        else if (_head is not null) {
            _head.Next!.Prev = null; // Disconnect the second node from the first node
            _head = _head.Next; // Update the head to point to the second node
        }
    }


    /// <summary>
    /// Remove the last node (i.e. the tail) of the linked list.
    /// </summary>
    public void RemoveTail() {
        // TODO Problem 2
        if (_head == _tail) {
            _head = null;
            _tail = null;
        }
        else {
            _tail!.Prev!.Next = null; 
            _tail = _tail.Prev;
        }
    }

    /// <summary>
    /// Insert 'newValue' after the first occurrence of 'value' in the linked list.
    /// </summary>
    public void InsertAfter(int value, int newValue) {
        // Search for the node that matches 'value' by starting at the 
        // head of the list.
        Node? curr = _head;
        while (curr is not null) {
            if (curr.Data == value) {
                // If the location of 'value' is at the end of the list,
                // then we can call insert_tail to add 'new_value'
                if (curr == _tail) {
                    InsertTail(newValue);
                }
                // For any other location of 'value', need to create a 
                // new node and reconnect the links to insert.
                else {
                    Node newNode = new(newValue);
                    newNode.Prev = curr; // Connect new node to the node containing 'value'
                    newNode.Next = curr.Next; // Connect new node to the node after 'value'
                    curr.Next!.Prev = newNode; // Connect node after 'value' to the new node
                    curr.Next = newNode; // Connect the node containing 'value' to the new node
                }

                return; // We can exit the function after we insert
            }

            curr = curr.Next; // Go to the next node to search for 'value'
        }
    }

    /// <summary>
    /// Remove the first node that contains 'value'.
    /// </summary>
    public void Remove(int value) {
        // TODO Problem 3
        {
        Node firstNode = new Node(value);
        // Start at the beginning (the head)
        var current = _head;
        
        // Loop until we have reached the end (null)
        while (current != null && current.Data != value)  // Check if head is not null and current value is not same as value
            current = current.Next;     // Move forward
        if( current == null)  // Check if current node is not missing.
            return;
        // Check if current node is the head node
        if(current == _head) {     
            RemoveHead();   // If it is remove it.
            return;
        }
        // Check if current node is the tail node
        if(current == _tail) {  // If it is the tail remove it.
            RemoveTail();
            return;
        }
        current.Next!.Prev = current.Prev;  // Set the prev of the node after current to the node before current. 
        current.Prev!.Next = current.Next;  // Set the next of the node before current to the node after current.
        return;
        }
    }

    /// <summary>
    /// Search for all instances of 'oldValue' and replace the value with 'newValue'.
    /// </summary>
    public void Replace(int oldValue, int newValue) {
        // TODO Problem 4
        var current = _head;

        while(current != null)
        {
            // Search for all instances of 'oldValue'
            if (current.Data == oldValue){
                current.Data = newValue; // Replace the value with 'newValue'
            }
            current = current.Next;  // Continue forward
        }
    }

    /// <summary>
    /// Yields all values in the linked list
    /// </summary>
    IEnumerator IEnumerable.GetEnumerator() {
        // call the generic version of the method
        return this.GetEnumerator();
    }

    /// <summary>
    /// Iterate forward through the Linked List
    /// </summary>
    public IEnumerator<int> GetEnumerator() {
        var curr = _head; // Start at the beginning since this is a forward iteration.
        while (curr != null) {
            yield return curr.Data; // Provide (yield) each item to the user
            curr = curr.Next; // Go forward in the linked list
        }
    }

    /// <summary>
    /// Iterate backward through the Linked List
    /// </summary>
    public IEnumerable Reverse() {
        // TODO Problem 5
        var curr = _tail;  // / Start at the end/tail
        while (curr != null) {
            yield return curr.Data;  // yield each item to the user
            curr = curr.Prev;   // Go backward in the linked list
        }
    }

    public override string ToString() {
        return "<LinkedList>{" + string.Join(", ", this) + "}";
    }

    // Just for testing.
    public Boolean HeadAndTailAreNull() {
        return _head is null && _tail is null;
    }

    // Just for testing.
    public Boolean HeadAndTailAreNotNull() {
        return _head is not null && _tail is not null;
    }
}