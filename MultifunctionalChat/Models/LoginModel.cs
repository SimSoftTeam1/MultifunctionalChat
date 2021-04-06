﻿using System.ComponentModel.DataAnnotations;

namespace MultifunctionalChat.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Не указан Login")]
        public string Login { get; set; }

        //Вход без пароля
        //[Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
