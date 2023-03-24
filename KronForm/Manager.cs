using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KronForm
{
    internal class Manager
    {
        public static void ipErrorMsg(TextBox tb_error)
        {
            tb_error.Text = "";
            MessageBox.Show("type a valid IP in: " + tb_error.Name, "ERROR - IP adrees wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool ipCheck(TextBox _tb, bool _newIp = false)
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

        public static void receivedData(Label _txt_receivedData1, ref string _data, ref string _extractedData, ref List<float> _valores)
        {
            if (_data == "Connected")
            {
                _txt_receivedData1.Text += _data + "\n";
                _data = "";
                Thread.Sleep(1000);
            }
            else if (_data == "end")
            {
                _extractedData = _data;
                _data = "";
            }
            else
            {
                try
                {
                    _extractedData = "";
                    int index = _data.LastIndexOf("$");
                    if (index > 0)
                    {
                        for (int i = index + 1; i < _data.Length; i++)
                        {
                            _extractedData += _data[i];
                        }

                        for (int i = index + 1; i < _data.Length; i++)
                        {
                            _data = _data.Remove(i);
                        }

                        _data = _data.Remove(index);
                    }
                    else
                    {
                        _extractedData = _data;
                        _data = "";
                    }
                    if(_extractedData != "")
                        _valores.Add(float.Parse(_extractedData));

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void receivedDataVisible(Label _txt_receivedData1, Button _btn_saveData, Button _btn_showData, bool _visible)
        {
            _txt_receivedData1.Visible = _visible;
            _btn_saveData.Visible = _visible;
            _btn_showData.Visible = _visible;
        }

        public static void cleanReceivedData(ref List<float> _valores, Label _txt_receivedData1, Button _btn_saveData, Button _btn_showData, bool _visible = false)
        {
            _valores.Clear();
            _txt_receivedData1.Text = "";
            receivedDataVisible(_txt_receivedData1, _btn_saveData, _btn_showData, _visible);
        }

        public static void disableAllBtn(Button _btn_confirm, Button _btn_clear, Button _btn_connect, Button _btn_disconnect, Button _btn_saveData, Button _btn_showData, bool _enable = false)
        {
            _btn_confirm.Enabled = _enable;
            _btn_clear.Enabled = _enable;
            _btn_connect.Enabled = _enable;
            _btn_disconnect.Enabled = _enable;
            _btn_saveData.Enabled = _enable;
            _btn_showData.Enabled = _enable;
        }

        public static void clearListData(ref List<float> _valores)
        {
            for (int i = _valores.Count - 1; i >= 0; i++)
            {
                _valores.RemoveAt(i);
            }
        }

        public static void SerializeObjectToXMLFile(List<float> valores)
        {
            var dados = new Vars.KronVars
            {
                NS = valores[0],
                U0 = valores[1],
                U12 = valores[2],
                U23 = valores[3],
                U31 = valores[4],
                U1 = valores[5],
                U2 = valores[6],
                U3 = valores[7],
                I0 = valores[8],
                IN = valores[9],
                I1 = valores[10],
                I2 = valores[11],
                I3 = valores[12],
                F1 = valores[13],
                F2 = valores[14],
                F3 = valores[15],
                FIEC = valores[16],
                P0 = valores[17],
                P1 = valores[18],
                P2 = valores[19],
                P3 = valores[20],
                Q0 = valores[21],
                Q1 = valores[22],
                Q2 = valores[23],
                Q3 = valores[24],
                S0 = valores[25],
                S1 = valores[26],
                S2 = valores[27],
                S3 = valores[28],
                FP0 = valores[29],
                FP1 = valores[30],
                FP2 = valores[31],
                FP3 = valores[32],
                FP0D = valores[33],
                FP1D = valores[34],
                FP2D = valores[35],
                FP3D = valores[36],
                FD = valores[37],
                FK1 = valores[38],
                FK2 = valores[39],
                FK3 = valores[40],
                EDP1 = valores[41],
                EDP2 = valores[42],
                EDP3 = valores[43],
                EDP1S = valores[44],
                EDP2S = valores[45],
                EDP3S = valores[46],
                OUT1S = valores[47],
                OUT2S = valores[48],
                EDP1P = valores[49],
                EDP2P = valores[50],
                EDP3P = valores[51],
                LSTS = valores[52],
                HORIM = valores[53],
                EA = valores[54],
                ER = valores[55],
                EAN = valores[56],
                ERN = valores[57],
                MDA = valores[58],
                DA = valores[59],
                MDS = valores[60],
                DS = valores[61],
                EADp = valores[62],
                ERDp = valores[63],
                EADn = valores[64],
                ERDn = valores[65],
                THDU1 = valores[66],
                THDU2 = valores[67],
                THDU3 = valores[68],
                THDI1 = valores[69],
                THDI2 = valores[70],
                THDI3 = valores[71],
                TEMP = valores[72],
                IO1 = valores[73],
                IO2 = valores[74]
            };

            DirectoryInfo pasta = new DirectoryInfo(@"C:\Dados\XMLForms");
            FileInfo[] folder = pasta.GetFiles("*", SearchOption.TopDirectoryOnly);
            string arquivos = "Dados - " + folder.Length.ToString() + ".xml";

            var xmlSerializer = new XmlSerializer(typeof(Vars.KronVars));
            string caminho = @"C:\Dados\XMLForms\";
            caminho += arquivos;
            var writer = new StreamWriter(caminho);
            xmlSerializer.Serialize(writer, dados);
        }
    }
}
