namespace ScotchBoardSQL.Decorator.Expressions
{
    /// <summary>
    /// Enables the query use of WHERE
    /// </summary>
    public class Where<T> : QueryDecorator where T : Value
    {
        public Where(Query query) : this(" WHERE ", query) { }

        public Where(string expression, Query query) : base(query)
        {
            QueryExtension(expression);
        }

        /// <summary>
        /// Enables the query use of COLUMN
        /// </summary>
        /// <param name="columnName">name of the column</param>
        /// <returns>Column</returns>
        public Column<T> Column(string columnName)
        {
            return new Column<T>(columnName, query);
        }
    }
}
