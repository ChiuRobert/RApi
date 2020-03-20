namespace ScotchBoardSQL.Decorator.Expressions
{
    /// <summary>
    /// Enables the query use of COLUMN 
    /// </summary>
    public class InsertColumn : QueryDecorator
    {
        public InsertColumn(string columnName, Query query) : base(query)
        {
            QueryExtension(columnName + ", ");
        }

        /// <summary>
        /// Enables the query use of VALUES 
        /// </summary>
        /// <returns>InsertValue</returns>
        public InsertValue Values()
        {
            FormatQuery(2);
            QueryExtension(") VALUES (");

            return new InsertValue("", query);
        }

        /// <summary>
        /// Adds another column in the query
        /// </summary>
        /// <param name="columnName">name of the column</param>
        /// <returns>InsertColumn</returns>
        public InsertColumn Column(string columnName)
        {
            return new InsertColumn(columnName, query);
        }
    }
}
