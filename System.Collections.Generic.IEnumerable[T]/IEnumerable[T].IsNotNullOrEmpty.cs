// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using System.Linq;

public static partial class IEnumerableExtension
{
    /// <summary>
    ///     An IEnumerable&lt;T&gt; extension method that queries if a not null or is empty.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="collection">The collection to act on.</param>
    /// <returns>true if a not null or is t>, false if not.</returns>
    public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> collection)
    {
        return collection != null && collection.Any();
    }
}