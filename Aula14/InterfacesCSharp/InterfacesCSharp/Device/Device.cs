﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesCSharp.Device
{
    abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);
    }
}
