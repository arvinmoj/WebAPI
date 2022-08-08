namespace Data.ToDo
{
    public class ToDoRepository : Repository<Models.ToDoModel>, IToDoRepository
    {
        internal ToDoRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}
