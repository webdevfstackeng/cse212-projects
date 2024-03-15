public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases
        // Example: Banking service priority queue

        // Test 1
        // Scenario: Add people with different values (names) and priorities (age) to the priority queue and run untill the queue is empty
        // Expected Result: Ben 20, Sam 63, Joe 17, Dan 73, Tom 15, Job 83, Tim 9
        Console.WriteLine("Test 1");

        priorityQueue.Enqueue("Ben", 20);
        priorityQueue.Enqueue("Sam", 63);
        priorityQueue.Enqueue("Joe", 17);
        priorityQueue.Enqueue("Dan", 73);
        priorityQueue.Enqueue("Tom", 15);
        priorityQueue.Enqueue("Job", 83);
        priorityQueue.Enqueue("Tim", 9);

        Console.WriteLine(priorityQueue.ToString());
              
        // Defect(s) Found: No defects found

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Remove a person with the highest priority.
        // Expected Result: Job, Dan, Sam, Ben, Joe, Tom, Tim

        Console.WriteLine("Test 2");

         for (int i = 0; i < 7; i++)
        {
            Console.WriteLine(priorityQueue.Dequeue());
        }

        // Defect(s) Found: Not removing the person with the highest priority
        // Fix: Modified the Dequeue function to remove the item with the highest priority
        Console.WriteLine("---------");

        // Test 3
        // Scenario: View the person/people with the highest priority.
        // Expected Result: Sam, 63; Job, 63; Joe, 17;  Tom, 15; Tim, 9
        Console.WriteLine("Test 3");

        priorityQueue.Enqueue("Ben", 20);
        priorityQueue.Enqueue("Sam", 63);
        priorityQueue.Enqueue("Joe", 17);
        priorityQueue.Enqueue("Dan", 73);
        priorityQueue.Enqueue("Tom", 15);
        priorityQueue.Enqueue("Job", 63);
        priorityQueue.Enqueue("Tim", 9);

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine(priorityQueue.Dequeue());
        }

        // Defect(s) Found: Items with equal priority are not removed in the order they appeared in the queue
        // Fix: Changed the comparison signs from greater than or equal to to greater than.

        Console.WriteLine("---------");

        // Test 4
        // Scenario: Remove an item from an empty priority queue
        // Expected Result: "The queue is empty."
        Console.WriteLine("Test 4");

        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: No defects found.

        Console.WriteLine("---------");
    }
}