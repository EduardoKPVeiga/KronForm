using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KronForm
{
    internal class KronSpeaker
    {
        public static void StartClient(TextBox _ip, TextBox _port, Label _sendData, string _msg)
        {
            byte[] bytes = new byte[1024];

            try
            {
                // Connect to a Remote server
                // Get Host IP Address that is used to establish a connection
                // If a host has multiple addresses, you will get a list of addresses

                IPHostEntry host = Dns.GetHostEntry("localhost");
                IPAddress ipAddress = IPAddress.Parse(_ip.Text);

                IPEndPoint remoteEP = new IPEndPoint(ipAddress, Convert.ToInt32(_port.Text));

                // Create a TCP/IP  socket.
                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.
                try
                {
                    // Connect to Remote EndPoint
                    sender.Connect(remoteEP);

                    _sendData.Text = "Sending data... " + "\n" + _msg;

                    // Encode the data string into a byte array.
                    byte[] msg = Encoding.ASCII.GetBytes(_msg);

                    // Send the data through the socket.
                    int bytesSent = sender.Send(msg);

                    // Receive the response from the remote device.
                    int bytesRec = sender.Receive(bytes);

                    // Release the socket.
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    MessageBox.Show("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    MessageBox.Show("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
