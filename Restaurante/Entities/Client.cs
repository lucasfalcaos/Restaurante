﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Entities
{
    internal class Client
    {

        public string name { get; set; }
        public string email { get; set; }

        public DateTime Date { get; set; }

        public Client() { }

        public Client(string name, string email, DateTime date)
        {
            this.name = name;
            this.email = email;
            Date = date;
        }
    }
}
