
namespace Client_RemoteController_progetto
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rjToggleButton3 = new Client_RemoteController_progetto.ToggleButton.RJToggleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rjToggleButton1 = new Client_RemoteController_progetto.ToggleButton.RJToggleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.PaleGreen;
            this.label7.Location = new System.Drawing.Point(73, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 48);
            this.label7.TabIndex = 24;
            this.label7.Text = "status";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GENERALE",
            "SALOTTO",
            "LAVANDERIA",
            "CUCINA",
            "GARAGE"});
            this.comboBox1.Location = new System.Drawing.Point(10, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(356, 38);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "SELEZIONA STANZA";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // rjToggleButton3
            // 
            this.rjToggleButton3.Location = new System.Drawing.Point(206, 398);
            this.rjToggleButton3.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton3.Name = "rjToggleButton3";
            this.rjToggleButton3.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton3.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton3.OnBackColor = System.Drawing.Color.PaleGreen;
            this.rjToggleButton3.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton3.Size = new System.Drawing.Size(100, 48);
            this.rjToggleButton3.TabIndex = 18;
            this.rjToggleButton3.UseVisualStyleBackColor = true;
            this.rjToggleButton3.CheckedChanged += new System.EventHandler(this.rjToggleButton3_CheckedChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.PaleGreen;
            this.label4.Location = new System.Drawing.Point(73, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 48);
            this.label4.TabIndex = 13;
            this.label4.Text = "LUCE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.PaleGreen;
            this.label3.Location = new System.Drawing.Point(206, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 48);
            this.label3.TabIndex = 12;
            this.label3.Text = "TERMOSTATO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.BackColor = System.Drawing.Color.Transparent;
            this.rjToggleButton1.Location = new System.Drawing.Point(73, 243);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.PaleGreen;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton1.Size = new System.Drawing.Size(100, 48);
            this.rjToggleButton1.TabIndex = 15;
            this.rjToggleButton1.UseVisualStyleBackColor = false;
            this.rjToggleButton1.CheckedChanged += new System.EventHandler(this.rjToggleButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.PaleGreen;
            this.label5.Location = new System.Drawing.Point(73, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 48);
            this.label5.TabIndex = 20;
            this.label5.Text = "status";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Status
            // 
            this.lbl_Status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Status.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Status.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_Status.Location = new System.Drawing.Point(192, 24);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(174, 44);
            this.lbl_Status.TabIndex = 19;
            this.lbl_Status.Text = "label3";
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.PaleGreen;
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 86);
            this.label2.TabIndex = 16;
            this.label2.Text = "CAMERA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 43);
            this.label1.TabIndex = 14;
            this.label1.Text = "CASA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(377, 560);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rjToggleButton3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rjToggleButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private ToggleButton.RJToggleButton rjToggleButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ToggleButton.RJToggleButton rjToggleButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}