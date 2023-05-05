namespace ChatClient
{
    partial class ChatForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelShowMessage = new System.Windows.Forms.Panel();
            this.showMessage = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelShowMessage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelShowMessage);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(44, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 365);
            this.panel1.TabIndex = 0;
            // 
            // panelShowMessage
            // 
            this.panelShowMessage.Controls.Add(this.showMessage);
            this.panelShowMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowMessage.Location = new System.Drawing.Point(0, 0);
            this.panelShowMessage.Name = "panelShowMessage";
            this.panelShowMessage.Size = new System.Drawing.Size(711, 302);
            this.panelShowMessage.TabIndex = 1;
            // 
            // showMessage
            // 
            this.showMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showMessage.Enabled = false;
            this.showMessage.Location = new System.Drawing.Point(0, 0);
            this.showMessage.Multiline = true;
            this.showMessage.Name = "showMessage";
            this.showMessage.Size = new System.Drawing.Size(711, 302);
            this.showMessage.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.txtMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 63);
            this.panel2.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(653, 6);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(50, 50);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(11, 6);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(636, 50);
            this.txtMessage.TabIndex = 0;
            // 
            // ChatForm
            // 
            FormClosed += new FormClosedEventHandler(Close);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ChatForm";
            this.Text = "Client";
            this.panel1.ResumeLayout(false);
            this.panelShowMessage.ResumeLayout(false);
            this.panelShowMessage.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panelShowMessage;
        private Panel panel2;
        private TextBox txtMessage;
        private Button btnSend;
        private TextBox showMessage;
    }
}