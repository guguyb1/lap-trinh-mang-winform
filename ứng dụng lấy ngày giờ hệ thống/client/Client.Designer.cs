namespace client
{
    partial class Client
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
            this.inputText = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGui = new Guna.UI2.WinForms.Guna2Button();
            this.thongBao = new System.Windows.Forms.RichTextBox();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputText.DefaultText = "";
            this.inputText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText.ForeColor = System.Drawing.Color.Black;
            this.inputText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputText.Location = new System.Drawing.Point(13, 578);
            this.inputText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputText.Name = "inputText";
            this.inputText.PasswordChar = '\0';
            this.inputText.PlaceholderText = "";
            this.inputText.SelectedText = "";
            this.inputText.Size = new System.Drawing.Size(404, 45);
            this.inputText.TabIndex = 16;
            // 
            // btnGui
            // 
            this.btnGui.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGui.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGui.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGui.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGui.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.ForeColor = System.Drawing.Color.White;
            this.btnGui.Location = new System.Drawing.Point(423, 578);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(119, 45);
            this.btnGui.TabIndex = 15;
            this.btnGui.Text = "gửi";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // thongBao
            // 
            this.thongBao.BackColor = System.Drawing.Color.White;
            this.thongBao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thongBao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongBao.ForeColor = System.Drawing.Color.Black;
            this.thongBao.Location = new System.Drawing.Point(13, 63);
            this.thongBao.Name = "thongBao";
            this.thongBao.ReadOnly = true;
            this.thongBao.Size = new System.Drawing.Size(528, 509);
            this.thongBao.TabIndex = 17;
            this.thongBao.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnStart.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.btnStart.CheckedState.FillColor = System.Drawing.Color.Red;
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(361, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(180, 45);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "bắt đầu";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 673);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.thongBao);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.btnGui);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox inputText;
        private Guna.UI2.WinForms.Guna2Button btnGui;
        private System.Windows.Forms.RichTextBox thongBao;
        private Guna.UI2.WinForms.Guna2Button btnStart;
    }
}

