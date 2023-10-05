namespace System.Collections.Generic
{
    /// <summary>
    /// List page extension methods
    /// </summary>
    public static class ListPageExtension
    {
        /// <summary>
        /// Converts an enumerable as an <see cref="IListPage{T}"/>
        /// </summary>
        /// <typeparam name="T">The type of the elements of source.</typeparam>
        /// <param name="collection"></param>
        /// <param name="page"></param>
        /// <param name="pageSize">Number of rows per page</param>
        /// <param name="totalRecords"></param>
        /// <returns></returns>
        public static IListPage<T> ToListPage<T>(this IEnumerable<T> collection, int page, int pageSize, int totalRecords)
        {
            return new ListPage<T>(collection, page, pageSize, totalRecords);
        }
    }
}
