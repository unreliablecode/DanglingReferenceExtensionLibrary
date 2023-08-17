using System;
using System.Collections.Generic;

namespace DanglingReferenceExtensionLibrary
{
    public static class CollectionExtensions
    {
        // List extension
        public static void RemoveDanglingReferences<T>(this List<T> list, Func<T, bool> isDangling)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (isDangling(list[i]))
                {
                    list.RemoveAt(i);
                }
            }
        }

        // Array extension
        public static T[] RemoveDanglingReferences<T>(this T[] array, Func<T, bool> isDangling)
        {
            List<T> resultList = new List<T>();
            foreach (T item in array)
            {
                if (!isDangling(item))
                {
                    resultList.Add(item);
                }
            }
            return resultList.ToArray();
        }

        // Dictionary extension
        public static void RemoveDanglingReferences<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, Func<TValue, bool> isDangling)
        {
            List<TKey> keysToRemove = new List<TKey>();
            foreach (var kvp in dictionary)
            {
                if (isDangling(kvp.Value))
                {
                    keysToRemove.Add(kvp.Key);
                }
            }
            foreach (var key in keysToRemove)
            {
                dictionary.Remove(key);
            }
        }
    }
}
