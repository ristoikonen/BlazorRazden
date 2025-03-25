using BlazorRazden.App.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRazden.App.Data
{
    public class IndexService
    {
        // simulate HTTP GET from API
        public Task<IndexModel[]> GetToDoItemAsync(DateTime startDate)
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new IndexModel
            {
                DateCreated = startDate.AddDays(index),
                Description = (5000 + (index*6)).ToString() + " points.", 
                ID = new Guid(),
                IndexDate = startDate.AddDays(index).ToString("dddd"),
                IndexValue = (5000 + (index * 6)),

            }).ToArray());
        }
    }
}
