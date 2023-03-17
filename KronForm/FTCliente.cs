using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
namespace Socket_Cliente
{
    public class FTCliente
    {
        public static string mensagemCliente = "";
        public static void SendData(string _data = "", string _strEnderecoIP = "0.0.0.0", int _port = 5656)
        {
            try
            {
                string data = _data;
                string strEnderecoIP = _strEnderecoIP;
                
                IPEndPoint ipEnd_cliente = new IPEndPoint(IPAddress.Parse(strEnderecoIP), _port);
                Socket clientSock_cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                
                byte[] clientData = Encoding.UTF8.GetBytes(data);

                clientSock_cliente.Connect(ipEnd_cliente);
                clientSock_cliente.Send(clientData, 0, clientData.Length, 0);
                clientSock_cliente.Close();
            }

            catch (Exception ex)
            {
                mensagemCliente = ex.Message + "Falha, pois o Servidor não esta atendendo....";
            }
        }
    }
}
