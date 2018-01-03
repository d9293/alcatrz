using System;
using System.Collections.Generic;

namespace DataBaseApi.Interfaces
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        T GetItems(int id);
        IEnumerable<T> GetItemList();
        void Create(T item); // создание объекта
        void Update(T item); // обновление объекта
        void Delete(int id); // удаление объекта по id
        void Save();  // сохранение изменений
    }
}
