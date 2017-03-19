using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductsController : ApiController
    {

        DevTestData[] products = new DevTestData[] {
                new DevTestData() {
                    Id = 1,
                    Name = "Jaytamit",
                    Description = "Integer non turpis vitae orci tincidunt ullamcorper id pretium lectus.",
                    Price = 45.8655m,
                    CurrencyCode = DevTestData.Currency.NZD,
                    UnitsAvailable = 5,
                    DefaultSort = 2,
                },
                new DevTestData() {
                    Id = 2,
                    Name = "Canlux",
                    Description = "Aenean interdum dapibus enim, vel pulvinar eros pharetra nec",
                    Price = 23.5874m,
                    CurrencyCode = DevTestData.Currency.NZD,
                    UnitsAvailable = 0,
                    DefaultSort = 4
                },
                new DevTestData() {
                    Id = 3,
                    Name = "Sunkix",
                    Description = "Pellentesque nisi leo, laoreet vel ex eu, ultricies pharetra ligula.",
                    Price = 14.2565m,
                    CurrencyCode = DevTestData.Currency.AUD,
                    UnitsAvailable = 7,
                    DefaultSort = 1
                },
                new DevTestData() {
                    Id = 4,
                    Name = "Kay-Lex",
                    Description = "Ut tempus tempor mi, in volutpat lorem varius a.",
                    Price = 26.5862m,
                    CurrencyCode = DevTestData.Currency.NZD,
                    UnitsAvailable = 2,
                    DefaultSort = 3
                },
                new DevTestData() {
                    Id = 5,
                    Name = "Zamstring",
                    Description = "Proin finibus leo nulla, in elementum erat suscipit non.",
                    Price = 56.2518m,
                    CurrencyCode = DevTestData.Currency.USD,
                    UnitsAvailable = 0,
                    DefaultSort = 5
                }
            };

        public IEnumerable<DevTestData> GetAllProducts() {
            return products.OrderBy(a => a.DefaultSort);
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.Where(a => a.Id == id).FirstOrDefault();
            if (product == null)
                return NotFound();
            return Ok(product);
        }

    }
}
