using Business.Interfaces;
using Core.Interfaces;
using Core.Service;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Services
{
    public class OrderModelService : IOrderModelService
    {
        #region Fields           
        private readonly IRepository<Orders> _orderRepository;
        #endregion

        #region Ctor

        public OrderModelService(IRepository<Orders> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        #endregion

        #region Methods
        public Response<OrderModel> List(int count)
        {
            var response = new Response<OrderModel>(null);

            try
            {
                var query = _orderRepository.IncludeMany(or => or.Customer, or => or.Employee).Take(count);
                var list = query.ToList();

                foreach (var order in list)
                {
                    var viewModel = new OrderModel
                    {
                        Id = order.OrderId,
                        ContactName = order.Customer.ContactName,
                        Country = order.Employee.Country,
                        City = order.Employee.City,
                        Region = order.Employee.Region,
                    };
                    response.List.Add(viewModel);
                    order.Customer.WriteLog();
                }
                response.IsSuccessful = true;
                response.Count = list.Count;
            }
            catch (Exception ex)
            {
                //Log here
                response.IsSuccessful = true;
            }

            return response;
        }

        #endregion
    }
}
