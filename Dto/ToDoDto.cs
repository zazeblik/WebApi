﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dto
{
    public class ToDoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Done { get; set; }
    }
}
