namespace ScotchBoardSQL.Decorator.Expressions
{
    /// <summary>
    /// Enables the query use of COLUMN 
    /// </summary>
    public class UpdateColumn : QueryDecorator
    {
        public UpdateColumn(string columnName, Query query) : base(query)
        {
            QueryExtension(columnName + " = ");
        }

        /// <summary>
        /// Enables the query use of VALUE 
        /// </summary>
        /// <param name="value">value</param>
        /// <returns>UpdateValue</returns>
        /// <seealso cref="Value(string)"/>
        public UpdateValue Value(double value)
        {
            return new UpdateValue(value, query);
        }

        /// <summary>
        /// Enables the query use of VALUE 
        /// </summary>
        /// <param name="value">value</param>
        /// <returns>UpdateValue</returns>
        /// <seealso cref="Value(double)"/>
        public UpdateValue Value(string value)
        {
            return new UpdateValue(value, query);
        }
    }
}
