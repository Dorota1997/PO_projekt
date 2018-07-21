namespace po_projekt
{
    partial class Form1
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
            this.play_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wyjscie_przycisk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.Color.Gray;
            this.play_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.play_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.play_button.Location = new System.Drawing.Point(93, 313);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(121, 46);
            this.play_button.TabIndex = 0;
            this.play_button.Text = "Graj";
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(73, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 232);
            this.label1.TabIndex = 1;
            this.label1.Text = "MEMO\r\nGame";
            // 
            // wyjscie_przycisk
            // 
            this.wyjscie_przycisk.BackColor = System.Drawing.Color.Gray;
            this.wyjscie_przycisk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.wyjscie_przycisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wyjscie_przycisk.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyjscie_przycisk.Location = new System.Drawing.Point(332, 313);
            this.wyjscie_przycisk.Name = "wyjscie_przycisk";
            this.wyjscie_przycisk.Size = new System.Drawing.Size(121, 46);
            this.wyjscie_przycisk.TabIndex = 2;
            this.wyjscie_przycisk.Text = "Wyjście";
            this.wyjscie_przycisk.UseVisualStyleBackColor = false;
            this.wyjscie_przycisk.Click += new System.EventHandler(this.wyjdz_z_gry);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.ControlBox = false;
            this.Controls.Add(this.wyjscie_przycisk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.play_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEMO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wyjscie_przycisk;
    }
}

