namespace ScotchBoardSQL.Decorator.Expressions
{
    /// <summary>
    /// Enables the query use of VALUE 
    /// </summary>
    public class UpdateValue : QueryDecorator
    {
        public UpdateValue(string value, Query query) : base(query)
        {
            QueryExtension(value + ", ");
        }

        public UpdateValue(double value, Query query) : base(query)
        {
            QueryExtension(value + ", ");
        }

        /// <summary>
        /// Adds the WHERE keyword in the query
        /// </summary>
        /// <returns>Where</returns>
        public Where<Value> Where()
        {
            FormatQuery(2);
            return new Where<Value>(query);
        }

        /// <summary>
        /// Enables the query use of COLUMN 
        /// </summary>
        /// <returns>UpdateColumn</returns>
        public UpdateColumn Column(string columnName)
        {
            return new UpdateColumn(columnName, query);
        }
    }
}
