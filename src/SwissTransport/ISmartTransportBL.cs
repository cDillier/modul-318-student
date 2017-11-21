using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransport
{
    public class ISmartTransportBL
    {
        /// <summary>
        /// Setzt und gibt das Start-/EndTime als string
        /// </summary>
        public string StartEndTime { get; set; }
        /// <summary>
        /// Setzt und gibt das Start-/EndStation als string
        /// </summary>
        public string StartEndStation { get; set; }
        /// <summary>
        /// Setzt und gibt die Dauer als string
        /// </summary>
        public string Duration { get; set; }
        /// <summary>
        /// Setzt und gibt das Gleis als string
        /// </summary>
        public string Rail { get; set; }
        /// <summary>
        /// Setzt und gibt die XCoordination der Startstation als double
        /// </summary>
        public double XCoordination { get; set; }
        /// <summary>
        /// Setzt und gibt die YCoordination der Startstation als double
        /// </summary>
        public double YCoordination { get; set; }
    }
}
