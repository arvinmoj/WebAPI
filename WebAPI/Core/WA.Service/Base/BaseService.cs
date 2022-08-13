using Data;
using AutoMapper;

namespace Service.Base;

public class BaseService
{
    public BaseService(IUnitOfWork unitOfWork , Mapper mapper) : base()
    {
        Mapper = mapper;
        UnitOfWork = unitOfWork;
    }

    protected Mapper Mapper;
    protected IUnitOfWork UnitOfWork { get; }
}
