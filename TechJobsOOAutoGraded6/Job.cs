﻿using System;
namespace TechJobsOOAutoGraded6
{
    public class Job
    {


        public int Id { get; }
        private static int nextId = 1;
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Task 3: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }



        public override string ToString()
        {
            //if (JobCoreCompetency == null || Name == null || EmployerName == null || EmployerLocation == null || JobType == null)
            //{
            //    return "Data not available";
            //}
            //else
            //{
            string newString = "\nID: " + Id + "\n";
            if (Name == "")
            {
                newString += "Name: " + "Data not available" + "\n";
            }
            else
            {
                newString += "Name: " + Name + "\n";
            }
            if (EmployerName.Value == "")
            {
                newString += "Employer: " + "Data not available" + "\n";
            }
            else
            {
               newString += "Employer: " + EmployerName + "\n";
            }
            if (EmployerLocation.Value == "")
            {
                newString += "Location: " + "Data not available" + "\n";
            }
            else
            {
                newString += "Location: " + EmployerLocation + "\n";
            }
            if (JobType.Value == "")
            {
                newString += "Position Type: " + "Data not available" + "\n";
            }
            else
            {
                newString += "Position Type: " + JobType + "\n";
            }
            if (JobCoreCompetency.Value == "")
            {
                return newString += "Core Competency: " + "Data not available" + "\n";
            }
            else
            {
                return newString += "Core Competency: " + JobCoreCompetency + "\n";
            }

            //return
            //"\nID: " + Id + "\n" +
            //    "Name: " + Name + "\n" +
            //    "Employer: " + EmployerName + "\n" +
            //    "Location: " + EmployerLocation + "\n" +
            //    "Position Type: " + JobType + "\n" +
            //    "Core Competency: " + JobCoreCompetency + "\n";
            //}
        }
        // TODO: Task 3: Generate Equals() and GetHashCode() methods.  

        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.



    }
}

