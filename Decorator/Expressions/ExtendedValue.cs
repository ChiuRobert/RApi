using System;

namespace ScotchBoardSQL.Decorator.Expressions
{
    /// <summary>
    /// Enables the query use of ORDER BY 
    /// </summary>
    public class ExtendedValue : Value
    {
        public ExtendedValue(string value, Query query) : base(value, query)
        {
            QueryExtension(value);
            FormatQuery(value.Length);
        }

        public ExtendedValue(double value, Query query) : base(value, query)
        {
            QueryExtension(value.ToString());
            FormatQuery(value.ToString().Length);
        }

        /// <summary>
        /// Adds the AND keyword in the query
        /// </summary>
        /// <returns>Where</returns>
        public Where<ExtendedValue> And()
        {
            return new Where<ExtendedValue>(" AND ", query);
        }

        /// <summary>
        /// Adds the OR keyword in the query
        /// </summary>
        /// <returns>Where</returns>
        public Where<ExtendedValue> Or()
        {
            return new Where<ExtendedValue>(" OR ", query);
        }

        /// <summary>
        /// Enables the query use of ORDER BY 
        /// </summary>
        /// <param name="columnName">name of the column</param>
        /// <returns>Order</returns>
        public Order OrderBy(string columnName)
        {
            return new Order(columnName, query);
        }
    }
}
