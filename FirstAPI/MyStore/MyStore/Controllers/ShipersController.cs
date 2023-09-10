using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Security.Cryptography.Xml;

namespace MyStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipersController : ControllerBase
    {

        private readonly StoreContext context;

        public ShipersController(StoreContext context)
        {
            this.context = context;
        }

        [HttpGet]

        public List<Shipper> GetAll()
        {
            var allShippers = context.Shippers.ToList();
            return allShippers;
        }

        [HttpGet("{id}")]

        public Shipper? GetById(int id) 
        {
            var shipper = context.Shippers.Find(id);
            return shipper;
        }

        //[HttpGet]

        //public List<Shipper> OrderedList()
        //{
        //    var orderdList = context.Shippers.OrderBy(x => x.Companyname).ToList();
        //    return orderdList;
        //}


        [HttpPost]

        public void ADDNewShipper(Shipper x)
        {
            context.Shippers.Add(x);
            context.SaveChanges();
        }

        [HttpPut ("{id}")]

        public Shipper UpdateShipper(int id, Shipper x)
        {

            var shipperToUpdate = context.Shippers.Find(id);
            if (shipperToUpdate != null)
            {
                shipperToUpdate.Companyname = x.Companyname;
                context.SaveChanges();
            }
            return shipperToUpdate;
        }

        [HttpDelete("{id}")]

        public Shipper DeleteShipper(int id)
        {
            var shipperToDelete = context.Shippers.Find(id);

            if (shipperToDelete != null)
            {
                context.Shippers.Remove(shipperToDelete);
                context.SaveChanges();
            }
            return shipperToDelete;
        }








    }
}
