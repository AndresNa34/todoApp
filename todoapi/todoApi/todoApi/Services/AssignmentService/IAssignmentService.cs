using todoApi.Data.Models;

namespace todoApi.Services
{

    public interface IAssignmentService
    {
        Task<List<Assignment>> List();
        Task Insert(Assignment assignment);
        Task Update(Assignment assignment);
        Task Delete(Assignment assignment);
    }
}
