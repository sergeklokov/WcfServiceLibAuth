﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;

namespace WcfServiceLibAuth
{
    public class ServiceAuthentificator: UserNamePasswordValidator 
    {
        public override void Validate(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName))
                throw new ArgumentNullException("userName");

            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("password");

            if (userName!="test" || password != "test")
                throw new SecurityTokenException("Unknown username or password");

        }
    }
}
