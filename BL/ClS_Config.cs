using FirstAPI.Data;
using System.Globalization;

namespace FirstAPI.BL;

public class ClS_Config
{
    private ISqlDataAccess _db { get; set; }

    public ClS_Config(ISqlDataAccess db)
    {
        _db = db;
       
    }
    public async Task<IEnumerable<T>> select_all<T>()
    {
        return await _db.select_all<T, dynamic>("select_all", new {});
    }
    //public async Task<IEnumerable<T>> GetGrid<T>(string Search = "", DateTime? DateSearch = null)
    //{
    //    return await _db.GetGrid<T, dynamic>("MemberList", new { Search = Search , DateSearch = DateSearch});
    //}
    //public async Task<IEnumerable<T>> GetGridSorted<T>(int? Sorter = 1, string firstName = "", string lastName = "", string phoneNumber = "", DateTime? dateOfBirth = null, decimal ballance = 0, byte[] img = null)
    //{
    //    return await _db.GetGrid<T, dynamic>("Get_All_ByParam", new { Sorter = Sorter, firstName = firstName, lastName = lastName, dateOfBirth = dateOfBirth, ballance = ballance, img = img});
    //}
    public async Task<T> InsertUser<T>(string firstName = "", string lastName = "", string phoneNumber = "", DateTime? dateOfBirth =null, decimal ballance=0, byte[] img = null )
    {
        return await _db.InsertUser<T, dynamic>("InsertUser", new { lastName = lastName, firstName = firstName, phoneNumber = phoneNumber, dateOfBirth = dateOfBirth, ballance = ballance, img = img });  
    }
    public async Task<T> Update<T>(int? EID = null,string firstName = "", string lastName = "", string phoneNumber = "", DateTime? dateOfBirth = null, decimal ballance = 0, byte[] img = null)
    {
        return await _db.Update<T, dynamic>("UpdateUser", new {EID = EID ,firstName = firstName, lastName = lastName, phoneNumber = phoneNumber, DateOfBirth = dateOfBirth, Ballance = ballance, img = img });
    }
    //public async Task<T> Get<T>(int? EID = null)
    //{
    //    return await _db.Get<T, dynamic>("Get_Current", new {EID = EID});
    //}


    //public async Task<UserManagmentComboBoxes> MultiSelect(int SelectPro = 0, int ValID = 0)
    //{
    //    return await _db.GetMultiSelect<dynamic>("Pro_GetCMB", new { Select = SelectPro, ID = ValID });
    //}



    public string CheckStringNull(string s)
    {
        return string.IsNullOrWhiteSpace(s) ? "" : s;
    }
   public string CheckDateTimeNull(DateTime? date)
    {
        return date.HasValue ? date.Value.ToString("yyyy-MM-dd",new CultureInfo("en-US")) : Convert.ToDateTime("1900-01-01",new CultureInfo("en-US")).ToString("yyyy-MM-dd");
    }
}
