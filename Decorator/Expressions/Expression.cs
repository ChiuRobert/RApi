using System;

namespace ScotchBoardSQL.Decorator.Expressions
{
    /// <summary>
    /// Enables the query use of VALUE 
    /// </summary>
    public class Expression<T> : QueryDecorator where T : Value
    {
        public Expression(string expression, Query query) : base(query)
        {
            QueryExtension(expression);
        }

        /// <summary>
        /// Enables the query use of VALUE 
        /// </summary>
        /// <param name="value">value</param>
        /// <returns>T</returns>
        /// <seealso cref="Value(string)"/>
        public T Value(double value)
        {
            Type valueType = typeof(T);

            if (valueType == typeof(Value))
            {
                Value valueObject = new Value(value, query);

                return  (T)Convert.ChangeType(valueObject, typeof(T));
            }

            ExtendedValue extendedValueObject = new ExtendedValue(value, query);

            return (T)Convert.ChangeType(extendedValueObject, typeof(T));
        }

        /// <summary>
        /// Enables the query use of VALUE 
        /// </summary>
        /// <param name="value">value</param>
        /// <returns>T</returns>
        /// <seealso cref="Value(double)"/>
        public T Value(string value)
        {
            Type valueType = typeof(T);

            if (valueType == typeof(Value))
            {
                Value valueObject = new Value(value, query);

                return (T)Convert.ChangeType(valueObject, typeof(T));
            }

            ExtendedValue extendedValueObject = new ExtendedValue(value, query);

            return (T)Convert.ChangeType(extendedValueObject, typeof(T));
        }
    }
}
