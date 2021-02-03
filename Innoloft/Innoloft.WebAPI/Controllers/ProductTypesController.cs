using AutoMapper;
using Innoloft.Core.DTOs;
using Innoloft.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Innoloft.WebAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ProductTypesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductTypesController(
            IUnitOfWork unitOfWork,
            IMapper mapper
            )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: api/types
        [HttpGet("types")]
        public async Task<IActionResult> GetProductTypes()
        {
            var products = await _unitOfWork.ProductTypes.GetAllAsync();
            var productsDto = _mapper.Map<IEnumerable<ProductTypeDetailDto>>(products);

            return Ok(productsDto);
        }
    }
}
