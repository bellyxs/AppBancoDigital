﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppBancoDigital.Model
{
    public class Operadora
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public override string ToString()
        {
            return this.Id + " " + this.Name;
        }
    }
}
