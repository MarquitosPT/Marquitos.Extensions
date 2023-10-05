namespace Marquitos.EntityFrameworkCore
{
    /// <summary>
    /// Interface that defines an Entity With Created Meta
    /// </summary>
    public interface IEntityWithCreatedMeta : IEntity
    {
        /// <summary>
        /// Date of creation
        /// </summary>
        DateTime CreatedOn { get; set; }

        /// <summary>
        /// The user who created the entity
        /// </summary>
        string CreatedBy { get; set; }
    }

    /// <summary>
    /// Interface that defines an Entity With Created Meta identified by TKey
    /// </summary>
    public interface IEntityWithCreatedMeta<TKey> : IEntity<TKey>, IEntityWithCreatedMeta
    {
    }
}
