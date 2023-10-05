namespace Marquitos.EntityFrameworkCore
{
    /// <summary>
    /// Interface that defines an Enum type Entity with created meta
    /// </summary>
    public interface IEnumEntityWithCreatedMeta<TKey> : IEnumEntity<TKey>, IEntityWithCreatedMeta<int> where TKey : struct
    {
    }
}
