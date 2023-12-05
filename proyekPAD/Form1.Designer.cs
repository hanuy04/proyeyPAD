
namespace proyekPAD
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
            this.buttonMaster = new System.Windows.Forms.Button();
            this.buttonKasir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMaster
            // 
            this.buttonMaster.BackColor = System.Drawing.Color.White;
            this.buttonMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaster.Location = new System.Drawing.Point(12, 32);
            this.buttonMaster.Name = "buttonMaster";
            this.buttonMaster.Size = new System.Drawing.Size(172, 40);
            this.buttonMaster.TabIndex = 0;
            this.buttonMaster.Text = "Master";
            this.buttonMaster.UseVisualStyleBackColor = false;
            this.buttonMaster.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonKasir
            // 
            this.buttonKasir.BackColor = System.Drawing.Color.White;
            this.buttonKasir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKasir.Location = new System.Drawing.Point(12, 93);
            this.buttonKasir.Name = "buttonKasir";
            this.buttonKasir.Size = new System.Drawing.Size(172, 40);
            this.buttonKasir.TabIndex = 1;
            this.buttonKasir.Text = "Kasir";
            this.buttonKasir.UseVisualStyleBackColor = false;
            this.buttonKasir.Click += new System.EventHandler(this.buttonKasir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 164);
            this.Controls.Add(this.buttonKasir);
            this.Controls.Add(this.buttonMaster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMaster;
        private System.Windows.Forms.Button buttonKasir;
    }
}

