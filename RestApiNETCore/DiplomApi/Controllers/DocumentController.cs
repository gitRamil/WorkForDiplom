﻿namespace DiplomApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Repositories.Interfaces;

    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentRepository _documentRepo;

        public DocumentController(IDocumentRepository employeeRepo)
        {
            _documentRepo = employeeRepo;
        }

        [HttpGet]
        [Route("{id}")]
        [EnableCors("MyPolicy")]
        public async Task<Document> GetByID(int id)
        {
            return await _documentRepo.GetByID(id);
        }

        [HttpGet]
        [EnableCors("MyPolicy")]
        public async Task<IEnumerable<Document>> GetAll (int id)
        {
            return await _documentRepo.GetAll();
        }

        [HttpPost]
        [EnableCors("MyPolicy")]
        public async Task Post(Document document)
        {
            await _documentRepo.AddDocument(document);
        }
    }
}