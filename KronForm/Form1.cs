//using Socket_Cliente;

using static KronForm.KronSpeaker;
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

        private void ipErrorMsg(TextBox tb_error)
        {
            tb_error.Text = "";
            MessageBox.Show("type a valid IP in: " + tb_error.Name, "ERROR - IP adrees wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ipCheck(TextBox _tb, bool _newIp = false)
        {
            int dotQuantity = 0;
            string ip_aux = _tb.Text;
            string[] ip_numbers = new string[4] { "", "", "", "" };

            if (_newIp && _tb.Text == "") return true;

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

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            txt_receivedData.Visible = false;
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
            txtbox_ipM.Text = "";
            txtbox_portM.Text = "";
            txtbox_serialNumberD.Text = "";
            txtbox_ipD.Text = "";
            txtbox_newIpD.Text = "";
            txtbox_newPortD.Text = "";
            txt_sendData.Text = "";
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (confirm)
            {
                gp_data.Visible = true;
                string msg = "1*";
                StartClient(txtbox_ipM, txtbox_portM, txt_sendData, msg);
                string data = StartServer(Convert.ToInt32(txtbox_portM.Text));
                txt_receivedData.Text = data;
                txt_receivedData.Visible = true;
            }
            else
                MessageBox.Show("Send your data first - (click confirm).", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            txt_receivedData.Visible = false;
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