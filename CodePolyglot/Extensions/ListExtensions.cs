using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodePolyglot.Extensions
{
    /// <summary>
    /// Helper methods for working with Lists
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        /// Partitions a list into a list of groupings of the specified size
        /// </summary>
        /// <typeparam name="T">Type of the List</typeparam>
        /// <param name="source">List being partitioned</param>
        /// <param name="size">Size of the individual partitions</param>
        /// <returns>An IEnumerable of IGroupings each of the specified size</returns>
        public static IEnumerable<IGrouping<int, T>> Partition<T>(this IList<T> source, int size)
        {
            if (source == null)
            {
                return new List<IGrouping<int, T>>();
            }

            return source.Select((i, index) => new
            {
                i,
                index
            }).GroupBy(group => group.index / size, element => element.i);
        }
    }
}
