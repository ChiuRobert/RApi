using ScotchBoardSQL.Cleaner;

namespace ScotchBoardSQL.Decorator.Expressions
{
    /// <summary>
    /// Enables the query use of COLUMN 
    /// </summary>
    public class Column<T> : QueryDecorator where T : Value
    {
        public Column(string columnName, Query query) : base(query)
        {
            QueryExtension(columnName);
        }

        /// <summary>
        /// Adds higher sign in the query
        /// </summary>
        /// <returns>Expression</returns>
        public Expression<T> Higher()
        {
            return new Expression<T>(" > ", query);
        }

        /// <summary>
        /// Adds higher-equal sign in the query
        /// </summary>
        /// <returns>Expression</returns>
        public Expression<T> HigherEqual()
        {
            return new Expression<T>(" >= ", query);
        }

        /// <summary>
        /// Adds less sign in the query
        /// </summary>
        /// <returns>Expression</returns>
        public Expression<T> Less()
        {
            return new Expression<T>(" < ", query);
        }

        /// <summary>
        /// Adds less-equal sign in the query
        /// </summary>
        /// <returns>Expression</returns>
        public Expression<T> LessEqual()
        {
            return new Expression<T>(" <= ", query);
        }

        /// <summary>
        /// Adds equal sign in the query
        /// </summary>
        /// <returns>Expression</returns>
        public Expression<T> Equal()
        {
            return new Expression<T>(" = ", query);
        }
    }
}
