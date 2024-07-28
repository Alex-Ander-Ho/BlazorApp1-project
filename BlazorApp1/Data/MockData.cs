
using BlazorApp1.ViewModels;

namespace BlazorApp1.Data
{
    public class MockData : IDataService
    {
		public void SaveUser(StudentDTO userInfo)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<StudentDTO> GetUserInfo()
        {
            return [
                new (){
                    Id = 1,
                    Name = "Test1",
                },
                new (){
                    Id = 2,
                    Name = "Test2",
                },
                new (){
                    Id = 3,
                    Name = "Test3",
                },

            ];
        }
    }

}
