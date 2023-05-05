namespace ChatServer
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panelShowMessage = new Panel();
            showMessage = new TextBox();
            panelSendMessage = new Panel();
            btnSend = new Button();
            txtMessage = new TextBox();
            panel1.SuspendLayout();
            panelShowMessage.SuspendLayout();
            panelSendMessage.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panelShowMessage);
            panel1.Controls.Add(panelSendMessage);
            panel1.Location = new Point(51, 57);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 487);
            panel1.TabIndex = 1;
            // 
            // panelShowMessage
            // 
            panelShowMessage.Controls.Add(showMessage);
            panelShowMessage.Dock = DockStyle.Fill;
            panelShowMessage.Location = new Point(0, 0);
            panelShowMessage.Margin = new Padding(3, 4, 3, 4);
            panelShowMessage.Name = "panelShowMessage";
            panelShowMessage.Size = new Size(813, 403);
            panelShowMessage.TabIndex = 1;
            // 
            // showMessage
            // 
            showMessage.BorderStyle = BorderStyle.None;
            showMessage.Dock = DockStyle.Fill;
            showMessage.Enabled = false;
            showMessage.Location = new Point(0, 0);
            showMessage.Margin = new Padding(3, 4, 3, 4);
            showMessage.Multiline = true;
            showMessage.Name = "showMessage";
            showMessage.Size = new Size(813, 403);
            showMessage.TabIndex = 0;
            // 
            // panelSendMessage
            // 
            panelSendMessage.Controls.Add(btnSend);
            panelSendMessage.Controls.Add(txtMessage);
            panelSendMessage.Dock = DockStyle.Bottom;
            panelSendMessage.Enabled = false;
            panelSendMessage.Location = new Point(0, 403);
            panelSendMessage.Margin = new Padding(3, 4, 3, 4);
            panelSendMessage.Name = "panelSendMessage";
            panelSendMessage.Size = new Size(813, 84);
            panelSendMessage.TabIndex = 0;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(746, 8);
            btnSend.Margin = new Padding(3, 4, 3, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(57, 67);
            btnSend.TabIndex = 1;
            btnSend.Text = "Gửi";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(13, 8);
            txtMessage.Margin = new Padding(3, 4, 3, 4);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(726, 65);
            txtMessage.TabIndex = 0;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChatForm";
            Text = "Server";
            FormClosed += Close;
            Load += ChatForm_Load;
            panel1.ResumeLayout(false);
            panelShowMessage.ResumeLayout(false);
            panelShowMessage.PerformLayout();
            panelSendMessage.ResumeLayout(false);
            panelSendMessage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelShowMessage;
        private Panel panelSendMessage;
        private Button btnSend;
        private TextBox txtMessage;
        private TextBox showMessage;
    }
}