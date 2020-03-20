using ScotchBoardSQL.Decorator.Expressions;

namespace ScotchBoardSQL
{
    /// <summary>
    /// Enables the use of UPDATE queries
    /// </summary>
    public interface IUpdateQuery
    {
        /// <summary>
        /// Enables the query use of COLUMN
        /// </summary>
        /// <param name="columnName">name of the column</param>
        /// <returns>UpdateColumn</returns>
        UpdateColumn Column(string columnName);
    }
}
