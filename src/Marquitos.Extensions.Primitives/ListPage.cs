namespace System.Collections.Generic
{
    /// <summary>
    /// Implements the <see cref="IListPage{T}"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListPage<T> : IListPage<T>
    {
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public ListPage()
        {
            Items = new HashSet<T>();
            Page = 0;
            PageSize = 0;
            TotalRecords = 0;
            TotalPages = 0;
        }

        /// <summary>
        /// Creates a new instance
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRecords"></param>
        public ListPage(int page, int pageSize, int totalRecords)
        {
            Items = new HashSet<T>();
            Page = page;
            PageSize = pageSize;
            TotalRecords = totalRecords;
            TotalPages = (totalRecords > 0 && pageSize > 0) ? (totalRecords / pageSize) + (1 - (pageSize * (totalRecords / pageSize)) / totalRecords) : 0;
        }

        /// <summary>
        /// Creates a new instance
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRecords"></param>
        public ListPage(IEnumerable<T> collection, int page, int pageSize, int totalRecords)
        {
            Items = new HashSet<T>(collection);
            Page = page;
            PageSize = pageSize;
            TotalRecords = totalRecords;
            TotalPages = (totalRecords > 0 && pageSize > 0) ? (totalRecords / pageSize) + (1 - (pageSize * (totalRecords / pageSize)) / totalRecords) : 0;
        }

        /// <summary>
        /// Collection items
        /// </summary>
        public IEnumerable<T> Items { get; set; }

        /// <summary>
        /// Current page number
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Number of rows per page
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Total of Pages
        /// </summary>
        public int TotalPages { get; set; }

        /// <summary>
        /// Total of Records
        /// </summary>
        public int TotalRecords { get; set; }
    }
}


