﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacteraCloud.ViewModels
{
    public class SendEmailViewModel
    {
        public string Receiver { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }
    }
}
