﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace WithOcp
{
    internal interface INotificationSystem
    {
        void SendNotification(string message);
    }
}
