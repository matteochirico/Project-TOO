namespace Project_TOO
{
    partial class UC_TestConfiguration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = global::Project_TOO.Properties.Resources.Application_Icon__DimGray_;
            this.Logo.Location = new System.Drawing.Point(214, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(90, 90);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 4;
            this.Logo.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(75)))));
            this.Title.Location = new System.Drawing.Point(132, 96);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(288, 25);
            this.Title.TabIndex = 5;
            this.Title.Text = "Gangeprøve Konfigurasjon";
            // 
            // UC_TestConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Logo);
            this.Name = "UC_TestConfiguration";
            this.Size = new System.Drawing.Size(534, 302);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Title;
    }
}
