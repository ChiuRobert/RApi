using ScotchBoardSQL.Decorator.Expressions;

namespace ScotchBoardSQL
{
    /// <summary>
    /// Enables the use of SELECT queries
    /// </summary>
    public interface ISelectQuery
    {
        /// <summary>
        /// Adds the WHERE keyword in the query
        /// </summary>
        /// <returns>Where</returns>
        Where<ExtendedValue> Where(); 
    }
}
