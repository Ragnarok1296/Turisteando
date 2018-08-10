using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
using System.Threading;

namespace Turistiando
{
    public class Ubicacion
    {
        private static Double latitud;
        private static Double longitud;

        public static double Latitud {
            get => latitud;
            set => latitud = value;
        }

        public static double Longitud {
            get => longitud;
            set => longitud = value;
        }

        public static Boolean GetLocationProperty()
        {

            Boolean operation = false;

            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

            Thread.Sleep(650);

            watcher.TryStart(true, TimeSpan.FromMilliseconds(150));

            Thread.Sleep(200);

            GeoCoordinate coord = watcher.Position.Location;

            if (!coord.IsUnknown)
            {
                Latitud = coord.Latitude;
                Longitud = coord.Longitude;
                operation = true;
            }

            return operation;

        }
    }
}
