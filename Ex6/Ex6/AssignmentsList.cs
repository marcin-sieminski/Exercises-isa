﻿using System;
using System.Collections.Generic;

namespace Ex6
{
    public class AssignmentsList
    {
        public List<Assignment> assignmentsList;

        public AssignmentsList()
        {
            assignmentsList = new List<Assignment>();
            Initialize();
        }

        private void Initialize()
        {
            assignmentsList.Add(new Assignment {AssignmentStartDate = DateTime.UtcNow, AssignmentDueDate = DateTime.UtcNow.AddMonths(2), AssignmentSubject = "Read about data structures", AdditionalNotes = "Search for additional info on the Internet"});
            assignmentsList.Add(new Assignment {AssignmentStartDate = DateTime.UtcNow, AssignmentDueDate = DateTime.UtcNow.AddMonths(2), AssignmentSubject = "Learn how to operate on files", AdditionalNotes = "Watch recording from the last classes"});
            assignmentsList.Add(new Assignment {AssignmentStartDate = DateTime.UtcNow, AssignmentDueDate = DateTime.UtcNow.AddMonths(2), AssignmentSubject = "Buy paper", AdditionalNotes = "A4 white for printer"});
            assignmentsList.Add(new Assignment {AssignmentStartDate = DateTime.UtcNow, AssignmentDueDate = DateTime.UtcNow.AddMonths(2), AssignmentSubject = "Read the book: Clean Code", AdditionalNotes = "Borrowed book"});
            assignmentsList.Add(new Assignment {AssignmentStartDate = DateTime.UtcNow, AssignmentDueDate = DateTime.UtcNow.AddMonths(2), AssignmentSubject = "Push ex.6 solution", AdditionalNotes = "Also add PR"});
            assignmentsList.Add(new Assignment {AssignmentStartDate = DateTime.UtcNow, AssignmentDueDate = DateTime.UtcNow.AddMonths(2), AssignmentSubject = "Do shopping", AdditionalNotes = "First check available money"});
            assignmentsList.Add(new Assignment {AssignmentStartDate = DateTime.UtcNow, AssignmentDueDate = DateTime.UtcNow.AddMonths(2), AssignmentSubject = "Read about unobtrusive validation", AdditionalNotes = "ASP.NET Core MVC"});
            assignmentsList.Add(new Assignment {AssignmentStartDate = DateTime.UtcNow, AssignmentDueDate = DateTime.UtcNow.AddMonths(2), AssignmentSubject = "Read Introduction to Razor Pages", AdditionalNotes = "ASP.NET Core"});
            assignmentsList.Add(new Assignment {AssignmentStartDate = DateTime.UtcNow, AssignmentDueDate = DateTime.UtcNow.AddMonths(2), AssignmentSubject = "Homework ex.7", AdditionalNotes = "When ex.6 is done"});
            assignmentsList.Add(new Assignment {AssignmentStartDate = DateTime.UtcNow, AssignmentDueDate = DateTime.UtcNow.AddMonths(2), AssignmentSubject = "Watch The Umbrella Academy", AdditionalNotes = "Netflix, 2 seasons"});
        }
    }
}
