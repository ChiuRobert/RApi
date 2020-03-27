using ScotchBoardSQL.Decorator.Expressions;

namespace ScotchBoardSQL.Decorator
{
    /// <summary>
    /// Used in creating a DELETE query
    /// </summary>
    internal class DeleteQuery : QueryDecorator, IDeleteQuery
    {
        public DeleteQuery(Query query) : base(query)
        {
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
    }
}
