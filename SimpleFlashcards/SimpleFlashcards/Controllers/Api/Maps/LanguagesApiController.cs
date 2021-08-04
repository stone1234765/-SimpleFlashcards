﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleFlashcards.Data;
using SimpleFlashcards.Entities.Maps;
using SimpleFlashcards.Models.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFlashcards.Controllers.Api.Maps
{
    [Route("api/languages")]
    [ApiController]
    public class LanguagesApiController : ControllerBase
    {
        private ApplicationDbContext _context { get; set; }
        public LanguagesApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<CountryModel>> GetLanguages()
        {
            return ((await _context.Countries.ToListAsync()) ?? new List<Country>()).Select(country => new CountryModel(country));
        }
    }
}