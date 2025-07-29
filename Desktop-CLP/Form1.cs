using MCProtocol;

namespace Desktop_CLP
{
    public partial class Form1 : Form
    {
        public PLCData<int> solicitaDesktop = new (Mitsubishi.PlcDeviceType.W, 0, 1);
        public PLCData<int> solicitaTransferidor = new (Mitsubishi.PlcDeviceType.W, 258, 1);
        public PLCData<bool> led = new (Mitsubishi.PlcDeviceType.Y, 7, 10);
        public PLCData<short> quantidadeEstantes = new (Mitsubishi.PlcDeviceType.W, 16, 10);
        public PLCData<short> modoMaquina = new(Mitsubishi.PlcDeviceType.D, 0, 1);
        public PLCData<bool> controleModo = new (Mitsubishi.PlcDeviceType.M, 13, 4);

        public Form1()
        {
            InitializeComponent();
        }

        private async Task MonitorarPLC()
        {
            while (PLCData.PLC != null && PLCData.PLC.Connected)
            {
                await quantidadeEstantes.ReadData();
                await modoMaquina.ReadData();
                lb_stts_connect.Text = "Conectado - " + modoMaquina[0];
                lb_QTD_mgzn1.Text = "Quantidade: " + quantidadeEstantes[0].ToString();
                lb_QTD_mgzn2.Text = "Quantidade: " + quantidadeEstantes[1].ToString();
                await Task.Delay(500);

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


        // Variáveis para o pulso

        public async void pulsoSinalDSKTP(int indice)
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

        public async void pulsoSinalTRNSF(int indice)
        {
            int[] valorEstante = [1, 2, 4, 8, 16, 32, 64, 128, 256, 512];

            solicitaTransferidor[0] = valorEstante[indice]; ;
            await solicitaTransferidor.WriteData();
            await Task.Delay(500);
            solicitaTransferidor[0] = 0;
            await solicitaTransferidor.WriteData();
        }

        private async void btn_est_1_Click(object sender, EventArgs e)
        {
            pulsoSinalDSKTP(0);
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

        private async void btn_sol_transf_Click(object sender, EventArgs e)
        {
            pulsoSinalTRNSF(0);
        }

        private async void btn_est_2_Click(object sender, EventArgs e)
        {
            pulsoSinalDSKTP(1);
        }

        private void btn_sol_transf2_Click(object sender, EventArgs e)
        {
            pulsoSinalTRNSF(1);
        }

        private async void ch_man_auto_CheckedChanged(object sender, EventArgs e)
        {
            await controleModo.ReadData();
            controleModo[0] = !controleModo[0];
            await controleModo.WriteData();
        }

        private async void btn_rst_Click(object sender, EventArgs e)
        {
            controleModo[1] = true;
            await controleModo.WriteData();
            await Task.Delay(500);
            controleModo[1] = false;
            await controleModo.WriteData();
        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            controleModo[2] = true;
            await controleModo.WriteData();
            await Task.Delay(500);
            controleModo[2] = false;
            await controleModo.WriteData();
        }

        private async void btn_stp_Click(object sender, EventArgs e)
        {
            controleModo[3] = true;
            await controleModo.WriteData();
            await Task.Delay(500);
            controleModo[3] = false;
            await controleModo.WriteData();
        }
    }

}
