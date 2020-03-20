using ScotchBoardSQL.Cleaner;

namespace ScotchBoardSQL.Decorator.Expressions
{
    /// <summary>
    /// Marks the query as execute ready
    /// </summary>
    public class Execution : QueryDecorator
    {
        public Execution(Query query) : base(query)
        {
            QueryExtension(";");
        }

        /// <summary>
        /// Formats the query for final changes
        /// </summary>
        /// <returns>formatted query</returns>
        public string Execute()
        {
            QueryCleaner.INSTANCE.CleanQuery(query);
            return query.internalQuery;
        }
    }
}
