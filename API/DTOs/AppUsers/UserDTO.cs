﻿using API.DTOs.AppUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class UserDTO : AppUserDTOBase
    {
        public string Token { get; set; }
    }
}
