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
        public List<ISmartTransportBL>GetTimeTableData(string fromStation,string toStation,DateTime dateTime)
        {
            List<ISmartTransportBL> timeTable = new List<ISmartTransportBL>();
            foreach (Connection c in t.GetConnections(fromStation, toStation,dateTime.ToString()).ConnectionList)
            {
                ISmartTransportBL currentData = new ISmartTransportBL();
                currentData.StartEndStation = c.From.Station.Name + " --> " + c.To.Station.Name;
                currentData.StartEndTime = GetDateTimeFormat(c.From.Departure,"HH:mm") + " - "+ GetDateTimeFormat(c.To.Arrival, "HH:mm");
                currentData.Duration = GetTime(c.Duration.Split('d')[1]);
                currentData.Rail = c.From.Platform;
                currentData.XCoordination = c.From.Station.Coordinate.XCoordinate;
                currentData.YCoordination = c.From.Station.Coordinate.YCoordinate;
                timeTable.Add(currentData);
            }
            return timeTable;
        }

        public List<ISmartTransportBL> GetStationBoard(string station)
        {
            List<Station> stationList = t.GetStations(station).StationList;
            List<ISmartTransportBL> stationTable = new List<ISmartTransportBL>();
            if (stationList.Count != 0)
            {
                
                string id = stationList.Find(x => x != null && x.Name == station).Id;
                var test = t.GetStationBoard(station, id);
                foreach (var sb in t.GetStationBoard(station, id).Entries)
                {
                    ISmartTransportBL currentData = new ISmartTransportBL();
                    currentData.StartEndStation =station + " --> " + sb.Name;
                    currentData.StartEndTime = sb.Stop.Departure.ToString("HH:mm");
                    currentData.Rail = sb.Name;
                    stationTable.Add(currentData);
                }
                return stationTable;
            }
            return new List<ISmartTransportBL>();
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
