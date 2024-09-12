using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using todoApi.Data.Models;
using todoApi.Services;

namespace todoApi.Controllers
{
    [Route("api/assignment")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignmentService _assignmentService;

        public AssignmentController(IAssignmentService assignmentService)
        {
            this._assignmentService = assignmentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Assignment>>> List()
        {
            List<Assignment> assignments = await this._assignmentService.List();
            return assignments;
        }

        [HttpPost]
        public async Task<ActionResult<Assignment>> Insert(Assignment assignment)
        {
            await this._assignmentService.Insert(assignment);
            return assignment;
        }

    }
}
