namespace Desktop_CLP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gb_est_1 = new GroupBox();
            led_est_1 = new PictureBox();
            lb_qtd_mgz = new Label();
            btn_est_1 = new Button();
            btn_sol_transf = new Button();
            btn_est_2 = new Button();
            btn_connect = new Button();
            lb_stts_connect = new Label();
            gb_est_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)led_est_1).BeginInit();
            SuspendLayout();
            // 
            // gb_est_1
            // 
            gb_est_1.Controls.Add(led_est_1);
            gb_est_1.Controls.Add(lb_qtd_mgz);
            gb_est_1.Controls.Add(btn_est_1);
            gb_est_1.Controls.Add(btn_sol_transf);
            gb_est_1.Location = new Point(12, 17);
            gb_est_1.Name = "gb_est_1";
            gb_est_1.Size = new Size(256, 267);
            gb_est_1.TabIndex = 0;
            gb_est_1.TabStop = false;
            gb_est_1.Text = "Estante 1";
            gb_est_1.Enter += groupBox1_Enter_1;
            // 
            // led_est_1
            // 
            led_est_1.Image = Properties.Resources.led_off;
            led_est_1.Location = new Point(167, 59);
            led_est_1.Name = "led_est_1";
            led_est_1.Size = new Size(65, 45);
            led_est_1.SizeMode = PictureBoxSizeMode.StretchImage;
            led_est_1.TabIndex = 4;
            led_est_1.TabStop = false;
            led_est_1.Click += led_est_1_Click;
            // 
            // lb_qtd_mgz
            // 
            lb_qtd_mgz.AutoSize = true;
            lb_qtd_mgz.Location = new Point(16, 166);
            lb_qtd_mgz.Name = "lb_qtd_mgz";
            lb_qtd_mgz.Size = new Size(40, 17);
            lb_qtd_mgz.TabIndex = 4;
            lb_qtd_mgz.Text = "QTD: ";
            // 
            // btn_est_1
            // 
            btn_est_1.Location = new Point(16, 47);
            btn_est_1.Name = "btn_est_1";
            btn_est_1.Size = new Size(102, 25);
            btn_est_1.TabIndex = 0;
            btn_est_1.Text = "Solicita DKSTP";
            btn_est_1.UseVisualStyleBackColor = true;
            btn_est_1.Click += btn_est_1_Click;
            // 
            // btn_sol_transf
            // 
            btn_sol_transf.Location = new Point(16, 90);
            btn_sol_transf.Name = "btn_sol_transf";
            btn_sol_transf.Size = new Size(102, 25);
            btn_sol_transf.TabIndex = 1;
            btn_sol_transf.Text = "Solicita Transf";
            btn_sol_transf.UseVisualStyleBackColor = true;
            btn_sol_transf.Click += btn_sol_transf_Click;
            // 
            // btn_est_2
            // 
            btn_est_2.Location = new Point(359, 64);
            btn_est_2.Name = "btn_est_2";
            btn_est_2.Size = new Size(83, 25);
            btn_est_2.TabIndex = 0;
            btn_est_2.Text = "Estante 2";
            btn_est_2.UseVisualStyleBackColor = true;
            btn_est_2.Click += btn_est_2_Click;
            // 
            // btn_connect
            // 
            btn_connect.Location = new Point(269, 355);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(83, 25);
            btn_connect.TabIndex = 2;
            btn_connect.Text = "Conectar";
            btn_connect.UseVisualStyleBackColor = true;
            btn_connect.Click += btn_connect_Click;
            // 
            // lb_stts_connect
            // 
            lb_stts_connect.AutoSize = true;
            lb_stts_connect.Location = new Point(289, 387);
            lb_stts_connect.Name = "lb_stts_connect";
            lb_stts_connect.Size = new Size(43, 17);
            lb_stts_connect.TabIndex = 3;
            lb_stts_connect.Text = "Status";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_est_2);
            Controls.Add(lb_stts_connect);
            Controls.Add(btn_connect);
            Controls.Add(gb_est_1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Terminal de testes";
            gb_est_1.ResumeLayout(false);
            gb_est_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)led_est_1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb_est_1;
        private Button btn_est_2;
        private Button btn_est_1;
        private Button btn_sol_transf;
        private Button btn_connect;
        private Label lb_stts_connect;
        private Label lb_qtd_mgz;
        private PictureBox led_est_1;
    }
}
