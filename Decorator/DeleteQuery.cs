using ScotchBoardSQL.Decorator.Expressions;

namespace ScotchBoardSQL.Decorator
{
    /// <summary>
    /// Used in creating a DELETE query
    /// </summary>
    internal class DeleteQuery : QueryDecorator, IDeleteQuery
    {
        private readonly string internalDeleteQuery;
        
        public DeleteQuery(Query query) : base(query)
        {
            internalDeleteQuery = query.internalQuery + ("DELETE FROM " + query.table + ";");
            QueryExtension("DELETE FROM \"" + query.schema + "\".\"" + query.table + "\"");
        }

        /// <summary>
        /// Adds the WHERE keyword in the query
        /// </summary>
        /// <returns>Where</returns>
        public Where<Value> Where()
        {
            return new Where<Value>(query);
        }

        /// <summary>
        /// Formats the query for final changes
        /// </summary>
        /// <returns>formatted query</returns>
        public string Execute()
        {
            return internalDeleteQuery;
        }
    }
}
