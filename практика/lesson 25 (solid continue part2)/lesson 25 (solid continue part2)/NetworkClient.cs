using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_25__solid_continue_part2_
{
    public sealed class NetworkClient
    {
        private readonly ConnectionManager _connectionManager;

        private readonly string _url;

        public NetworkClient(string url)
        {
            _connectionManager = new ConnectionManager();
            _url = url;
        }

        public void Send(object content)
        {
            _connectionManager.Connect(_url);

            DataTransfer dataTransfer = new();
            dataTransfer.Send(content.ToString());

            _connectionManager.Disconnect();
        }
    }
}
//TODO обобщения