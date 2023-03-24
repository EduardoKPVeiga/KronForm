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
            gp_searchIP = new GroupBox();
            txtbox_yIp = new TextBox();
            txt_yIp = new Label();
            btn_connect = new Button();
            btn_disconnect = new Button();
            txtbox_ipD = new TextBox();
            txt_ipD = new Label();
            txtbox_newPortD = new TextBox();
            txt_newPort = new Label();
            btn_clear = new Button();
            gp_data = new GroupBox();
            txt_sendData = new Label();
            btn_confirm = new Button();
            txtbox_portM = new TextBox();
            txtbox_newIpD = new TextBox();
            txtbox_serialNumberD = new TextBox();
            txtbox_ipM = new TextBox();
            txt_port = new Label();
            txt_ipM = new Label();
            txt_ipNovoD = new Label();
            txt_serialNumderD = new Label();
            gp_serverMsg = new GroupBox();
            txt_receivedData1 = new Label();
            gp_searchIP.SuspendLayout();
            gp_data.SuspendLayout();
            gp_serverMsg.SuspendLayout();
            SuspendLayout();
            // 
            // gp_searchIP
            // 
            gp_searchIP.Controls.Add(txtbox_yIp);
            gp_searchIP.Controls.Add(txt_yIp);
            gp_searchIP.Controls.Add(btn_connect);
            gp_searchIP.Controls.Add(btn_disconnect);
            gp_searchIP.Controls.Add(txtbox_ipD);
            gp_searchIP.Controls.Add(txt_ipD);
            gp_searchIP.Controls.Add(txtbox_newPortD);
            gp_searchIP.Controls.Add(txt_newPort);
            gp_searchIP.Controls.Add(btn_clear);
            gp_searchIP.Controls.Add(gp_data);
            gp_searchIP.Controls.Add(btn_confirm);
            gp_searchIP.Controls.Add(txtbox_portM);
            gp_searchIP.Controls.Add(txtbox_newIpD);
            gp_searchIP.Controls.Add(txtbox_serialNumberD);
            gp_searchIP.Controls.Add(txtbox_ipM);
            gp_searchIP.Controls.Add(txt_port);
            gp_searchIP.Controls.Add(txt_ipM);
            gp_searchIP.Controls.Add(txt_ipNovoD);
            gp_searchIP.Controls.Add(txt_serialNumderD);
            gp_searchIP.Location = new Point(12, 12);
            gp_searchIP.Name = "gp_searchIP";
            gp_searchIP.Size = new Size(440, 366);
            gp_searchIP.TabIndex = 3;
            gp_searchIP.TabStop = false;
            // 
            // txtbox_yIp
            // 
            txtbox_yIp.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_yIp.Location = new Point(167, 21);
            txtbox_yIp.Name = "txtbox_yIp";
            txtbox_yIp.Size = new Size(267, 27);
            txtbox_yIp.TabIndex = 0;
            // 
            // txt_yIp
            // 
            txt_yIp.AutoSize = true;
            txt_yIp.Location = new Point(6, 21);
            txt_yIp.Name = "txt_yIp";
            txt_yIp.Size = new Size(44, 15);
            txt_yIp.TabIndex = 16;
            txt_yIp.Text = "Your IP";
            // 
            // btn_connect
            // 
            btn_connect.Location = new Point(278, 340);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(75, 23);
            btn_connect.TabIndex = 14;
            btn_connect.Text = "Connect";
            btn_connect.UseVisualStyleBackColor = true;
            btn_connect.Click += btn_connect_Click;
            // 
            // btn_disconnect
            // 
            btn_disconnect.Location = new Point(359, 340);
            btn_disconnect.Name = "btn_disconnect";
            btn_disconnect.Size = new Size(75, 23);
            btn_disconnect.TabIndex = 15;
            btn_disconnect.Text = "Disconnect";
            btn_disconnect.UseVisualStyleBackColor = true;
            btn_disconnect.Click += btn_disconnect_Click;
            // 
            // txtbox_ipD
            // 
            txtbox_ipD.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_ipD.Location = new Point(167, 120);
            txtbox_ipD.Name = "txtbox_ipD";
            txtbox_ipD.Size = new Size(267, 27);
            txtbox_ipD.TabIndex = 3;
            // 
            // txt_ipD
            // 
            txt_ipD.AutoSize = true;
            txt_ipD.Location = new Point(6, 120);
            txt_ipD.Name = "txt_ipD";
            txt_ipD.Size = new Size(55, 15);
            txt_ipD.TabIndex = 13;
            txt_ipD.Text = "IP Device";
            // 
            // txtbox_newPortD
            // 
            txtbox_newPortD.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_newPortD.Location = new Point(167, 219);
            txtbox_newPortD.Name = "txtbox_newPortD";
            txtbox_newPortD.Size = new Size(267, 27);
            txtbox_newPortD.TabIndex = 6;
            // 
            // txt_newPort
            // 
            txt_newPort.AutoSize = true;
            txt_newPort.Location = new Point(6, 219);
            txt_newPort.Name = "txt_newPort";
            txt_newPort.Size = new Size(94, 15);
            txt_newPort.TabIndex = 11;
            txt_newPort.Text = "New Port Device";
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(87, 340);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 23);
            btn_clear.TabIndex = 7;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // gp_data
            // 
            gp_data.Controls.Add(txt_sendData);
            gp_data.Location = new Point(6, 257);
            gp_data.Name = "gp_data";
            gp_data.Size = new Size(428, 70);
            gp_data.TabIndex = 9;
            gp_data.TabStop = false;
            gp_data.Visible = false;
            // 
            // txt_sendData
            // 
            txt_sendData.AutoSize = true;
            txt_sendData.Location = new Point(6, 19);
            txt_sendData.Name = "txt_sendData";
            txt_sendData.Size = new Size(60, 15);
            txt_sendData.TabIndex = 0;
            txt_sendData.Text = "Send Data";
            // 
            // btn_confirm
            // 
            btn_confirm.Location = new Point(6, 340);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(75, 23);
            btn_confirm.TabIndex = 6;
            btn_confirm.Text = "Confirm";
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // txtbox_portM
            // 
            txtbox_portM.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_portM.Location = new Point(167, 87);
            txtbox_portM.Name = "txtbox_portM";
            txtbox_portM.Size = new Size(267, 27);
            txtbox_portM.TabIndex = 2;
            // 
            // txtbox_newIpD
            // 
            txtbox_newIpD.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_newIpD.Location = new Point(167, 186);
            txtbox_newIpD.Name = "txtbox_newIpD";
            txtbox_newIpD.Size = new Size(267, 27);
            txtbox_newIpD.TabIndex = 5;
            // 
            // txtbox_serialNumberD
            // 
            txtbox_serialNumberD.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_serialNumberD.Location = new Point(167, 153);
            txtbox_serialNumberD.Name = "txtbox_serialNumberD";
            txtbox_serialNumberD.Size = new Size(267, 27);
            txtbox_serialNumberD.TabIndex = 4;
            // 
            // txtbox_ipM
            // 
            txtbox_ipM.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_ipM.Location = new Point(167, 54);
            txtbox_ipM.Name = "txtbox_ipM";
            txtbox_ipM.Size = new Size(267, 27);
            txtbox_ipM.TabIndex = 1;
            // 
            // txt_port
            // 
            txt_port.AutoSize = true;
            txt_port.Location = new Point(6, 87);
            txt_port.Name = "txt_port";
            txt_port.Size = new Size(78, 15);
            txt_port.TabIndex = 3;
            txt_port.Text = "Port Machine";
            // 
            // txt_ipM
            // 
            txt_ipM.AutoSize = true;
            txt_ipM.Location = new Point(6, 54);
            txt_ipM.Name = "txt_ipM";
            txt_ipM.Size = new Size(66, 15);
            txt_ipM.TabIndex = 0;
            txt_ipM.Text = "IP Machine";
            // 
            // txt_ipNovoD
            // 
            txt_ipNovoD.AutoSize = true;
            txt_ipNovoD.Location = new Point(6, 186);
            txt_ipNovoD.Name = "txt_ipNovoD";
            txt_ipNovoD.Size = new Size(82, 15);
            txt_ipNovoD.TabIndex = 2;
            txt_ipNovoD.Text = "New IP Device";
            // 
            // txt_serialNumderD
            // 
            txt_serialNumderD.AutoSize = true;
            txt_serialNumderD.Location = new Point(6, 153);
            txt_serialNumderD.Name = "txt_serialNumderD";
            txt_serialNumderD.Size = new Size(120, 15);
            txt_serialNumderD.TabIndex = 1;
            txt_serialNumderD.Text = "Serial Number Device";
            // 
            // gp_serverMsg
            // 
            gp_serverMsg.Controls.Add(txt_receivedData1);
            gp_serverMsg.Location = new Point(458, 12);
            gp_serverMsg.Name = "gp_serverMsg";
            gp_serverMsg.Size = new Size(142, 366);
            gp_serverMsg.TabIndex = 4;
            gp_serverMsg.TabStop = false;
            // 
            // txt_receivedData1
            // 
            txt_receivedData1.AutoSize = true;
            txt_receivedData1.Location = new Point(6, 19);
            txt_receivedData1.Name = "txt_receivedData1";
            txt_receivedData1.Size = new Size(81, 15);
            txt_receivedData1.TabIndex = 0;
            txt_receivedData1.Text = "Received Data";
            txt_receivedData1.Visible = false;
            // 
            // kronForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(606, 390);
            Controls.Add(gp_serverMsg);
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
            gp_serverMsg.ResumeLayout(false);
            gp_serverMsg.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label txt_ipM;
        private Label txt_serialNumderD;
        private Label txt_ipNovoD;
        private GroupBox gp_searchIP;
        private Label txt_port;
        private TextBox txtbox_ipM;
        private TextBox txtbox_newIpD;
        private TextBox txtbox_serialNumberD;
        private TextBox txtbox_portM;
        private TextBox txtbox_newPortD;
        private Button btn_confirm;
        private GroupBox gp_data;
        private Button btn_clear;
        private Label txt_newPort;
        private Label txt_sendData;
        private Label txt_ipD;
        private TextBox txtbox_ipD;
        private Button btn_connect;
        private Button btn_disconnect;
        private GroupBox gp_serverMsg;
        private Label txt_receivedData1;
        private Label txt_yIp;
        private TextBox txtbox_yIp;
    }
}