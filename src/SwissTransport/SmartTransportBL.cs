using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;

namespace SwissTransport
{
    public class SmartTransportBL
    {
        Transport t = new Transport();
        public List<ISmartTransportBL>GetTimeTableData()
        {
            List<ISmartTransportBL> timeTable = new List<ISmartTransportBL>();
            List<Connection> cList = t.GetConnections("Sursee", "Luzern").ConnectionList;
            foreach (Connection c in cList)
            {
                ISmartTransportBL currentData = new ISmartTransportBL();
                currentData.StartEndStation = c.From.Station.Name + " --> " + c.To.Station.Name;
                currentData.StartEndTime = GetDateTimeFormat(c.From.Departure,"HH:mm") + " - "+ GetDateTimeFormat(c.To.Arrival, "HH:mm");
                currentData.Duration = GetTime(c.Duration.Split('d')[1]);
                currentData.Rail = c.From.Platform;
                timeTable.Add(currentData);
            }
            return timeTable;
        }

        public void GetAllStations()
        {
            t.GetStations("s");
        }

        #region Private Methode
        /// <summary>
        /// Gibt das Datum im angegebenen Format als Datetime aus
        /// </summary>
        /// <param name="dateTime">Welches Datum soll formatiert werden</param>
        /// <param name="pattern">Welches Format</param>
        /// <returns></returns>
        private string GetDateTimeFormat(string dateTime,string pattern)
        {
            DateTime parsedDate;
            string result = "";
             DateTime.TryParse(dateTime, out parsedDate);
            result = parsedDate.ToString(pattern);
            return result;
        }
        /// <summary>
        /// Gibt die Zeit des Datums zurück in Stunden und Minuten (xx h xx min)
        /// </summary>
        /// <param name="dateTime">Welches Datum soll formatiert werden</param>
        /// <returns></returns>
        private string GetTime(string dateTime)
        {
            DateTime parsedDate;
            string result = "";
            DateTime.TryParse(dateTime, out parsedDate);
            if (parsedDate.Hour != 0) result = parsedDate.Hour + " h ";
            if (parsedDate.Minute != 0) result += " "+ parsedDate.Minute + " min";
            return result;
        }
        #endregion
    }
}
