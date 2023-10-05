using System.Linq.Expressions;

namespace System.Linq
{
    /// <summary>
    /// Linq Extension Methods
    /// </summary>
    public static class LinqExtension
    {
        /// <summary>
        /// Conditional Filter
        /// </summary>
        /// <typeparam name="T">The type of the elements of source.</typeparam>
        /// <param name="querie">This querie</param>
        /// <param name="condition"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> querie, bool condition, Expression<Func<T, bool>> predicate)
        {
            if (condition)
            {
                return querie.Where(predicate);
            }
            return querie;
        }

        /// <summary>
        /// Retrieve only a specified page from an <see cref="IOrderedQueryable"/> object.
        /// </summary>
        /// <typeparam name="T">The type of the elements of source.</typeparam>
        /// <param name="querie">This querie</param>
        /// <param name="page">Page number</param>
        /// <param name="pageSize">Number of rows per page</param>
        /// <returns></returns>
        public static IOrderedQueryable<T> TakePage<T>(this IOrderedQueryable<T> querie, int page, int pageSize)
        {
            if (pageSize < 0)
            {
                return querie;
            }

            return (IOrderedQueryable<T>)querie.Skip((page - 1) * pageSize).Take(pageSize);
        }
    }
}
