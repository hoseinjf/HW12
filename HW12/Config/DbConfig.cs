﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.Config
{
    public static class DbConfig
    {
        public static string ConnectionString { get; set; }
        static DbConfig()
        {
            ConnectionString = @"Server=DESKTOP-1MKPIBC;Database=ToDo;Integrated Security=True;TrustServerCertificate=True;";
        }
    }
}
