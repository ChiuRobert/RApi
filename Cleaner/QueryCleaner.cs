using ScotchBoardSQL.Decorator;
using System.Collections.Generic;

namespace ScotchBoardSQL.Cleaner
{
    /// <summary>
    /// Utility class that cleans the objects created after each query
    /// </summary>
    internal class QueryCleaner
    {
        private static QueryCleaner instance;

        private Dictionary<Query, List<QueryDecorator>> queryCollector = new Dictionary<Query, List<QueryDecorator>>();

        private QueryCleaner() { }

        internal static QueryCleaner INSTANCE
        {
            get
            {
                if (instance == null)
                {
                    instance = new QueryCleaner();
                }

                return instance;
            }
        }

        /// <summary>
        /// Add a query to the created query list
        /// </summary>
        /// <param name="query">query that's been created</param>
        internal void AddQuery(Query query)
        {
            if (!queryCollector.ContainsKey(query))
            {
                queryCollector.Add(query, new List<QueryDecorator>());
            }
        }
        
        /// <summary>
        /// Add a QueryDecorator object in the value list that belongs to the created query
        /// </summary>
        /// <param name="query">query that's been created</param>
        /// <param name="queryDecorator">query functionality</param>
        internal void AddQueryDecorator(Query query, QueryDecorator queryDecorator)
        {
            queryCollector[query].Add(queryDecorator);
        }

        /// <summary>
        /// Cleans the created query with its objects
        /// </summary>
        /// <param name="query">query that's been created</param>
        internal void CleanQuery(Query query)
        {
            List<QueryDecorator> queryDecorators;
            if (queryCollector.TryGetValue(query, out queryDecorators))
            {
                for (int i = 0; i < queryDecorators.Count; i++)
                {
                    queryDecorators[i] = null;
                }
                queryCollector[query].Clear();
            }
        }
    }
}
