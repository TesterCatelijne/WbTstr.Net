﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentAutomation.Interfaces
{
    public interface IRemoteWebDriverConfig : IWebDriverConfig
    {
        Uri DriverUri { get; }
    }
}
