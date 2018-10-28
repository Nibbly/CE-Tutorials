using GenericInterfaces.Models;
using System.Collections.Generic;

namespace GenericInterfaces
{

    interface IRepository<T, TKey>
    {
        IEnumerable<T> GetItems();

        T GetItem(TKey key);

        void AddItem(T newItem);

        void UpdateItem(TKey key, T item);

        void DeleteItem(T newItem);

        void UpdateItems(IEnumerable<T> updatedItems);

    }
}
