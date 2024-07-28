using BlazorApp1.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace BlazorApp1.Data
{
    public interface IDataService
    {
        IEnumerable<StudentDTO> GetUserInfo();
        void SaveUser(StudentDTO userInfo);
    }
}
