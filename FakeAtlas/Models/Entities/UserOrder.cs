﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FakeAtlas
{
    public partial class UserOrder
    {
        public int Id { get; set; }
        public int? AvailableOrdersId { get; set; }
        public int? ClientId { get; set; }
        public int? ShipperId { get; set; }
        public DateTime? OrderTime { get; set; }

        public virtual AvailableOrder AvailableOrders { get; set; }
        public virtual BookingUser Client { get; set; }
        public virtual Shipper Shipper { get; set; }
    }
}
