namespace Marquitos.EntityFrameworkCore
{
    /// <summary>
    /// Interface that defines an Entity With Deleted Meta
    /// </summary>
    public interface IEntityWithDeletedMeta : IEntity
    {
        /// <summary>
        /// Indicates if the entity was soft deleted.
        /// </summary>
        bool IsDeleted { get; set; }
    }

    /// <summary>
    /// Interface that defines an Entity With Deleted Meta identified by TKey
    /// </summary>
    public interface IEntityWithDeletedMeta<TKey> : IEntity<TKey>, IEntityWithDeletedMeta
    {
    }
}
