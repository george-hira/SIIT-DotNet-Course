﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStore.Data;
using MyStore.Domain;
using MyStore.Helpers;
using MyStore.Models;
using MyStore.Services;

namespace MyStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController:ControllerBase
    {
        private readonly ISupplierService supplierService;

        public SuppliersController(ISupplierService supplierService)
        {
            this.supplierService = supplierService;
        }

        [HttpGet]
        public IEnumerable<SupplierModel> Get(string? text, int pag = 1) 
        {
            // var pageSize = 2;

            var allSuppliers = supplierService.GetSuppliers(pag, text);

            var modelsToReturn = new List<SupplierModel>();

            foreach(var supplier in allSuppliers)
            {
                modelsToReturn.Add(supplier.ToSupplierModel());
            }

            return modelsToReturn;

        }

        [HttpGet("{id}")]

        public ActionResult <SupplierModel>GetById(int id)
        {
            var supplierFromDb = supplierService.GetSupplier(id);

            if (supplierFromDb == null)
            {
                return NotFound();

            }

            var model = new SupplierModel();
            model = supplierFromDb.ToSupplierModel();

            return Ok(model);
        }

        [HttpPut("{id}")]

        public ActionResult<SupplierModel> Update(int id, SupplierModel model)
        {
            var existingSupplier = supplierService.GetSupplier(id);
            if (existingSupplier == null)
            {
                return NotFound();
            }

            TryUpdateModelAsync(existingSupplier);
            var supplierToUpdate = new Supplier();
            supplierToUpdate = model.ToSupplier();

            return Ok(supplierToUpdate.ToSupplierModel());

        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id) // babu
        {
            var supplier = supplierService.GetSupplier(id);

            if (supplier == null)
            {
                return NotFound();
            }

            supplierService.Remove(supplier);

            return NoContent();

        }

        [HttpPost]

        public IActionResult Create(SupplierModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (supplierService.IsDuplicate(model.Companyname))
            {
                ModelState.AddModelError("Companyname", $"You can't have the duplicate items with the values {model.Companyname} on Companyname.");
                return Conflict(ModelState);
            }

            var supplierToSave = new Supplier();

            supplierToSave = model.ToSupplier();

            supplierService.InsertNew(supplierToSave);

            model.Supplierid = supplierToSave.Supplierid;

            return CreatedAtAction(nameof(GetById), new { id = supplierToSave.Supplierid }, model);
        }



        

        
    }
}
