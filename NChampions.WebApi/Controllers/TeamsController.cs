﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace NChampions.WebApi.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class TeamsController
    {
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            throw new NotImplementedException();
        }
    }
}
