namespace Marquitos.EntityFrameworkCore
{
    /// <summary>
    /// Interface that defines an Entity
    /// </summary>
    public interface IEntity
    {
    }

    /// <summary>
    /// Interface that defines an Entity identified by TKey
    /// </summary>
    public interface IEntity<TKey> : IEntity
    {
        /// <summary>
        /// Identifier Key
        /// </summary>
        TKey Id { get; set; }
    }
}
