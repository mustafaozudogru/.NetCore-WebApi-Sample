using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Core.Interfaces;
using Core.Service;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderModelService _orderModelService;
        private readonly IOrderService _orderService;

        public OrderController(IOrderModelService orderModelService, IOrderService orderService)
        {
            _orderModelService = orderModelService;
            _orderService = orderService;
        }

        [HttpGet("GetOrderWithCount/{count}")]
        public Response<OrderModel> GetOrderWithCount(int count)
        {
            return _orderModelService.List(count);
        }

        [HttpGet("GetOrderById/{id}")]
        public Response<Orders> GetOrderById(int id)
        {
            return _orderService.GetById(id);
        }

        [HttpPost]
        public Response<Orders> AddOrder(Orders order)
        {
            return _orderService.Insert(order);
        }

        [HttpPut]
        public Response<Orders> UpdateOrder(Orders order)
        {
            return _orderService.Update(order);
        }

        [HttpDelete("{id}")]
        public Response<Orders> DeleteOrder(int id)
        {
            return _orderService.DeleteById(id);
        }

    }
}