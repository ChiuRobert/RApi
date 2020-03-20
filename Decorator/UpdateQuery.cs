using ScotchBoardSQL.Decorator.Expressions;

namespace ScotchBoardSQL.Decorator
{
    /// <summary>
    /// Used in creating a UPDATE query
    /// </summary>
    internal class UpdateQuery : QueryDecorator, IUpdateQuery
    {
        public UpdateQuery(Query query) : base(query)
        {
            QueryExtension("UPDATE " + query.table + " SET ");
        }

        /// <summary>
        /// Enables the query use of COLUMN
        /// </summary>
        /// <param name="columnName">name of the column</param>
        /// <returns>UpdateColumn</returns>
        public UpdateColumn Column(string columnName)
        {
            return new UpdateColumn(columnName, query);
        }
    }
}
