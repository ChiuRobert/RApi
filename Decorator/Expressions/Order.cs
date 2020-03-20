namespace ScotchBoardSQL.Decorator.Expressions
{
    /// <summary>
    /// Enables the query use of ORDER BY 
    /// </summary>
    public class Order : QueryDecorator
    {
        public Order(Query query) : base(query)
        {
            QueryExtension(" ORDER BY ");
        }

        /// <summary>
        /// Adds the ASC keyword to the query
        /// </summary>
        /// <returns>Execution</returns>
        public Execution Asc()
        {
            QueryExtension("ASC");

            return new Execution(query);
        }

        /// <summary>
        /// Adds the DESC keyword to the query
        /// </summary>
        /// <returns>Execution</returns>
        public Execution Desc()
        {
            QueryExtension("DESC");

            return new Execution(query);
        }
    }
}
