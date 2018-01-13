namespace Project_TOO
{
    partial class UC_Startscreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Startscreen));
            this.Title = new System.Windows.Forms.Label();
            this.Panel_Textbox = new System.Windows.Forms.Panel();
            this.Label_Textbox = new System.Windows.Forms.Label();
            this.Textbox = new System.Windows.Forms.TextBox();
            this.Elipse_Textbox = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Elipse_Button = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Button_Proceed = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Panel_Textbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(160, 91);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(214, 25);
            this.Title.TabIndex = 4;
            this.Title.Text = "Digital Gangeprøve";
            // 
            // Panel_Textbox
            // 
            this.Panel_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.Panel_Textbox.Controls.Add(this.Label_Textbox);
            this.Panel_Textbox.Controls.Add(this.Textbox);
            this.Panel_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Panel_Textbox.Location = new System.Drawing.Point(165, 151);
            this.Panel_Textbox.Name = "Panel_Textbox";
            this.Panel_Textbox.Size = new System.Drawing.Size(209, 48);
            this.Panel_Textbox.TabIndex = 5;
            this.Panel_Textbox.Click += new System.EventHandler(this.Textbox_Click);
            // 
            // Label_Textbox
            // 
            this.Label_Textbox.AutoSize = true;
            this.Label_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Label_Textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Textbox.ForeColor = System.Drawing.Color.White;
            this.Label_Textbox.Location = new System.Drawing.Point(7, 4);
            this.Label_Textbox.Name = "Label_Textbox";
            this.Label_Textbox.Size = new System.Drawing.Size(46, 16);
            this.Label_Textbox.TabIndex = 6;
            this.Label_Textbox.Text = "Navn:";
            this.Label_Textbox.Click += new System.EventHandler(this.Textbox_Click);
            // 
            // Textbox
            // 
            this.Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox.ForeColor = System.Drawing.Color.White;
            this.Textbox.Location = new System.Drawing.Point(9, 23);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(195, 19);
            this.Textbox.TabIndex = 0;
            this.Textbox.Click += new System.EventHandler(this.Textbox_Click);
            // 
            // Elipse_Textbox
            // 
            this.Elipse_Textbox.ElipseRadius = 25;
            this.Elipse_Textbox.TargetControl = this.Panel_Textbox;
            // 
            // Elipse_Button
            // 
            this.Elipse_Button.ElipseRadius = 20;
            this.Elipse_Button.TargetControl = this.Button_Proceed;
            // 
            // Button_Proceed
            // 
            this.Button_Proceed.ActiveBorderThickness = 1;
            this.Button_Proceed.ActiveCornerRadius = 20;
            this.Button_Proceed.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.Button_Proceed.ActiveForecolor = System.Drawing.Color.Silver;
            this.Button_Proceed.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.Button_Proceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Button_Proceed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Proceed.BackgroundImage")));
            this.Button_Proceed.ButtonText = "Fortsett";
            this.Button_Proceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Proceed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Proceed.ForeColor = System.Drawing.Color.White;
            this.Button_Proceed.IdleBorderThickness = 1;
            this.Button_Proceed.IdleCornerRadius = 20;
            this.Button_Proceed.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.Button_Proceed.IdleForecolor = System.Drawing.Color.White;
            this.Button_Proceed.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.Button_Proceed.Location = new System.Drawing.Point(188, 209);
            this.Button_Proceed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Proceed.Name = "Button_Proceed";
            this.Button_Proceed.Size = new System.Drawing.Size(163, 37);
            this.Button_Proceed.TabIndex = 7;
            this.Button_Proceed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Proceed.Click += new System.EventHandler(this.Procced_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::Project_TOO.Properties.Resources.Application_Icon__White_;
            this.Logo.Location = new System.Drawing.Point(222, -1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(90, 90);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // UC_Startscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.Button_Proceed);
            this.Controls.Add(this.Panel_Textbox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Logo);
            this.Name = "UC_Startscreen";
            this.Size = new System.Drawing.Size(534, 302);
            this.Panel_Textbox.ResumeLayout(false);
            this.Panel_Textbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel Panel_Textbox;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Textbox;
        private System.Windows.Forms.TextBox Textbox;
        private System.Windows.Forms.Label Label_Textbox;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_Proceed;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Button;
    }
}
