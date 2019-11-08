
using Optimization.DataLayer.EfCode;
using Optimization.ServiceLayer.ProjectServices.Concrete;
using System.Threading.Tasks;

namespace Optimization.UI.ViewModels.Concrete
{
    public sealed class StartWindowViewModel: BaseViewModel, IStartWindowViewModel
    {
        #region ctor

        public StartWindowViewModel()
        {
            _optimazationContext = BootStrapper.Resolve<OptimizationContext>();
            _projectService = new ListProjectService(_optimazationContext);
        }

        #endregion

        #region properties
        #endregion

        #region methods

        public async Task initEfFirstCall()
        {
           await _projectService.GetProjects();
        }

        #endregion

        #region commands
        #endregion

        #region fields

        private readonly ListProjectService _projectService;
        private readonly OptimizationContext _optimazationContext;

        #endregion
    }
}
