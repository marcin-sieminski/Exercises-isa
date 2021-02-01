using System;
using System.Collections.Generic;

namespace Ex6
{
    public class AssignmentsQueue
    {
        public Queue<Assignment> Assignments;

        public AssignmentsQueue()
        {
            Assignments = new Queue<Assignment>();
        }

        public void Run()
        {
            Console.WriteLine($"Number of assignments in queue: {Assignments.Count}\n");
            while (Assignments.Count > 0)
            {
                ProcessCurrentAssignment();
            }

            Console.WriteLine("Processing finished. The queue is empty.");
        }

        private void ProcessCurrentAssignment()
        {
            var currentAssignment = Assignments.Peek();
            Console.WriteLine($"Processing: {currentAssignment.AssignmentSubject}");
            Console.WriteLine($"Time from creation to processing: {(DateTime.UtcNow - currentAssignment.AssignmentStartDate).Milliseconds} milliseconds");
            Console.WriteLine($"Assignment created: {currentAssignment.AssignmentStartDate.ToLocalTime()} (local time)\n");
            Assignments.Dequeue();
        }
    }
}
