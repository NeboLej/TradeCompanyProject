﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCompany_BLL.Models
{
    public class ClientBaseModel
    {
        public string Name { get; set; }
        public string E_mail { get; set; }
        public string Phone { get; set; }
        public DateTime LastOrderDate { get; set; }
    }
}
