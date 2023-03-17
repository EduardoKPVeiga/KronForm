using Socket_Cliente;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace KronForm
{
    public partial class kronForm : Form
    {
        public kronForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ipErrorMsg(TextBox tb_error)
        {
            tb_error.Text = "";
            MessageBox.Show("type a valid IP in: " + tb_error.Name, "ERROR - IP adrees wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ipCheck(TextBox _tb)
        {
            int dotQuantity = 0;
            string ip_aux = _tb.Text;
            string[] ip_numbers = new string[4] { "", "", "", "" };

            // size test
            if (ip_aux.Length < 7 || ip_aux.Length > 15) { ipErrorMsg(_tb); return false; }

            foreach (char c in ip_aux)
            {
                // it has only numbers and dots
                if ((!Char.IsLetter(c)) || (".".CompareTo(Convert.ToString(c)) == 0))
                {
                    if (".".CompareTo(Convert.ToString(c)) == 0)
                    {
                        dotQuantity++;
                    }

                    else
                    {
                        ip_numbers[dotQuantity] += c;
                    }
                }

                // it has a letter
                else { ipErrorMsg(_tb); return false; }
            }

            if (dotQuantity != 3) { ipErrorMsg(_tb); return false; }

            for (int i = 0; i < 4; i++)
            {
                // too many digits in each part
                if ((ip_numbers[i]).Length > 3) { ipErrorMsg(_tb); return false; }

                int ip_numberAux = 0;
                if (ip_numbers[i] != "")
                {
                    ip_numberAux = Convert.ToInt32(ip_numbers[i]);
                }

                // it has a part with 0 digits
                else { ipErrorMsg(_tb); return false; }

                if (ip_numberAux < 0 || ip_numberAux > 255) { ipErrorMsg(_tb); return false; }
            }

            return true;
        }

        public static void StartClient(TextBox _ip, TextBox _port, Label _sendData, string _msg)
        {
            byte[] bytes = new byte[1024];

            try
            {
                // Connect to a Remote server
                // Get Host IP Address that is used to establish a connection
                // In this case, we get one IP address of localhost that is IP : 127.0.0.1
                // If a host has multiple addresses, you will get a list of addresses
                IPHostEntry host = Dns.GetHostEntry("localhost");
                //IPAddress ipAddress = IPAddress.Parse(_ip.Text);
                IPAddress ipAddress = host.AddressList[0];

                /*Byte[] _bytes = ipAddress.GetAddressBytes();
                for (int i = 0; i < bytes.Length; i++)
                {
                    Console.Write(bytes[i]);
                }*/

                IPEndPoint remoteEP = new IPEndPoint(ipAddress, Convert.ToInt32(_port.Text));

                // Create a TCP/IP  socket.
                Socket sender = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.
                try
                {
                    // Connect to Remote EndPoint
                    sender.Connect(remoteEP);

                    //Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());

                    //_sendData.Text = "Sending data... " + "\n" + _msg;

                    // Encode the data string into a byte array.
                    byte[] msg = Encoding.ASCII.GetBytes(_msg);
                    
                    // Send the data through the socket.
                    int bytesSent = sender.Send(msg);

                    // Receive the response from the remote device.
                    int bytesRec = sender.Receive(bytes);
                    //Console.WriteLine("Echoed test = {0}", Encoding.ASCII.GetString(bytes, 0, bytesRec));

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

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (ipCheck(txtbox_ip) && ipCheck(txtbox_newIp))
            {
                gp_data.Visible = true;
                string msg = txtbox_newIp.Text + "*";
                txt_sendData.Text = "Sending data... " + "\n" + msg;
                StartClient(txtbox_ip, txtbox_port, txt_sendData, msg);
            }
            else
            {
                gp_data.Visible = false;
            }
        }
    }
}