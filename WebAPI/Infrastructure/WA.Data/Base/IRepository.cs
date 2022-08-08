namespace Data.Base;

public interface IRepository<T> where T : Models.Base.BaseEntity
{
    void Insert(T entity);

    Task InsertAsync(T entity);

    void Update(T entity);

    Task UpdateAsync(T entity);

    void Delete(T entity);

    Task DeleteAsync(T entity);

    T GetById(Guid id);

    Task<T> GetByIdAsync(System.Guid id);

    bool DeleteById(System.Guid id);

    Task<bool> DeleteByIdAsync(System.Guid id);

    IList<T> GetAll();

    Task<System.Collections.Generic.IList<T>> GetAllAsync();
}
