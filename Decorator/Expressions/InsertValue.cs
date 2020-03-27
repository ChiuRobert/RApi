namespace ScotchBoardSQL.Decorator.Expressions
{
    /// <summary>
    /// Enables the query use of VALUE 
    /// </summary>
    public class InsertValue : QueryDecorator
    {
        public InsertValue(string value, Query query) : base(query)
        {
            if (!value.Equals(""))
            {
                QueryExtension("\"" + value + "\", ");
            }
        }

        public InsertValue(double value, Query query) : base(query)
        {
            QueryExtension("\"" + value + "\", ");
        }

        /// <summary>
        /// Enables the query use of VALUE 
        /// </summary>
        /// <param name="value">value</param>
        /// <returns>InsertValue</returns>
        /// <seealso cref="Value(string)"/>
        public InsertValue Value(double value)
        {
            return new InsertValue(value, query);
        }

        /// <summary>
        /// Enables the query use of VALUE 
        /// </summary>
        /// <param name="value">value</param>
        /// <returns>InsertValue</returns>
        /// <seealso cref="Value(double)"/>
        public InsertValue Value(string value)
        {
            return new InsertValue(value, query);
        }

        /// <summary>
        /// Formats the query for final changes
        /// </summary>
        /// <returns>formatted query</returns>
        public string Execute()
        {
            FormatQuery(2);
            QueryExtension(")");

            return new Execution(query).Execute();
        }
    }
}
