using ScotchBoardSQL.Cleaner;

namespace ScotchBoardSQL.Decorator
{
    /// <summary>
    /// Contains the basic query decorator functionalities
    /// </summary>
    public abstract class QueryDecorator
    {
        /// <summary>
        /// String reprezentation of the query
        /// </summary>
        protected Query query;

        protected QueryDecorator(Query query)
        {
            QueryCleaner.INSTANCE.AddQueryDecorator(query, this);
            this.query = query;
        }

        /// <summary>
        /// Utility method used to add the parameter to the internal query
        /// </summary>
        /// <param name="extension">the string added to the internal query</param>
        protected void QueryExtension(string extension)
        {
            query.internalQuery += extension;
        }

        /// <summary>
        /// Utility method used to eliminate the last character from the internal query
        /// </summary>
        protected void FormatQuery(int characterLength = 1)
        {
            string internalQuery = query.internalQuery;

            query.internalQuery = internalQuery.Substring(0, internalQuery.Length - characterLength);
        }
    }
}
