using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        public Stations GetStations(string query)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {

                try
                {
                    var message = new StreamReader(responseStream).ReadToEnd();
                    var stations = JsonConvert.DeserializeObject<Stations>(message, new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore });
                    return stations;
                }
                catch (WebException)
                {

                }
            }

            return new Stations();
        }

        public List<string> GetStationNames(string query)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {

                try
                {
                    var message = new StreamReader(responseStream).ReadToEnd();
                    var stations = JsonConvert.DeserializeObject<Stations>(message, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

                    List<string> result = new List<string>();
                    foreach (Station s in stations.StationList.FindAll(x => x.Name.Contains(query)))
                    {
                        result.Add(s.Name);
                    }
                    return result;
                }
                catch (WebException)
                {

                }
            }

            return new List<string>();
        }

        public List<string> GetStationsString(string query)
        {
            //stations.StationList.Find(x => x.Name.Contains(""));
            List<string> result = new List<string>();
            
                foreach (Station s in GetStations(query).StationList)
                {
                    result.Add(s.Name);
                }
            return result;
        }

        public StationBoardRoot GetStationBoard(string station, string id)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?Station=" + station + "&id=" + id);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stationboard =
                    JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                return stationboard;
            }

            return new StationBoardRoot();
        }

        public Connections GetConnections(string fromStation, string toStation,string dateTime)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStation +"&datetime="+dateTime);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var connections =
                    JsonConvert.DeserializeObject<Connections>(readToEnd, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                return connections;
            }

            return null;
        }

        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;
            
            return request;
        }
    }
}
