namespace System
{
    /// <summary>
    /// String Extension Methods
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Bind arguments
        /// </summary>
        /// <param name="stringPattern"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        public static string Bind<T>(this string stringPattern, T arguments) where T : class
        {
            var result = stringPattern;

            foreach (var item in arguments.GetType().GetProperties())
            {
                result = result.Replace(string.Concat("{", item.Name, "}"), item.GetValue(arguments)?.ToString());
            }

            return result;
        }
    }
}