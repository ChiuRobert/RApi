﻿using ScotchBoardSQL.Decorator.Expressions;

namespace ScotchBoardSQL
{
    /// <summary>
    /// Enables the use of DELETE queries
    /// </summary>
    public interface IDeleteQuery
    {
        /// <summary>
        /// Adds the WHERE keyword in the query
        /// </summary>
        /// <returns>Where</returns>
        Where<Value> Where();
    }
}
