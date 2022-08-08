
using Data.ToDo;

namespace Data;

public class UnitOfWork : Base.UnitOfWork, IUnitOfWork
{
    public UnitOfWork(Utility.Tools.Options options) : base(options)
    {
    }

    // **************************************************
    //private IXXXXXRepository _xXXXXRepository;

    //public IXXXXXRepository XXXXXRepository
    //{
    //	get
    //	{
    //		if (_xXXXXRepository == null)
    //		{
    //			_xXXXXRepository =
    //				new XXXXXRepository(DatabaseContext);
    //		}

    //		return _xXXXXRepository;
    //	}
    //}
    // **************************************************

    private IToDoRepository _ToDoRepository;

    public IToDoRepository ToDoRepository
    {
        get
        {
            if (_ToDoRepository == null)
            {
                _ToDoRepository =
                    new ToDo.ToDoRepository(DatabaseContext);
            }

            return _ToDoRepository;
        }
    }
}
