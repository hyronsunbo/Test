using BookApi.Models;
using Newtonsoft.Json;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Mvc;
namespace BookApi.Controllers
{
    public class BookController : ApiController
    {
        private BookDBContext db = new BookDBContext();

        // GET: api/v1/Book/GetBooks
        public string GetBooks()
        {
            var date = db.Book.ToList();
            var test = date;
            HttpResponseMessage response = new HttpResponseMessage();
            string jsonString = JsonConvert.SerializeObject(date);
            return jsonString;
        }
    }
}