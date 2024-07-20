﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imagine.Business.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string message);
        string CreateHtmlMessage(string email, string message);
    }
}