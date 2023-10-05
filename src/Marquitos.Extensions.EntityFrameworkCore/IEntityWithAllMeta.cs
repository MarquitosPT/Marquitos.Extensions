namespace Marquitos.EntityFrameworkCore
{
    /// <summary>
    /// Interface that defines an Entity With All Meta
    /// </summary>
    public interface IEntityWithAllMeta : IEntityWithCreatedAndUpdatedMeta, IEntityWithDeletedMeta
    {
    }

    /// <summary>
    /// Interface that defines an Entity With All Meta identified by TKey
    /// </summary>
    public interface IEntityWithAllMeta<TKey> : IEntity<TKey>, IEntityWithAllMeta
    {
    }
}
