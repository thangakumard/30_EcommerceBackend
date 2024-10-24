﻿using Orders.Domain.Entities;
using SharedLibrary;
using System.Linq.Expressions;

namespace Orders.Application.Interfaces
{
    public interface IOrder : IGenericInterface<Order>
    {
        Task<IEnumerable<Order>> GetOrderAsync(Expression<Func<Order, bool>> predicate);
    }
}
