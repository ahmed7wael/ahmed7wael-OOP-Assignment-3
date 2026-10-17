namespace Generics.src
{
    public class Store<T> where T : class, IHasId
    {
        private readonly Dictionary<int, T> _items = new Dictionary<int, T>();
        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException(paramName: nameof(item), message: "Item cannot be null.");
            if (_items.ContainsKey(item.Id))
            {
                throw new InvalidOperationException($"An item with Id '{item.Id}' already exists in the store.");
            }

            _items.Add(item.Id, item);
        }
        public T? GetById(int id)
        {
            _items.TryGetValue(id, out T? item);
            return item;
        }

        public IReadOnlyCollection<T> GetAll()
        {
            return _items.Values;
        }

        public void Remove(int id)
        {
            _items.Remove(id);
        }
    }
}
