using Microsoft.EntityFrameworkCore;
using todoApi.Data;
using todoApi.Data.Models;

namespace todoApi.Services
{
    public class AssignmentService : IAssignmentService
    {
        private readonly TodoDB _database;

        public AssignmentService(TodoDB database)
        {
            this._database = database;
        }

        public async Task<List<Assignment>> List()
        {
            return await this._database.Assignment.ToListAsync();
        }

        public async Task Insert(Assignment assignment)
        {
            this._database.Assignment.Add(assignment);
            await this._database.SaveChangesAsync();
        }

        public Task Delete(Assignment assignment)
        {
            throw new NotImplementedException();
        }

        public Task Update(Assignment assignment)
        {
            throw new NotImplementedException();
        }
    }
}
