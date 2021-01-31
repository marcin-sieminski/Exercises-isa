using System;
using System.Collections.Generic;

namespace Ex6
{
    public class AssignmentsQueue
    {
        public Queue<Assignment> assignmentsQueue;

        public AssignmentsQueue()
        {
            assignmentsQueue = new Queue<Assignment>();
        }

        public void Run()
        {
            Console.WriteLine($"Number of assignments in queue: {assignmentsQueue.Count}\n");
            while (assignmentsQueue.Count > 0)
            {
                ProcessCurrentAssignment();
            }

            Console.WriteLine("Processing finished. The queue is empty.");
        }

        private void ProcessCurrentAssignment()
        {
            var currentAssignment = assignmentsQueue.Peek();
            Console.WriteLine($"Processing: {currentAssignment.AssignmentSubject}");
            Console.WriteLine($"Time from creation to processing: {(DateTime.UtcNow - currentAssignment.AssignmentStartDate).Milliseconds} milliseconds");
            Console.WriteLine($"Assignment created: {currentAssignment.AssignmentStartDate.ToLocalTime()} (local time)\n");
            assignmentsQueue.Dequeue();
        }
    }
}
