using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Timers;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1.ServerSocket
{
    public class ServerManger
    {
        const int MAX_PLAYER = 4;
        Form1 Form1;
        Socket ServerSocket;
        List<Socket> Client; // Store Client
        Thread ClientThread; // For Receive Client Message
        Thread Server_L_Thread; //For listening
        IPAddress ServerIP = myIP();

        private void ServerStart()
        {
            PEndPoint ipEP = new IPEndPoint(IPAddress.Parse(tbxServerIP.Text),
                                            int.Parse(tbxServerPort.Text));
            TcpListener server_Listener = new TcpListener(ipEP);
        }
        private string myIP()
        {
            string hn = Dns.GetHostName();
            IPAddress[] ipList = Dns.GetHostEntry(hn).AddressList;

            foreach (IPAddress ip in ipList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
    }
}
