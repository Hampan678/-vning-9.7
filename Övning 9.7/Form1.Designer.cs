namespace Övning_9._7
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
            this.lblNivå = new System.Windows.Forms.Label();
            this.tbxUtdata = new System.Windows.Forms.TextBox();
            this.tbxNivå = new System.Windows.Forms.TextBox();
            this.btnVisa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNivå
            // 
            this.lblNivå.AutoSize = true;
            this.lblNivå.Location = new System.Drawing.Point(528, 91);
            this.lblNivå.Name = "lblNivå";
            this.lblNivå.Size = new System.Drawing.Size(29, 13);
            this.lblNivå.TabIndex = 0;
            this.lblNivå.Text = "Nivå";
            // 
            // tbxUtdata
            // 
            this.tbxUtdata.Location = new System.Drawing.Point(285, 91);
            this.tbxUtdata.Multiline = true;
            this.tbxUtdata.Name = "tbxUtdata";
            this.tbxUtdata.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxUtdata.Size = new System.Drawing.Size(231, 216);
            this.tbxUtdata.TabIndex = 1;
            this.tbxUtdata.WordWrap = false;
            // 
            // tbxNivå
            // 
            this.tbxNivå.Location = new System.Drawing.Point(522, 107);
            this.tbxNivå.Name = "tbxNivå";
            this.tbxNivå.Size = new System.Drawing.Size(41, 20);
            this.tbxNivå.TabIndex = 2;
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(522, 284);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(75, 23);
            this.btnVisa.TabIndex = 3;
            this.btnVisa.Text = "Visa";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisa);
            this.Controls.Add(this.tbxNivå);
            this.Controls.Add(this.tbxUtdata);
            this.Controls.Add(this.lblNivå);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNivå;
        private System.Windows.Forms.TextBox tbxUtdata;
        private System.Windows.Forms.TextBox tbxNivå;
        private System.Windows.Forms.Button btnVisa;
    }
}

