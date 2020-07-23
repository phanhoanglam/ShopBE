using MyProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Application.Services.Users.Dto
{
    public class AuthenticateResponse
    {
        public string AccessToken { get; set; }

        public string UserName { get; set; }
    }
}
