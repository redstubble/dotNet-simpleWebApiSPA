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

        DevTestData[] productArray = new DevTestData[] {
                new DevTestData() {
                    Id = 1,
                    Name = "Jaytamit",
                    Description = "Integer non turpis vitae orci tincidunt ullamcorper id pretium lectus.",
                    Price = 45.8655m,
                    CurrencyCode = "NZD",
                    UnitsAvailable = 5,
                    DefaultSort = 2,
                },
                new DevTestData() {
                    Id = 2,
                    Name = "Canlux",
                    Description = "Aenean interdum dapibus enim, vel pulvinar eros pharetra nec",
                    Price = 23.5874m,
                    CurrencyCode = "NZD",
                    UnitsAvailable = 0,
                    DefaultSort = 4
                },
                new DevTestData() {
                    Id = 3,
                    Name = "Sunkix",
                    Description = "Pellentesque nisi leo, laoreet vel ex eu, ultricies pharetra ligula.",
                    Price = 14.2565m,
                    CurrencyCode = "AUD",
                    UnitsAvailable = 7,
                    DefaultSort = 1
                },
                new DevTestData() {
                    Id = 4,
                    Name = "Kay-Lex",
                    Description = "Ut tempus tempor mi, in volutpat lorem varius a.",
                    Price = 26.5862m,
                    CurrencyCode = "NZD",
                    UnitsAvailable = 2,
                    DefaultSort = 3
                },
                new DevTestData() {
                    Id = 5,
                    Name = "Zamstring",
                    Description = "Proin finibus leo nulla, in elementum erat suscipit non.",
                    Price = 56.2518m,
                    CurrencyCode = "USD",
                    UnitsAvailable = 0,
                    DefaultSort = 5
                }
            };

        [HttpGet]
        public IEnumerable<DevTestData> products() {

            //foreach (var product in productArray)
            //{
            //    product.CurrencyCode = ((DevTestData.Currency)product.CurrencyCode).ToString();
            //}



            return productArray.OrderBy(a => a.DefaultSort);
        }

        [HttpGet]
        public IHttpActionResult getProduct(int id)
        {
            var product = productArray.Where(a => a.Id == id).FirstOrDefault();
            if (product == null)
                return NotFound();
            return Ok(product);
        }

    }
}
