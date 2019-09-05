namespace helloWorldKaelan
{
    partial class frmHelloWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelloWorld));
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblGreeting2 = new System.Windows.Forms.Label();
            this.lblSignature = new System.Windows.Forms.Label();
            this.picBeanos = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.picBeanos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(1650, 873);
            this.lblGreeting.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(275, 33);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, World!";
            // 
            // lblGreeting2
            // 
            this.lblGreeting2.AutoSize = true;
            this.lblGreeting2.Font = new System.Drawing.Font("Monotxt_IV50", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGreeting2.Location = new System.Drawing.Point(369, 159);
            this.lblGreeting2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblGreeting2.Name = "lblGreeting2";
            this.lblGreeting2.Size = new System.Drawing.Size(522, 66);
            this.lblGreeting2.TabIndex = 1;
            this.lblGreeting2.Text = "Hello, World!";
            this.lblGreeting2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Font = new System.Drawing.Font("Monotxt_IV50", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignature.Location = new System.Drawing.Point(397, 291);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(445, 60);
            this.lblSignature.TabIndex = 2;
            this.lblSignature.Text = "By Kaelan K.";
            // 
            // picBeanos
            // 
            this.picBeanos.Image = ((System.Drawing.Image)(resources.GetObject("picBeanos.Image")));
            this.picBeanos.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBeanos.InitialImage")));
            this.picBeanos.Location = new System.Drawing.Point(345, 368);
            this.picBeanos.Name = "picBeanos";
            this.picBeanos.Size = new System.Drawing.Size(522, 302);
            this.picBeanos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBeanos.TabIndex = 3;
            this.picBeanos.TabStop = false;
            this.picBeanos.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1331, 709);
            this.Controls.Add(this.picBeanos);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.lblGreeting2);
            this.Controls.Add(this.lblGreeting);
            this.Font = new System.Drawing.Font("Monotxt_IV50", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.Name = "frmHelloWorld";
            this.Text = "Hello, World! By Kaelan";
            this.Load += new System.EventHandler(this.HelloWorldKaelan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBeanos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblGreeting2;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.PictureBox picBeanos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

