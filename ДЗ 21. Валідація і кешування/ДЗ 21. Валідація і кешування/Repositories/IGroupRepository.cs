namespace ДЗ_21._Валідація_і_кешування.Repositories
{
    public interface IGroupRepository
    {
        Task<ICollection<Student>> Add(Group item);
        Task<ICollection<Group>> Get();
    }
}
