using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Stocks.Queries;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    //[Authorize]
    public class StocksController : BaseController
    {
        private IStockService _stockService;

        public StocksController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet("getall")]
        public async Task<ActionResult<ServiceResult<IEnumerable<StockViewModel>>>> GetAllStocks(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new GetAllStocksQuery(), cancellationToken));
        }
    }
}
