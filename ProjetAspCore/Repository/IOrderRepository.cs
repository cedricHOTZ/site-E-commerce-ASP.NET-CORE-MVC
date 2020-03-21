using ProjetAspCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAspCore.Repository
{
  public  interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
