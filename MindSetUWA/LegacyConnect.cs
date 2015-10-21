﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;

namespace MindSetUWA
{
    public partial class MindSetConnection
    {
        // http://developer.neurosky.com/docs/lib/exe/fetch.php?media=app_notes:thinkgear_socket_protocol.pdf

        /// <summary>
        /// Opens a packet connnection to a legacy MindWave headset that uses 2.4Ghz RF dongle.
        /// This is compatible in Windows Phone however it requires a ThinkGear Connector installed on a target machine and connector only accepts local connection.
        /// Specify a hostname (eg. localhost) and port.
        /// </summary>
        public async void ThinkGearConnect(HostName hostname, string port)
        {
            StreamSocket socket = new StreamSocket();
            await socket.ConnectAsync(hostname, port);
            byte[] buffer = new byte[8192];

            DataReader reader = new DataReader(socket.InputStream);
            DataWriter writer = new DataWriter(socket.OutputStream);

            //Switch ThinkGear Connector to JSON format.
            byte[] myWriteBuffer = Encoding.ASCII.GetBytes(@"{""enableRawOutput"": false, ""format"": ""Json""}");
            writer.WriteBytes(myWriteBuffer);
            await writer.StoreAsync();

            //Continuously recieve stream of JSON data.
            while (true)
            {
                string receivedData = "";
                reader.InputStreamOptions = InputStreamOptions.Partial;
                var count = await reader.LoadAsync(1024);
                if (count > 0)
                    receivedData = reader.ReadString(count);
                //ThinkGearDeserializer(receivedData); TODO NEW DESERIALIZER
            }
        }

    }
}
