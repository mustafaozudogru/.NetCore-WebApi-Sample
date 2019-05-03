using Business.Interfaces;
using Core.Interfaces;
using Core.Service;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Orders> _repository;

        public OrderService(IRepository<Orders> repository)
        {
            _repository = repository;
        }

        public Response<Orders> DeleteById(int id)
        {
            var response = new Response<Orders>(null);
            try
            {
                _repository.DeleteById(id);
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                //Log here
                response.IsSuccessful = false;
            }
            return response;
        }

        public Response<Orders> GetById(int id)
        {
            var response = new Response<Orders>(null);
            try
            {
                response.Entity = _repository.GetById(id);
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                //Log here
                response.Entity = null;
                response.IsSuccessful = false;
            }

            return response;
        }

        public Response<Orders> Insert(Orders model)
        {
            var response = new Response<Orders>(null);
            try
            {
                response.Entity = _repository.Insert(model);
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                //Log here
                response.Entity = null;
                response.IsSuccessful = false;
            }

            return response;
        }

        public Response<Orders> Update(Orders model)
        {
            var response = new Response<Orders>(null);
            try
            {
                response.Entity = _repository.Update(model);
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                //Log here
                response.Entity = null;
                response.IsSuccessful = false;
            }

            return response;
        }
    }
}
