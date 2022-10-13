namespace System.Collections.Generic
{
    /// <summary>
    /// Interface for a collection page result
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IListPage<T>
    {
        /// <summary>
        /// Collection items
        /// </summary>
        IEnumerable<T> Items { get; }

        /// <summary>
        /// Current page number
        /// </summary>
        int Page { get; }

        /// <summary>
        /// Number of rows per page
        /// </summary>
        int PageSize { get; }

        /// <summary>
        /// Total of Pages
        /// </summary>
        int TotalPages { get; }

        /// <summary>
        /// Total of Records
        /// </summary>
        int TotalRecords { get; }
    }
}

