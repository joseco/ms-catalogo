using Application.Dto;
using Application.Features.Articulo.CreateArticulo;
using Application.Features.Articulo.GetArticulos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticuloController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ArticuloController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateArticulo(CreateArticuloCommand command)
        {
            try
            {
                await _mediator.Send(command);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetArticulos()
        {
            try
            {
                ICollection<ArticuloDto> articulos = await _mediator.Send(new GetArticulosQuery());
                return Ok(articulos);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
