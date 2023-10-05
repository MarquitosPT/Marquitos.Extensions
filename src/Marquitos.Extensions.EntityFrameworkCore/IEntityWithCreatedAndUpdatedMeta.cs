namespace Marquitos.EntityFrameworkCore
{
    /// <summary>
    /// Interface that defines an Entity With Created And Updated Meta
    /// </summary>
    public interface IEntityWithCreatedAndUpdatedMeta : IEntityWithCreatedMeta
    {
        /// <summary>
        /// Entity last Updated Date
        /// </summary>
        DateTime UpdatedOn { get; set; }

        /// <summary>
        /// The user who updated the entity
        /// </summary>
        string UpdatedBy { get; set; }
    }

    /// <summary>
    /// Interface that defines an Entity With Created And Updated Meta identified by TKey
    /// </summary>
    public interface IEntityWithCreatedAndUpdatedMeta<TKey> : IEntity<TKey>, IEntityWithCreatedAndUpdatedMeta
    {
    }
}
