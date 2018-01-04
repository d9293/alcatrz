using DataBaseApi.Interfaces;
using MySql.Data.MySqlClient;
using SyncClassLibrary.Model;
using System.Collections.Generic;
using System.Configuration;

namespace DataBaseApi.Repositories
{
    public class SalesInfoRepository : IRepository<SalesInfoModel>
    {
        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLdb"].ConnectionString);
        public SalesInfoRepository()
        {
        }
        public SalesInfoModel GetItems(int d) { return new SalesInfoModel(); }
        public IEnumerable<SalesInfoModel> GetItemList() { return null; }
        public void Create(SalesInfoModel bm) { }
        public void Update(SalesInfoModel bm) { }
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