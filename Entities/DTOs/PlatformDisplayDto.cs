﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class PlatformDisplayDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<GameDisplayDTO>? Games { get; set; }
    }
}
