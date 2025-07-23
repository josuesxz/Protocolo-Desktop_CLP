using MCProtocol;

namespace Desktop_CLP
{
    public partial class Form1 : Form
    {
        public PLCData<int> solicitaDesktop = new PLCData<int>(Mitsubishi.PlcDeviceType.W, 0, 1);
        public PLCData<int> solicitaTransferidor = new PLCData<int>(Mitsubishi.PlcDeviceType.W, 102, 1);
        public PLCData<bool> led = new PLCData<bool>(Mitsubishi.PlcDeviceType.Y, 7, 10);

        public Form1()
        {
            InitializeComponent(); 
        }

        private async Task MonitorarPLC()
        {
            while (PLCData.PLC != null && PLCData.PLC.Connected)
            {
                try
                {
                    await led.ReadData();
                    if (led[0] == true)
                    {
                        led_est_1.Image = Properties.Resources.led_on;
                    }
                    else
                    {
                        led_est_1.Image = Properties.Resources.led_off;
                    }

                    await Task.Delay(500);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Comunicação com o CLP perdida: " + ex.Message);
                    // Quebra o laço se houver um erro
                    break;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // Variáveis para o pulso

        public async void pulsoSinal(int indice)
        {
            int[] valorEstante = [1, 2, 4, 8, 16, 32, 64, 128, 256, 512];
            int valorFinal = 0;
            int duracaoPulsoMs = 500;

            solicitaDesktop[0] = valorEstante[indice];
            await solicitaDesktop.WriteData();
            await Task.Delay(duracaoPulsoMs);
            solicitaDesktop[0] = valorFinal;
            await solicitaDesktop.WriteData();
        }

        private async void btn_est_1_Click(object sender, EventArgs e)
        {
            pulsoSinal(0);
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private async void btn_connect_Click(object sender, EventArgs e)
        {
            PLCData.PLC = new Mitsubishi.McProtocolTcp("192.168.3.20", 502, Mitsubishi.McFrame.MC3E);
            await PLCData.PLC.Open();

            if (PLCData.PLC.Connected)
            {
                lb_stts_connect.Text = "Conectado";
                MonitorarPLC();
            }
        }

        private void btn_sol_transf_Click(object sender, EventArgs e)
        {

        }

        private async void btn_est_2_Click(object sender, EventArgs e)
        {
            pulsoSinal(1);
        }

        private void led_est_1_Click(object sender, EventArgs e)
        {  
        }
    }

}
