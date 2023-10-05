namespace Marquitos.EntityFrameworkCore
{
    /// <summary>
    /// Interface that defines an Enum type Entity
    /// </summary>
    public interface IEnumEntity<TKey> : IEntity<int> where TKey : struct
    {
        /// <summary>
        /// Identifier
        /// </summary>
        TKey Code { get; set; }

        /// <summary>
        /// Name identifier
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        string Description { get; set; }
    }
}
