using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace ДЗ_21._Валідація_і_кешування.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly DataContext _context;

        public GroupRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<ICollection<Student>> Add(Group item)
        {
            await _context.AddAsync(item);
            _context.SaveChanges();
            return item.Students;
        }

        public async Task<ICollection<Group>> Get()
        {
            return await _context.Set<Group>().ToListAsync();
        }
    }
}
