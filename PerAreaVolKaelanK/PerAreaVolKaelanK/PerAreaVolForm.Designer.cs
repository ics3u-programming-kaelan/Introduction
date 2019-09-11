namespace PerAreaVolKaelanK
{
    partial class frmPerAreaVol
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
            this.Button1 = new System.Windows.Forms.Button();
            this.btnQArea = new System.Windows.Forms.Button();
            this.btnQVolume = new System.Windows.Forms.Button();
            this.lblAPerimeter = new System.Windows.Forms.Label();
            this.lblAArea = new System.Windows.Forms.Label();
            this.lblAVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(12, 12);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(207, 117);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Calculate the perimeter of a rectangle with the length of 8cm and a width of 5cm";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.BtnQPerimeter_Click);
            // 
            // btnQArea
            // 
            this.btnQArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQArea.Location = new System.Drawing.Point(12, 187);
            this.btnQArea.Name = "btnQArea";
            this.btnQArea.Size = new System.Drawing.Size(207, 101);
            this.btnQArea.TabIndex = 1;
            this.btnQArea.Text = "Calculate the area of a circle with a radius of 7cm";
            this.btnQArea.UseVisualStyleBackColor = true;
            this.btnQArea.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnQVolume
            // 
            this.btnQVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQVolume.Location = new System.Drawing.Point(12, 335);
            this.btnQVolume.Name = "btnQVolume";
            this.btnQVolume.Size = new System.Drawing.Size(207, 103);
            this.btnQVolume.TabIndex = 2;
            this.btnQVolume.Text = "Calculate the volume of a sphere with a radius of 4cm";
            this.btnQVolume.UseVisualStyleBackColor = true;
            this.btnQVolume.Click += new System.EventHandler(this.BtnQVolume_Click);
            // 
            // lblAPerimeter
            // 
            this.lblAPerimeter.AutoSize = true;
            this.lblAPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPerimeter.Location = new System.Drawing.Point(380, 65);
            this.lblAPerimeter.Name = "lblAPerimeter";
            this.lblAPerimeter.Size = new System.Drawing.Size(40, 24);
            this.lblAPerimeter.TabIndex = 3;
            this.lblAPerimeter.Text = "???";
            // 
            // lblAArea
            // 
            this.lblAArea.AutoSize = true;
            this.lblAArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAArea.Location = new System.Drawing.Point(380, 213);
            this.lblAArea.Name = "lblAArea";
            this.lblAArea.Size = new System.Drawing.Size(40, 24);
            this.lblAArea.TabIndex = 4;
            this.lblAArea.Text = "???";
            // 
            // lblAVolume
            // 
            this.lblAVolume.AutoSize = true;
            this.lblAVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAVolume.Location = new System.Drawing.Point(380, 372);
            this.lblAVolume.Name = "lblAVolume";
            this.lblAVolume.Size = new System.Drawing.Size(40, 24);
            this.lblAVolume.TabIndex = 5;
            this.lblAVolume.Text = "???";
            // 
            // frmPerAreaVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAVolume);
            this.Controls.Add(this.lblAArea);
            this.Controls.Add(this.lblAPerimeter);
            this.Controls.Add(this.btnQVolume);
            this.Controls.Add(this.btnQArea);
            this.Controls.Add(this.Button1);
            this.Name = "frmPerAreaVol";
            this.Text = "Perimeter, Area, Volume by Kaelan K";
            this.Load += new System.EventHandler(this.FrmPerAreaVol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button btnQArea;
        private System.Windows.Forms.Button btnQVolume;
        private System.Windows.Forms.Label lblAPerimeter;
        private System.Windows.Forms.Label lblAArea;
        private System.Windows.Forms.Label lblAVolume;
    }
}

