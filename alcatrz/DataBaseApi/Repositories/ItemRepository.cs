using DataBaseApi.Interfaces;
using MySql.Data.MySqlClient;
using SyncClassLibrary.Model;
using System.Collections.Generic;
using System.Configuration;

namespace DataBaseApi.Repositories
{
    public class ItemRepository : IRepository<BaseModel>
    {
        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLdb"].ConnectionString);
        public ItemRepository()
        {
        }
        public BaseModel GetItems(int d) { return new BaseModel(); }
        public IEnumerable<BaseModel> GetItemList() { return null; }
        public void Create(BaseModel bm) { }
        public void Update(BaseModel bm) { }
        public void Delete(int id) { }
        public void Save() { }
        public void Open()
        {
            con.Open();
        }
        public void Dispose()
        {
            con.Close();
            con.Dispose();
        }
    }
}