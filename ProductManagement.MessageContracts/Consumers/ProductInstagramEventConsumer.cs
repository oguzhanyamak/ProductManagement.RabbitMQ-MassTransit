﻿using MassTransit;
using ProductManagement.MessageContracts.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.MessageContracts.Consumers
{
    public class ProductInstagramEventConsumer : IConsumer<IProductEvent>
    {
        public async Task Consume(ConsumeContext<IProductEvent> context)
        {
            Console.WriteLine($"{context.Message.ProductName} isimli ürün Instagram'da yayınlanmıştır.");
        }
    }
}
