using System;
using System.Collections.Generic;

namespace MyQuery.Logic
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<TResult> Map<T, TResult> (this IEnumerable<T> source, Func<T, TResult> mapping)
        {
            source.CheckArgument(nameof(source));
            mapping.CheckArgument(nameof(mapping));

            var result = new List<TResult>();

            foreach (var item in source)
            {
                result.Add(mapping(item));
            }
            return result;
        }
    }
}
