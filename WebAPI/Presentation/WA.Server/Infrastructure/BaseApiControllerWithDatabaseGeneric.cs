namespace Infrastructure;

public class BaseApiControllerWithDatabaseGeneric<T> : BaseApiControllerWithDatabase where T : Models.Base.BaseEntity
{
    public BaseApiControllerWithDatabaseGeneric(Data.IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }

    # region HTTP GET (GET ALL)

    [Microsoft.AspNetCore.Mvc.HttpGet]
    public virtual async System.Threading.Tasks.Task
        <Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.IEnumerable<T>>>
        GetAsync()
    {
        var result =
            await
            UnitOfWork.GetRepository<T>()
            .GetAllAsync()
            ;

        return Ok(value: result);
    }

    # endregion /HTTP GET (GET ALL)

    #region HTTP GET (GET BY ID)

    [Microsoft.AspNetCore.Mvc.HttpGet(template: "{0}")]
    public virtual async System.Threading.Tasks.Task
        <Microsoft.AspNetCore.Mvc.ActionResult<T>>
        GetAsync(System.Guid id)
    {
        var foundedEntity =
            await
            UnitOfWork.GetRepository<T>()
            .GetByIdAsync(id);

        return Ok(value: foundedEntity);
    }

    #endregion /HTTP GET

    # region HTTP POST

    [Microsoft.AspNetCore.Mvc.HttpPost]
    public virtual async System.Threading.Tasks.Task
        <Microsoft.AspNetCore.Mvc.ActionResult<T>>
        PostAsync(T entity)
    {
        await UnitOfWork.GetRepository<T>().InsertAsync(entity);

        await UnitOfWork.SaveAsync();

        return Ok(value: entity);
    }

    # endregion / HTTP POST

}
