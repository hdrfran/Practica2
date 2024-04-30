using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PagedList.Models;

namespace PagedList.Controllers
{
    public class AlbumController : Controller
    {
        private readonly HttpClient _httpClient;

        public AlbumController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/photos");
            if (response.IsSuccessStatusCode)
            {
                var contenido = await response.Content.ReadAsStringAsync();
                var datos = JsonConvert.DeserializeObject<List<Album>>(contenido);

                return View(datos);
            }
            else
            {
                return View("Error");
            }
            
        }
    }
}
