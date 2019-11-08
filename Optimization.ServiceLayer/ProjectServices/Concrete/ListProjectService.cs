using Microsoft.EntityFrameworkCore;
using Optimization.Common.Models.ListDto;
using Optimization.DataLayer.EfCode;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Optimization.ServiceLayer.ProjectServices.Concrete
{
    public class ListProjectService
    {
        private readonly OptimizationContext _context;

        public ListProjectService(OptimizationContext context)
        {
            _context = context;
        }

        public async Task<List<ProjectListDto>> GetProjects()
        {
            return await _context.Projects.Select(pr => new ProjectListDto
            {
                CreatedDate=pr.CreatedDate.ToString("d"),
                Description=pr.Description,
                Id=pr.Id,
                UpdatedDate=pr.UpdatedDate.ToString(),
                Name=pr.Name
            }).ToListAsync();
        } 
    }
}
