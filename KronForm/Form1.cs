using Socket_Cliente;

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

        private void ipCheck(TextBox tb)
        {
            int dotQuantity = 0;
            string ip_aux = tb.Text;
            string[] ip_numbers = new string[4] { "", "", "", "" };

            // size test
            if (ip_aux.Length < 7 || ip_aux.Length > 15) { ipErrorMsg(tb); return; }

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
                else { ipErrorMsg(tb); return; }
            }

            if (dotQuantity != 3) { ipErrorMsg(tb); return; }

            for (int i = 0; i < 4; i++)
            {
                // too many digits in each part
                if ((ip_numbers[i]).Length > 3) { ipErrorMsg(tb); return; }

                int ip_numberAux = 0;
                if (ip_numbers[i] != "")
                {
                    ip_numberAux = Convert.ToInt32(ip_numbers[i]);
                }

                // it has a part with 0 digits
                else { ipErrorMsg(tb); return; }

                if (ip_numberAux < 0 || ip_numberAux > 255) { ipErrorMsg(tb); return; }
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            ipCheck(txtbox_ip);
            ipCheck(txtbox_newIp);

            string msg = txtbox_newIp.Text + "*" + txtbox_port.Text;

            try
            {
                FTCliente.SendData(msg, txtbox_ip.Text, Convert.ToInt32(txtbox_port.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}