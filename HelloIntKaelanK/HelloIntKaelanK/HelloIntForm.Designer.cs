namespace HelloIntKaelanK
{
    partial class frmHelloInt
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.grbButtons = new System.Windows.Forms.GroupBox();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radFrench = new System.Windows.Forms.RadioButton();
            this.radSpanish = new System.Windows.Forms.RadioButton();
            this.radGerman = new System.Windows.Forms.RadioButton();
            this.grbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.BackColor = System.Drawing.Color.Red;
            this.lblGreeting.Font = new System.Drawing.Font("Swis721 BlkEx BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(299, 85);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(180, 22);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, World!";
            // 
            // grbButtons
            // 
            this.grbButtons.Controls.Add(this.radGerman);
            this.grbButtons.Controls.Add(this.radSpanish);
            this.grbButtons.Controls.Add(this.radFrench);
            this.grbButtons.Controls.Add(this.radEnglish);
            this.grbButtons.Location = new System.Drawing.Point(200, 168);
            this.grbButtons.Name = "grbButtons";
            this.grbButtons.Size = new System.Drawing.Size(381, 114);
            this.grbButtons.TabIndex = 1;
            this.grbButtons.TabStop = false;
            this.grbButtons.Text = "Language Select";
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Location = new System.Drawing.Point(30, 56);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(59, 17);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.RadEnglish_CheckedChanged);
            // 
            // radFrench
            // 
            this.radFrench.AutoSize = true;
            this.radFrench.Location = new System.Drawing.Point(113, 56);
            this.radFrench.Name = "radFrench";
            this.radFrench.Size = new System.Drawing.Size(65, 17);
            this.radFrench.TabIndex = 1;
            this.radFrench.TabStop = true;
            this.radFrench.Text = "Français";
            this.radFrench.UseVisualStyleBackColor = true;
            this.radFrench.CheckedChanged += new System.EventHandler(this.RadFrench_CheckedChanged);
            // 
            // radSpanish
            // 
            this.radSpanish.AutoSize = true;
            this.radSpanish.Location = new System.Drawing.Point(196, 56);
            this.radSpanish.Name = "radSpanish";
            this.radSpanish.Size = new System.Drawing.Size(63, 17);
            this.radSpanish.TabIndex = 2;
            this.radSpanish.TabStop = true;
            this.radSpanish.Text = "Español";
            this.radSpanish.UseVisualStyleBackColor = true;
            this.radSpanish.CheckedChanged += new System.EventHandler(this.RadSpanish_CheckedChanged);
            // 
            // radGerman
            // 
            this.radGerman.AutoSize = true;
            this.radGerman.Location = new System.Drawing.Point(297, 56);
            this.radGerman.Name = "radGerman";
            this.radGerman.Size = new System.Drawing.Size(71, 17);
            this.radGerman.TabIndex = 3;
            this.radGerman.TabStop = true;
            this.radGerman.Text = "Deutsche";
            this.radGerman.UseVisualStyleBackColor = true;
            this.radGerman.CheckedChanged += new System.EventHandler(this.RadGerman_CheckedChanged);
            // 
            // frmHelloInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbButtons);
            this.Controls.Add(this.lblGreeting);
            this.Name = "frmHelloInt";
            this.Text = "Hello, World! International by Kaelan";
            this.Load += new System.EventHandler(this.FrmHelloInt_Load);
            this.grbButtons.ResumeLayout(false);
            this.grbButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.GroupBox grbButtons;
        private System.Windows.Forms.RadioButton radFrench;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radGerman;
        private System.Windows.Forms.RadioButton radSpanish;
    }
}

