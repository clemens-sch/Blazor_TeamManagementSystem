namespace TeamManagementSystem.Interfaces
{
    // Interface: Contains Methods that should be executed by a service
    public interface ICrud<T> where T : class
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        // Primary-Keys
        T GetById(int id);
        // Every row in the entity
        List<T> GetAll();
    }
}
