using ScotchBoardSQL.Cleaner;
using ScotchBoardSQL.Decorator;

namespace ScotchBoardSQL
{
    /// <summary>
    /// Reprezentation of a query
    /// </summary>
    public class Query : IQuery
    {
        /// <summary>
        /// String reprezentation of the query
        /// </summary>
        internal string internalQuery;

        /// <summary>
        /// Name of the table the query will manipulate
        /// </summary>
        internal string table;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table">Name of the table the query will be made upon</param>
        public Query(string table)
        {
            QueryCleaner.INSTANCE.AddQuery(this);
            this.table = table;
        }

        /// <summary>
        /// Creates a DELETE query
        /// </summary>
        /// <returns>IDeleteQuery</returns>
        public IDeleteQuery Delete()
        {
            return new DeleteQuery(this);
        }

        /// <summary>
        /// Creates an INSERT query
        /// </summary>
        /// <returns>IInsertQuery</returns>
        public IInsertQuery Insert()
        {
            return new InsertQuery(this);
        }

        /// <summary>
        /// Creates a SELECT query
        /// </summary>
        /// <returns>ISelectQuery</returns>
        public ISelectQuery Select()
        {
            return new SelectQuery(this);
        }

        /// <summary>
        /// Creates an UPDATE query
        /// </summary>
        /// <returns>IUpdateQuery</returns>
        public IUpdateQuery Update()
        {
            return new UpdateQuery(this);
        }
    }
}
