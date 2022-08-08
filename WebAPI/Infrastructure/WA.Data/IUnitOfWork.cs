namespace Data;

public interface IUnitOfWork : Base.IUnitOfWork
{

    // **************************************************
    // IXXXXXRepository XXXXXRepository {get ;}
    // **************************************************

    ToDo.IToDoRepository ToDoRepository { get; }
}
