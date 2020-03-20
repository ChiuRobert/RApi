namespace ScotchBoardSQL
{
    /// <summary>
    /// Reprezentation of a query
    /// </summary>
    public interface IQuery
    {
        /// <summary>
        /// Creates an INSERT query
        /// </summary>
        /// <returns>IInsertQuery</returns>
        IInsertQuery Insert();

        /// <summary>
        /// Creates a SELECT query
        /// </summary>
        /// <returns>ISelectQuery</returns>
        ISelectQuery Select();

        /// <summary>
        /// Creates an UPDATE query
        /// </summary>
        /// <returns>IUpdateQuery</returns>
        IUpdateQuery Update();

        /// <summary>
        /// Creates a DELETE query
        /// </summary>
        /// <returns>IDeleteQuery</returns>
        IDeleteQuery Delete();
    }
}
