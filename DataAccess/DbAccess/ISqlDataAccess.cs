
namespace DataAccess.DbAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string StoredProcedure, U parameters, string ConnectionId = "Default");
        Task SaveData<T>(string StoredProcedure, T Parameters, string ConnectionId = "Default");
    }
}