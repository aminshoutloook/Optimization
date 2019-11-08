
using BskaGenericCoreLib;
using Optimization.DataLayer.EfClasses.Projects;
using System;

namespace Optimization.DataLayer.EfClasses.Equipment
{
    public class Piece : IAuditTracker
    {
        public long Id { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public DateTime CreatedDate { get; internal set; }
        public DateTime UpdatedDate { get; internal set; }

        //-----------------------------------------
        //Relationships
        public Guid ProjectId { get; private set; }
        public Project Project { get; private set; }

        public int? CupId { get; private set; }
        public Cup Cup { get; private set; }

        //-------------------------------------------
        //ctor
        public Piece()
        {
        }

        public Piece(double width, double heigh)
        {
            this.Height = heigh;
            this.Width = width;
        }

        public static IStatusGeneric<Piece> CreatePiece(double width, double height)
        {
            var status = new StatusGenericHandler<Piece>();

            if (status.HasErrors)
            {
                return status;
            }

            var piece = new Piece
            {
                Width = width,
                Height = height
            };

            status.Result = piece;
            return status;
        }

        public IStatusGeneric UpdatePiece(double width, double height)
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
