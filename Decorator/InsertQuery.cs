using ScotchBoardSQL.Decorator.Expressions;

namespace ScotchBoardSQL.Decorator
{
    /// <summary>
    /// Enables the use of INSERT queries
    /// </summary>
    internal class InsertQuery : QueryDecorator, IInsertQuery
    {
        public InsertQuery(Query query) : base(query)
        {
            QueryExtension("INSERT INTO " + query.table + " (");
        }

        /// <summary>
        /// Enables the query use of COLUMN 
        /// </summary>
        /// <returns>InsertColumn</returns>
        public InsertColumn Column(string columnName)
        {
            return new InsertColumn(columnName, query);
        }
    }
}