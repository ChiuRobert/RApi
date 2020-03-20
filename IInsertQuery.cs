using ScotchBoardSQL.Decorator.Expressions;

namespace ScotchBoardSQL
{
    /// <summary>
    /// Enables the use of INSERT queries
    /// </summary>
    public interface IInsertQuery
    {
        /// <summary>
        /// Enables the query use of COLUMN
        /// </summary>
        /// <param name="columnName">name of the column</param>
        /// <returns>InsertColumn</returns>
        InsertColumn Column(string columnName);
    }
}
