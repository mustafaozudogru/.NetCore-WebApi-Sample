using Core.Service;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IOrderService
    {
        Response<Orders> GetById(int id);
        Response<Orders> Insert(Orders model);
        Response<Orders> Update(Orders model);
        Response<Orders> DeleteById(int id);
    }
}
