
using BskaGenericCoreLib;
using Optimization.DataLayer.EfClasses.Equipment;
using System;
using System.Collections.Generic;

namespace Optimization.DataLayer.EfClasses.Projects
{
    public class Project : IAuditTracker
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        //-----------------------------------------
        //Relationships
        public ICollection<Cup> Cups { get; private set; }
        public ICollection<Piece> Pieces { get; private set; }

        //-------------------------------------------
        //ctors
        public Project()
        {
            this.Cups = new List<Cup>();
            this.Pieces = new List<Piece>();
        }

        public Project(string name,string description)
        {
            this.Name = name;
            this.Description = description;

            this.Cups = new List<Cup>();
            this.Pieces = new List<Piece>();
        }

        public static IStatusGeneric<Project> CreateProject(string name,string description)
        {
            var status = new StatusGenericHandler<Project>();
            if (string.IsNullOrWhiteSpace(name))
            {
                status.AddError("name is null or empty!!!");
            }

            if (status.HasErrors)
            {
                return status;
            }

            var project = new Project
            {
                Description = description,
                Name = name
            };
            status.Result = project;
            return status;
        }

        public IStatusGeneric UpdateProject(string name,string description)
        {
            var status = new StatusGenericHandler();
            if (string.IsNullOrWhiteSpace(name))
            {
                status.AddError("name is null or empty!!!");
            }

            if (status.HasErrors)
            {
                return status;
            }

            this.Name = name;
            this.Description = description;
            return status;
        }
    }
}
