﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransport
{
    public class ISmartTransportBL
    {
        public string StartEndTime {private get; set; }
        public string StartEndStation { get; set; }
        public string Duration { get; set; }
        public string Rail { get; set; }
    }
}