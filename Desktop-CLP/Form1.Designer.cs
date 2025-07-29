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
            lb_QTD_mgzn1 = new Label();
            led_est_1 = new PictureBox();
            btn_est_1 = new Button();
            btn_sol_transf = new Button();
            btn_connect = new Button();
            lb_stts_connect = new Label();
            gb_est_2 = new GroupBox();
            btn_sol_transf2 = new Button();
            lb_QTD_mgzn2 = new Label();
            pictureBox1 = new PictureBox();
            btn_est2 = new Button();
            btn_rst = new Button();
            ch_man_auto = new CheckBox();
            btn_start = new Button();
            btn_stp = new Button();
            gb_est_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)led_est_1).BeginInit();
            gb_est_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gb_est_1
            // 
            gb_est_1.Controls.Add(lb_QTD_mgzn1);
            gb_est_1.Controls.Add(led_est_1);
            gb_est_1.Controls.Add(btn_est_1);
            gb_est_1.Controls.Add(btn_sol_transf);
            gb_est_1.Location = new Point(12, 17);
            gb_est_1.Name = "gb_est_1";
            gb_est_1.Size = new Size(256, 177);
            gb_est_1.TabIndex = 0;
            gb_est_1.TabStop = false;
            gb_est_1.Text = "Estante 1";
            // lb_QTD_mgzn1
            // 
            lb_QTD_mgzn1.AutoSize = true;
            lb_QTD_mgzn1.Location = new Point(16, 144);
            lb_QTD_mgzn1.Name = "lb_QTD_mgzn1";
            lb_QTD_mgzn1.Size = new Size(83, 17);
            lb_QTD_mgzn1.TabIndex = 4;
            lb_QTD_mgzn1.Text = "Quantidade: ";
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
            // gb_est_2
            // 
            gb_est_2.Controls.Add(btn_sol_transf2);
            gb_est_2.Controls.Add(lb_QTD_mgzn2);
            gb_est_2.Controls.Add(pictureBox1);
            gb_est_2.Controls.Add(btn_est2);
            gb_est_2.Location = new Point(274, 17);
            gb_est_2.Name = "gb_est_2";
            gb_est_2.Size = new Size(256, 177);
            gb_est_2.TabIndex = 0;
            gb_est_2.TabStop = false;
            gb_est_2.Text = "Estante 2";
            // 
            // btn_sol_transf2
            // 
            btn_sol_transf2.Location = new Point(16, 90);
            btn_sol_transf2.Name = "btn_sol_transf2";
            btn_sol_transf2.Size = new Size(102, 25);
            btn_sol_transf2.TabIndex = 5;
            btn_sol_transf2.Text = "Solicita Transf";
            btn_sol_transf2.UseVisualStyleBackColor = true;
            btn_sol_transf2.Click += btn_sol_transf2_Click;
            // 
            // lb_QTD_mgzn2
            // 
            lb_QTD_mgzn2.AutoSize = true;
            lb_QTD_mgzn2.Location = new Point(16, 144);
            lb_QTD_mgzn2.Name = "lb_QTD_mgzn2";
            lb_QTD_mgzn2.Size = new Size(83, 17);
            lb_QTD_mgzn2.TabIndex = 4;
            lb_QTD_mgzn2.Text = "Quantidade: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.led_off;
            pictureBox1.Location = new Point(167, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_est2
            // 
            btn_est2.Location = new Point(16, 47);
            btn_est2.Name = "btn_est2";
            btn_est2.Size = new Size(102, 25);
            btn_est2.TabIndex = 0;
            btn_est2.Text = "Solicita DKSTP";
            btn_est2.UseVisualStyleBackColor = true;
            btn_est2.Click += btn_est_2_Click;
            // 
            // btn_rst
            // 
            btn_rst.Location = new Point(12, 336);
            btn_rst.Name = "btn_rst";
            btn_rst.Size = new Size(83, 25);
            btn_rst.TabIndex = 4;
            btn_rst.Text = "Reset";
            btn_rst.UseVisualStyleBackColor = true;
            btn_rst.Click += btn_rst_Click;
            // 
            // ch_man_auto
            // 
            ch_man_auto.AutoSize = true;
            ch_man_auto.Location = new Point(12, 309);
            ch_man_auto.Name = "ch_man_auto";
            ch_man_auto.Size = new Size(70, 21);
            ch_man_auto.TabIndex = 6;
            ch_man_auto.Text = "Manual";
            ch_man_auto.UseVisualStyleBackColor = true;
            ch_man_auto.CheckedChanged += ch_man_auto_CheckedChanged;
            // 
            // btn_start
            // 
            btn_start.Location = new Point(12, 367);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(83, 25);
            btn_start.TabIndex = 7;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // btn_stp
            // 
            btn_stp.Location = new Point(12, 398);
            btn_stp.Name = "btn_stp";
            btn_stp.Size = new Size(83, 25);
            btn_stp.TabIndex = 8;
            btn_stp.Text = "Stop";
            btn_stp.UseVisualStyleBackColor = true;
            btn_stp.Click += btn_stp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_stp);
            Controls.Add(btn_start);
            Controls.Add(ch_man_auto);
            Controls.Add(btn_rst);
            Controls.Add(lb_stts_connect);
            Controls.Add(btn_connect);
            Controls.Add(gb_est_2);
            Controls.Add(gb_est_1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Terminal de testes";
            gb_est_1.ResumeLayout(false);
            gb_est_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)led_est_1).EndInit();
            gb_est_2.ResumeLayout(false);
            gb_est_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb_est_1;
        private Button btn_est_1;
        private Button btn_sol_transf;
        private Button btn_connect;
        private Label lb_stts_connect;
        private PictureBox led_est_1;
        private Label lb_QTD_mgzn1;
        private GroupBox gb_est_2;
        private Label lb_QTD_mgzn2;
        private PictureBox pictureBox1;
        private Button btn_est2;
        private Button btn_sol_transf2;
        private Button btn_rst;
        private CheckBox ch_man_auto;
        private Button btn_start;
        private Button btn_stp;
    }
}
