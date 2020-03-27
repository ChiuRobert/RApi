using ScotchBoardSQL.Decorator.Expressions;

namespace ScotchBoardSQL.Decorator
{
    /// <summary>
    /// Used in creating a SELECT query
    /// </summary>
    internal class SelectQuery : QueryDecorator, ISelectQuery
    {
        public SelectQuery(Query query) : base(query)
        {
            QueryExtension("SELECT * FROM \"" + query.schema + "\".\"" + query.table + "\"");
        }

        /// <summary>
        /// Adds the WHERE keyword in the query
        /// </summary>
        /// <returns>Where</returns>
        public Where<ExtendedValue> Where()
        {
            return new Where<ExtendedValue>(query);
        }
    }
}
