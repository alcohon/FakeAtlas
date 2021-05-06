﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FakeAtlas
{
    public partial class Shipper
    {
        public Shipper()
        {
            UserOrders = new HashSet<UserOrder>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string VehicleType { get; set; }
        public int? VehicleNum { get; set; }

        public virtual ICollection<UserOrder> UserOrders { get; set; }
    }
}
