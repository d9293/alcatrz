using DataBaseApi.Controllers;
using DataBaseApi.Interfaces;
using SyncClassLibrary.Model;
using System.Collections.Generic;

namespace DataBaseApi.RepositoryStub
{
    public class SalesInfoRepositoryStub : BaseApiController, IRepository<SalesInfoModel>
    {
        public SalesInfoRepositoryStub()
        {
        }
        public SalesInfoModel GetItems(int d)
        {
            return (SalesInfoModel)DeserializeMock(typeof(SalesInfoModel), "SalesInfoMock");
        }
        public IEnumerable<SalesInfoModel> GetItemList()
        {
            return null;
        }
        public void Create(SalesInfoModel bm)
        {
        }
        public void Update(SalesInfoModel bm)
        {
        }
        public void Delete(int id)
        {
        }
        public void Save()
        {
        }
        public void Open()
        {
        }
        public void Dispose()
        {
        }
    }
}