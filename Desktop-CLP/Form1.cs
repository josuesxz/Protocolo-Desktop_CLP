using MCProtocol;

namespace Desktop_CLP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void btn_connect_Click(object sender, EventArgs e)
        {
            PLCData.PLC = new Mitsubishi.McProtocolTcp("192.168.3.20", 502, Mitsubishi.McFrame.MC3E);
            await PLCData.PLC.Open();
        }
    }
    
}
