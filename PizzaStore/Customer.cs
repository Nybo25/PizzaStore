﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Customer
    { 
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return $"Customer Name: {Name}, Address: {Address}";
        }
    }


