﻿using MongoDB.Bson.Serialization.Attributes;
using NetCoreStack.Contracts;
using System.Collections.Generic;

namespace NetCoreStack.Domain.Contracts.BsonModels
{
    [BsonCollectionName("Customers")]
    public class Customer : EntityIdentityBson
    {
        [BsonElement("fname")]
        public string FirstName { get; set; }

        [BsonElement("lname")]
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public IList<Order> Orders { get; set; }
    }
}
