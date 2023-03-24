//using Socket_Cliente;

using System.Drawing;
using System.Windows.Forms.Design;
using static KronForm.KronSpeaker;
using static KronForm.Manager;
using static KronReader.KronListener;

namespace KronForm
{
    public partial class kronForm : Form
    {
        public bool confirm = false;

        public kronForm()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            confirm = true;
            if (ipCheck(txtbox_yIp) && ipCheck(txtbox_ipM) && ipCheck(txtbox_ipD) && ipCheck(txtbox_newIpD, true))
            {
                gp_data.Visible = true;
                string msg = txtbox_yIp.Text + "$" + txtbox_ipD.Text + "$" + txtbox_serialNumberD.Text + "$" + txtbox_newIpD.Text + "$" + txtbox_newPortD.Text + "*";
                StartClient(txtbox_ipM, txtbox_portM, txt_sendData, msg);
            }
            else
            {
                gp_data.Visible = false;
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_receivedData1.Visible = false;
            txtbox_ipM.Text = "";
            txtbox_portM.Text = "";
            txtbox_serialNumberD.Text = "";
            txtbox_ipD.Text = "";
            txtbox_newIpD.Text = "";
            txtbox_newPortD.Text = "";
            txt_sendData.Text = "";
            txt_receivedData1.Text = "";
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (confirm)
            {
                gp_data.Visible = true;
                txt_receivedData1.Visible = true;
                string msg = "1*";
                string data = "";
                string extractedData = "";
                var valores = new List<float>();

                StartClient(txtbox_ipM, txtbox_portM, txt_sendData, msg);
                txt_receivedData1.Text = "";

                while (extractedData != "end")
                {
                    data = StartServer(Convert.ToInt32(txtbox_portM.Text));
                    while (data.Length > 0)
                    {
                        receivedData(txt_receivedData1, ref data, ref extractedData, ref valores);
                    }
                }
                valores.Reverse();
                SerializeObjectToXMLFile(valores);
                txt_receivedData1.Text += "Data Lenght: " + valores.Count + "\n";
                Thread.Sleep(1000);
                txt_receivedData1.Text += "First item: " + valores[0] + "\n";
                Thread.Sleep(1000);
                txt_receivedData1.Text += "Disconnected";
            }
            else
                MessageBox.Show("Send your data first - (click confirm).", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            txt_receivedData1.Text = "";
            if (confirm)
            {
                gp_data.Visible = true;
                string msg = "0*";
                StartClient(txtbox_ipM, txtbox_portM, txt_sendData, msg);
            }
            else
                MessageBox.Show("Send your data first - (click confirm).", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}