﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCarApi.ViewModels
{

    public class UserVM
    {
        public string Name { get; set; }

        public string Email { get; set; }

    }

    public class UserLoginVM
    {
        [Required(ErrorMessage = "Поле не може бути пустим")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле не може бути пустим")]
        public string Password { get; set; }
    }

    public class UserRegisterVM
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
    public class UserUpdateVM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
    public class UserDeleteVM
    {
        public int Id { get; set; }
    }
}
