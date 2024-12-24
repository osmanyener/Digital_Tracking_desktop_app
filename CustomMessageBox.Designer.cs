namespace mekeceisik_1
{
    partial class CustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            btn_OK = new Button();
            panel1 = new Panel();
            lblMessage = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_OK
            // 
            btn_OK.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_OK.Location = new Point(420, 176);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(95, 33);
            btn_OK.TabIndex = 1;
            btn_OK.Text = "Tamam";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(lblMessage);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 170);
            panel1.TabIndex = 2;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessage.Location = new Point(43, 69);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(210, 37);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Sıra Numarası: ";
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 221);
            Controls.Add(panel1);
            Controls.Add(btn_OK);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mekece Işık";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_OK;
        private Panel panel1;
        private Label lblMessage;
    }
}