using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using ДЗ_21._Валідація_і_кешування.Repositories;

namespace ДЗ_21._Валідація_і_кешування.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupRepository _groupRepository;
        private readonly IMemoryCache memoryCache;

        public GroupController(IGroupRepository groupRepository, IMemoryCache memoryCache)
        {
            _groupRepository = groupRepository;
            this.memoryCache = memoryCache;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Group>>> Get()
        {
            const string key = "key";
            List<Group> result;

            if (memoryCache.TryGetValue(key, out result))
                return result;
            else
            {
                result = (List<Group>)await _groupRepository.Get();
                memoryCache.Set(key, result, DateTime.Now.AddDays(1));
            }
            return result;
        }

        [HttpPost]
        [ProducesResponseType(204)]
        public async Task<IActionResult> Post([FromBody] Group groupCreate)
        {
            if (groupCreate == null)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _groupRepository.Add(groupCreate);
            return Ok(result);
        }
    }
}
