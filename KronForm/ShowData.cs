using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KronForm
{
    public partial class ShowData : Form
    {
        public ShowData()
        {
            InitializeComponent();
        }

        public ShowData(List<float> _valores)
        {
            InitializeComponent();
            txtbox_SDserialNumber.Text = _valores[0].ToString();
            txtbox_SDu0.Text = _valores[1].ToString();
            txtbox_SDu12.Text = _valores[2].ToString();
            txtbox_SDu23.Text = _valores[3].ToString();
            txtbox_SDu31.Text = _valores[4].ToString();
            txtbox_SDu1.Text = _valores[5].ToString();
            txtbox_SDu2.Text = _valores[6].ToString();
            txtbox_SDu3.Text = _valores[7].ToString();
            txtbox_SDi0.Text = _valores[8].ToString();
            txtbox_SDin.Text = _valores[9].ToString();
            txtbox_SDi1.Text = _valores[10].ToString();
            txtbox_SDi2.Text = _valores[11].ToString();
            txtbox_SDi3.Text = _valores[12].ToString();
            txtbox_SDf1.Text = _valores[13].ToString();
            txtbox_SDf2.Text = _valores[14].ToString();
            txtbox_SDf3.Text = _valores[15].ToString();
            txtbox_SDfiec.Text = _valores[16].ToString();
            txtbox_SDp0.Text = _valores[17].ToString();
            txtbox_SDp1.Text = _valores[18].ToString();
            txtbox_SDp2.Text = _valores[19].ToString();
            txtbox_SDp3.Text = _valores[20].ToString();
            txtbox_SDq0.Text = _valores[21].ToString();
            txtbox_SDq1.Text = _valores[22].ToString();
            txtbox_SDq2.Text = _valores[23].ToString();
            txtbox_SDq3.Text = _valores[24].ToString();
            txtbox_SDs0.Text = _valores[25].ToString();
            txtbox_SDs1.Text = _valores[26].ToString();
            txtbox_SDs2.Text = _valores[27].ToString();
            txtbox_SDs3.Text = _valores[28].ToString();
            txtbox_SDfp0.Text = _valores[29].ToString();
            txtbox_SDfp1.Text = _valores[30].ToString();
            txtbox_SDfp2.Text = _valores[31].ToString();
            txtbox_SDfp3.Text = _valores[32].ToString();
            txtbox_SDfp0d.Text = _valores[33].ToString();
            txtbox_SDfp1d.Text = _valores[34].ToString();
            txtbox_SDfp2d.Text = _valores[35].ToString();
            txtbox_SDfp3d.Text = _valores[36].ToString();
            txtbox_SDfd.Text = _valores[37].ToString();
            txtbox_SDfk1.Text = _valores[38].ToString();
            txtbox_SDfk2.Text = _valores[39].ToString();
            txtbox_SDfk3.Text = _valores[40].ToString();
            txtbox_SDedp1.Text = _valores[41].ToString();
            txtbox_SDedp2.Text = _valores[42].ToString();
            txtbox_SDedp3.Text = _valores[43].ToString();
            txtbox_SDedp1s.Text = _valores[44].ToString();
            txtbox_SDedp2s.Text = _valores[45].ToString();
            txtbox_SDedp3s.Text = _valores[46].ToString();
            txtbox_SDout1s.Text = _valores[47].ToString();
            txtbox_SDout2s.Text = _valores[48].ToString();
            txtbox_SDedp1p.Text = _valores[49].ToString();
            txtbox_SDedp2p.Text = _valores[50].ToString();
            txtbox_SDedp3p.Text = _valores[51].ToString();
            txtbox_SDlsts.Text = _valores[52].ToString();
            txtbox_SDhorim.Text = _valores[53].ToString();
            txtbox_SDea.Text = _valores[54].ToString();
            txtbox_SDer.Text = _valores[55].ToString();
            txtbox_SDean.Text = _valores[56].ToString();
            txtbox_SDmda.Text = _valores[58].ToString();
            txtbox_SDda.Text = _valores[59].ToString();
            txtbox_SDmds.Text = _valores[60].ToString();
            txtbox_SDds.Text = _valores[61].ToString();
            txtbox_SDeadp.Text = _valores[62].ToString();
            txtbox_SDerdp.Text = _valores[63].ToString();
            txtbox_SDeadn.Text = _valores[64].ToString();
            txtbox_SDerdn.Text = _valores[65].ToString();
            txtbox_SDthdu1.Text = _valores[66].ToString();
            txtbox_SDthdu2.Text = _valores[67].ToString();
            txtbox_SDthdu3.Text = _valores[68].ToString();
            txtbox_SDthdi1.Text = _valores[69].ToString();
            txtbox_SDthdi2.Text = _valores[70].ToString();
            txtbox_SDthdi3.Text = _valores[71].ToString();
            txtbox_SDtemp.Text = _valores[72].ToString();
            txtbox_SDi01.Text = _valores[73].ToString();
            txtbox_SDi02.Text = _valores[74].ToString();
        }
    }
}
