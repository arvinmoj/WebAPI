namespace Data
{
    public class Repository<T> : Base.Repository<T> where T : Models.Base.BaseEntity
    {
        internal Repository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        public override void Insert(T entity)
        {
            if (entity == null)
            {
                throw new System.ArgumentNullException(paramName: nameof(entity));
            }

            entity.InsertDateTime = Utility.DateTime.Now;

            DbSet.Add(entity);
        }

    }
}
