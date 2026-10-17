using System.Runtime.CompilerServices;

namespace Generics.src
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int pageNumber, int pageSize)
        {
            if(source == null)
                throw new ArgumentNullException(nameof(source));
            if(pageNumber < 1)
                throw new ArgumentOutOfRangeException(nameof(pageNumber), "Page number must be a positive integer.");
            if(pageSize < 1)
                throw new ArgumentOutOfRangeException(nameof(pageSize), "Page size must be a positive integer.");

            int skipCount = (pageNumber - 1) * pageSize;
            int currentIndex = 0;
            int returnedCount = 0;

            foreach (var item in source)
            {
                if (currentIndex >= skipCount)
                {
                    if (returnedCount < pageSize)
                    {
                        yield return item;
                        returnedCount++;
                    }
                    else
                    {
                        break;
                    }
                }
                currentIndex++;
            }
        }

        public static T? FindById<T>(this IEnumerable<T> source, int id) 
            where T : class, IHasId
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            foreach(var item in source)
            {
                if(item != null && item.Id == id)
                    return item;
            } 
            return null;
        }

        public static Dictionary<int, T> ToIdDictionary<T>(this IEnumerable<T> source)
            where T : IHasId
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            var dictionary = new Dictionary<int, T>();
            foreach(var item in source)
            {
                if(item != null)
                {
                    dictionary[item.Id] = item;
                }
            }
            return dictionary;
        }
    }
    
}
