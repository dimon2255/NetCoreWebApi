using Microsoft.AspNetCore.Mvc;
using NetCoreWebApi.DataModels;

namespace NetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        /// <summary>
        /// Context to data store
        /// </summary>
        private TicketDbContext _dbContext;

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="dbContext">Injected by runtime</param>
        public TicketController(TicketDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}