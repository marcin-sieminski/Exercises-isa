using System;

namespace Ex6
{
    class Program
    {
        static void Main()
        {
            var assignmentsList = new AssignmentsList();

            var fileOperations = new FileOperations
            {
                Path = @"c:\Temp\homework\datastructures\", 
                FileName = "assignments.xml"
            };
            fileOperations.CreateFileXml(fileOperations.Path, fileOperations.FileName, assignmentsList.Assignments);

            var assignmentsQueue = new AssignmentsQueue
            {
                Assignments = fileOperations.LoadFileXmlToQueue(fileOperations.Path, fileOperations.FileName)
            };
            assignmentsQueue.Run();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}