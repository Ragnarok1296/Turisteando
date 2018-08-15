using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Turistiando.Modelos
{
    class API
    {
        private WebRequest request;
        private WebResponse response;
        private Stream data;
        private StreamReader reader;

        private string key = "&key=AIzaSyB5oEd0b0RaZdrMujXhC4mVW4-m7fK6kJA";

        public Lugar obtenerLugares()
        {

            string url = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?";
            string location = "location=" + Ubicacion.Latitud + "," + Ubicacion.Longitud;
            string radius = "&radius=500";
            string types = "&types=point_of_interest";
            

            url = url + location + radius + types + key;

            request = WebRequest.Create(url);

            response = request.GetResponse();

            data = response.GetResponseStream();

            reader = new StreamReader(data);
            
            string json = reader.ReadToEnd();

            response.Close();

            return JsonConvert.DeserializeObject<Lugar>(json);
        }

        public Ruta obtenerRuta(string _latitud, string _longitud)
        {

            string url = "https://maps.googleapis.com/maps/api/directions/json?";
            string origin = "origin=" + Ubicacion.Latitud + "," + Ubicacion.Longitud;
            string destination = "&destination=" + _latitud + "," + _longitud;
            string mode = "&mode=walking";

            url = url + origin + destination + mode + key;

            request = WebRequest.Create(url);

            response = request.GetResponse();

            data = response.GetResponseStream();

            reader = new StreamReader(data);
            
            string json = reader.ReadToEnd();

            response.Close();

            return JsonConvert.DeserializeObject<Ruta>(json);
        }

        public string obtenerImagen(string _photoreference)
        {

            string url = "https://maps.googleapis.com/maps/api/place/photo?";
            string maxwidth = "maxwidth=400";
            string photoreference = "&photoreference=" + _photoreference;
            
            url = url + maxwidth + photoreference + key;

            
            return url;
        }


    }
}
