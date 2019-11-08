using System;

namespace Optimization.Common.Models.Dto
{
    public class CupDto
    {
        public int Id { get; private set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public string Description { get; set; }
    }
}
