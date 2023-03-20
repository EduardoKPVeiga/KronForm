namespace KronForm
{
    partial class kronForm
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
            txt_ip = new Label();
            txt_serialNumder = new Label();
            txt_ipNovo = new Label();
            gp_searchIP = new GroupBox();
            btn_clear = new Button();
            gp_data = new GroupBox();
            txt_sendData = new Label();
            btn_confirm = new Button();
            txtbox_port = new TextBox();
            txtbox_newIp = new TextBox();
            txtbox_serialNumber = new TextBox();
            txtbox_ip = new TextBox();
            txt_port = new Label();
            txt_newPort = new Label();
            txtbox_newPort = new TextBox();
            gp_searchIP.SuspendLayout();
            gp_data.SuspendLayout();
            SuspendLayout();
            // 
            // txt_ip
            // 
            txt_ip.AutoSize = true;
            txt_ip.Location = new Point(6, 16);
            txt_ip.Name = "txt_ip";
            txt_ip.Size = new Size(17, 15);
            txt_ip.TabIndex = 0;
            txt_ip.Text = "IP";
            // 
            // txt_serialNumder
            // 
            txt_serialNumder.AutoSize = true;
            txt_serialNumder.Location = new Point(6, 49);
            txt_serialNumder.Name = "txt_serialNumder";
            txt_serialNumder.Size = new Size(82, 15);
            txt_serialNumder.TabIndex = 1;
            txt_serialNumder.Text = "Serial Number";
            // 
            // txt_ipNovo
            // 
            txt_ipNovo.AutoSize = true;
            txt_ipNovo.Location = new Point(6, 82);
            txt_ipNovo.Name = "txt_ipNovo";
            txt_ipNovo.Size = new Size(44, 15);
            txt_ipNovo.TabIndex = 2;
            txt_ipNovo.Text = "New IP";
            // 
            // gp_searchIP
            // 
            gp_searchIP.Controls.Add(txtbox_newPort);
            gp_searchIP.Controls.Add(txt_newPort);
            gp_searchIP.Controls.Add(btn_clear);
            gp_searchIP.Controls.Add(gp_data);
            gp_searchIP.Controls.Add(btn_confirm);
            gp_searchIP.Controls.Add(txtbox_port);
            gp_searchIP.Controls.Add(txtbox_newIp);
            gp_searchIP.Controls.Add(txtbox_serialNumber);
            gp_searchIP.Controls.Add(txtbox_ip);
            gp_searchIP.Controls.Add(txt_port);
            gp_searchIP.Controls.Add(txt_ip);
            gp_searchIP.Controls.Add(txt_ipNovo);
            gp_searchIP.Controls.Add(txt_serialNumder);
            gp_searchIP.Location = new Point(12, 12);
            gp_searchIP.Name = "gp_searchIP";
            gp_searchIP.Size = new Size(440, 340);
            gp_searchIP.TabIndex = 3;
            gp_searchIP.TabStop = false;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(246, 311);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 23);
            btn_clear.TabIndex = 10;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // gp_data
            // 
            gp_data.Controls.Add(txt_sendData);
            gp_data.Location = new Point(6, 188);
            gp_data.Name = "gp_data";
            gp_data.Size = new Size(428, 101);
            gp_data.TabIndex = 9;
            gp_data.TabStop = false;
            gp_data.Visible = false;
            // 
            // txt_sendData
            // 
            txt_sendData.AutoSize = true;
            txt_sendData.Location = new Point(6, 208);
            txt_sendData.Name = "txt_sendData";
            txt_sendData.Size = new Size(0, 15);
            txt_sendData.TabIndex = 0;
            // 
            // btn_confirm
            // 
            btn_confirm.Location = new Point(138, 311);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(75, 23);
            btn_confirm.TabIndex = 8;
            btn_confirm.Text = "Confirm";
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // txtbox_port
            // 
            txtbox_port.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_port.Location = new Point(167, 115);
            txtbox_port.Name = "txtbox_port";
            txtbox_port.Size = new Size(267, 27);
            txtbox_port.TabIndex = 7;
            // 
            // txtbox_newIp
            // 
            txtbox_newIp.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_newIp.Location = new Point(167, 82);
            txtbox_newIp.Name = "txtbox_newIp";
            txtbox_newIp.Size = new Size(267, 27);
            txtbox_newIp.TabIndex = 6;
            // 
            // txtbox_serialNumber
            // 
            txtbox_serialNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_serialNumber.Location = new Point(167, 49);
            txtbox_serialNumber.Name = "txtbox_serialNumber";
            txtbox_serialNumber.Size = new Size(267, 27);
            txtbox_serialNumber.TabIndex = 5;
            // 
            // txtbox_ip
            // 
            txtbox_ip.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_ip.Location = new Point(167, 16);
            txtbox_ip.Name = "txtbox_ip";
            txtbox_ip.Size = new Size(267, 27);
            txtbox_ip.TabIndex = 4;
            // 
            // txt_port
            // 
            txt_port.AutoSize = true;
            txt_port.Location = new Point(6, 115);
            txt_port.Name = "txt_port";
            txt_port.Size = new Size(29, 15);
            txt_port.TabIndex = 3;
            txt_port.Text = "Port";
            // 
            // txt_newPort
            // 
            txt_newPort.AutoSize = true;
            txt_newPort.Location = new Point(6, 148);
            txt_newPort.Name = "txt_newPort";
            txt_newPort.Size = new Size(56, 15);
            txt_newPort.TabIndex = 11;
            txt_newPort.Text = "New Port";
            // 
            // txtbox_newPort
            // 
            txtbox_newPort.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_newPort.Location = new Point(167, 148);
            txtbox_newPort.Name = "txtbox_newPort";
            txtbox_newPort.Size = new Size(267, 27);
            txtbox_newPort.TabIndex = 12;
            // 
            // kronForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(464, 364);
            Controls.Add(gp_searchIP);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "kronForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kron Form";
            gp_searchIP.ResumeLayout(false);
            gp_searchIP.PerformLayout();
            gp_data.ResumeLayout(false);
            gp_data.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label txt_ip;
        private Label txt_serialNumder;
        private Label txt_ipNovo;
        private GroupBox gp_searchIP;
        private Label txt_port;
        private TextBox txtbox_ip;
        private TextBox txtbox_newIp;
        private TextBox txtbox_serialNumber;
        private TextBox txtbox_port;
        private Button btn_confirm;
        private GroupBox gp_data;
        private Label txt_sendData;
        private Button btn_clear;
        private Label txt_newPort;
        private TextBox txtbox_newPort;
    }
}