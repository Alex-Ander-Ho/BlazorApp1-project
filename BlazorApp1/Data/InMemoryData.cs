
using BlazorApp1.ViewModels;

namespace BlazorApp1.Data
{
    public class InMemoryData(AppDBContext context) : IDataService
	{
		public void SaveUser(StudentDTO userInfo)
		{
			if (userInfo.Id == 0)
			{
				context.Students.Add(new() { Id = userInfo.Id, Name = userInfo.Name });
			}
			context.SaveChanges();
		}

		public IEnumerable<StudentDTO> GetUserInfo()
		{
			return context.Students.Select(x => new StudentDTO() { Id = x.Id, Name = x.Name });
		}
	}
}
