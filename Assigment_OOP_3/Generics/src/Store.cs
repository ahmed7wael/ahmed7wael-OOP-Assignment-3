namespace Generics.src
{
    public class Store<T> where T : class
    {
        private readonly List<T> _items = new List<T>();
        public void Add(T item)
        {
            _items.Add(item);
        }
        public T? GetById(int id)
        {
            foreach (var item in _items)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }

        public void Remove(T item)
        {
            var student = GetById(item.Id);
            if (student != null)
            {
                _items.Remove(student);
            }
        }
    }
}
