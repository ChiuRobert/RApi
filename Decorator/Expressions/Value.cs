namespace ScotchBoardSQL.Decorator.Expressions
{
    /// <summary>
    /// Enables the query use of logical operators 
    /// </summary>
    public class Value : QueryDecorator
    {
        public Value(string value, Query query) : base(value, query)
        {
            QueryExtension(value);
        }

        public Value(double value, Query query) : base(value.ToString(), query)
        {
            QueryExtension(value.ToString());
        }

        /// <summary>
        /// Adds the AND keyword in the query
        /// </summary>
        /// <returns>Where</returns>
        public Where<Value> And()
        {
            return new Where<Value>(" AND ", query);
        }

        /// <summary>
        /// Adds the OR keyword in the query
        /// </summary>
        /// <returns>Where</returns>
        public Where<Value> Or()
        {
            return new Where<Value>(" OR ", query);
        }

        /// <summary>
        /// Formats the query for final changes
        /// </summary>
        /// <returns>formatted query</returns>
        public string Execute()
        {
            return new Execution(query).Execute();
        }
    }
}
