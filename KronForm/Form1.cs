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
        private bool confirm = false;
        private static List<float> valores = new List<float>();

        public kronForm()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            disableAllBtn(btn_confirm, btn_clear, btn_connect, btn_disconnect, btn_saveData, btn_showData);

            receivedDataVisible(txt_receivedData1, btn_saveData, btn_showData, false);

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

            disableAllBtn(btn_confirm, btn_clear, btn_connect, btn_disconnect, btn_saveData, btn_showData, true);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            disableAllBtn(btn_confirm, btn_clear, btn_connect, btn_disconnect, btn_saveData, btn_showData);

            receivedDataVisible(txt_receivedData1, btn_saveData, btn_showData, false);
            txtbox_yIp.Text = "";
            txtbox_ipM.Text = "";
            txtbox_portM.Text = "";
            txtbox_serialNumberD.Text = "";
            txtbox_ipD.Text = "";
            txtbox_newIpD.Text = "";
            txtbox_newPortD.Text = "";
            txt_sendData.Text = "";
            txt_receivedData1.Text = "";

            disableAllBtn(btn_confirm, btn_clear, btn_connect, btn_disconnect, btn_saveData, btn_showData, true);
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            disableAllBtn(btn_confirm, btn_clear, btn_connect, btn_disconnect, btn_saveData, btn_showData);

            if (confirm)
            {
                clearListData(ref valores);
                gp_data.Visible = true;
                cleanReceivedData(ref valores, txt_receivedData1, btn_saveData, btn_showData, true);

                string msg = "1*";
                string data = "";
                string extractedData = "";

                StartClient(txtbox_ipM, txtbox_portM, txt_sendData, msg);

                while (extractedData != "end")
                {
                    data = StartServer(Convert.ToInt32(txtbox_portM.Text));
                    while (data.Length > 0)
                    {
                        receivedData(txt_receivedData1, ref data, ref extractedData, ref valores);
                    }
                }
                valores.Reverse();
                if(valores.Count > 0)
                {
                    Thread.Sleep(500);
                    txt_receivedData1.Text += "Data Lenght: " + valores.Count + "\n";
                    txt_receivedData1.Text += "First item: " + valores[0] + "\n";
                    Thread.Sleep(500);
                    txt_receivedData1.Text += "Disconnected";
                    disableAllBtn(btn_confirm, btn_clear, btn_connect, btn_disconnect, btn_saveData, btn_showData, true);
                }
                else
                {
                    txt_receivedData1.Text = "Error\nvalores null!";
                    disableAllBtn(btn_confirm, btn_clear, btn_connect, btn_disconnect, btn_saveData, btn_showData, true);
                    btn_saveData.Enabled = false;
                    btn_showData.Enabled = false;
                }
            }
            else
                MessageBox.Show("Send your data first - (click confirm).", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            clearListData(ref valores);
            disableAllBtn(btn_confirm, btn_clear, btn_connect, btn_disconnect, btn_saveData, btn_showData);

            cleanReceivedData(ref valores, txt_receivedData1, btn_saveData, btn_showData);
            if (confirm)
            {
                gp_data.Visible = true;
                string msg = "0*";
                StartClient(txtbox_ipM, txtbox_portM, txt_sendData, msg);
            }
            else
                MessageBox.Show("Send your data first - (click confirm).", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            disableAllBtn(btn_confirm, btn_clear, btn_connect, btn_disconnect, btn_saveData, btn_showData, true);
        }

        private void btn_showData_Click(object sender, EventArgs e)
        {
            disableAllBtn(btn_confirm, btn_clear, btn_connect, btn_disconnect, btn_saveData, btn_showData);

            ShowData f2 = new ShowData(valores);
            f2.ShowDialog();

            disableAllBtn(btn_confirm, btn_clear, btn_connect, btn_disconnect, btn_saveData, btn_showData, true);
        }

        private void btn_saveData_Click(object sender, EventArgs e)
        {
            disableAllBtn(btn_confirm, btn_clear, btn_connect, btn_disconnect, btn_saveData, btn_showData);

            SerializeObjectToXMLFile(valores);

            disableAllBtn(btn_confirm, btn_clear, btn_connect, btn_disconnect, btn_saveData, btn_showData, true);
        }
    }
}