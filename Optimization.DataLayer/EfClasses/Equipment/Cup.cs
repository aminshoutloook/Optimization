
using BskaGenericCoreLib;
using Optimization.DataLayer.EfClasses.Projects;
using System;
using System.Collections.Generic;

namespace Optimization.DataLayer.EfClasses.Equipment
{
    public class Cup: IAuditTracker
    {
        public int Id { get; private set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; internal set; }
        public DateTime UpdatedDate { get; internal set; }

        //-----------------------------------------
        //Relationships
        public Guid ProjectId { get; private set; }
        public Project Project { get; private set; }

        public ICollection<Piece> Pieces { get; private set; }

        //-------------------------------------------
        //ctor
        public Cup()
        {
            this.Pieces = new List<Piece>();
        }

        public Cup(double width,double heigh)
        {
            this.Height = heigh;
            this.Width = width;

            this.Pieces = new List<Piece>();
        }

        public static IStatusGeneric<Cup> CreateCup(double width,double height)
        {
            var status = new StatusGenericHandler<Cup>();

            if (status.HasErrors)
            {
                return status;
            }

            var cup = new Cup
            {
                Width = width,
                Height = height
            };

            status.Result = cup;
            return status;
        }

        public IStatusGeneric UpdateCup(double width, double height)
        {
            var status = new StatusGenericHandler();

            if (status.HasErrors)
            {
                return status;
            }

            this.Width = width;
            this.Height = height;
            return status;
        }
    }
}
