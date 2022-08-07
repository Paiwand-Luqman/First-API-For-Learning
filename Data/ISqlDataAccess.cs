namespace FirstAPI.Data;

public interface ISqlDataAccess
{
    public Task<IEnumerable<T>> select_all<T, U>(string StoredProcedure, U Parameters);

    public Task<IEnumerable<T>> GetGrid<T, U>(string StoredProcedure, U Parameters);

    public Task<T> InsertUser<T, U>(string StoredProcedure, U Parameters);

    public Task<T> Update<T, U>(string StoredProcedure, U Parameters);

    public Task<T> Get<T, U>(string StoredProcedure, U Parameters);

    public Task<IEnumerable<T>> GetAutoComplete<T, U>(string StoredProcedure, U Parameters);

}