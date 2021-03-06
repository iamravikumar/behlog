﻿using System;
using System.Threading.Tasks;
using Behlog.Shop.Services.Data;

namespace Behlog.Shop.Services.Contracts {

    public interface IOrderProductService {
        Task<CustomerBasketDto> OrderProductAsync(OrderSingleProductDto model);
        Task<CustomerInvoiceDto> CreateInvoiceAsync(OrderSingleProductDto model);
        Task CreateInvoiceAndPayAsync(Guid basketId);
    }
}
