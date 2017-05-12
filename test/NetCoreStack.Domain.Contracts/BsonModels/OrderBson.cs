﻿using NetCoreStack.Contracts;
using System;
using System.Collections.Generic;

namespace NetCoreStack.Domain.Contracts.BsonModels
{
    [CollectionName("Orders")]
    public class Order
    {
        public DateTime PurchaseDate { get; set; }

        public IList<Album> Items;
    }
}
