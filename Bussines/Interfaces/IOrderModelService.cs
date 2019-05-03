using Core.Service;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IOrderModelService
    {
        Response<OrderModel> List(int count);
    }
}
