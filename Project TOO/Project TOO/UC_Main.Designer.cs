namespace Project_TOO
{
    partial class UC_Main
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
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Start = new System.Windows.Forms.Panel();
            this.Picture_Start = new System.Windows.Forms.PictureBox();
            this.Label_Start = new System.Windows.Forms.Label();
            this.Elipse_Start = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Log = new System.Windows.Forms.Panel();
            this.Picture_Log = new System.Windows.Forms.PictureBox();
            this.Label_Log = new System.Windows.Forms.Label();
            this.Elipse_Log = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Panel_Start.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Start)).BeginInit();
            this.Panel_Log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(75)))));
            this.Title.Location = new System.Drawing.Point(160, 91);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(214, 25);
            this.Title.TabIndex = 6;
            this.Title.Text = "Digital Gangeprøve";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(202, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hva vil du gjøre?";
            // 
            // Panel_Start
            // 
            this.Panel_Start.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel_Start.Controls.Add(this.Picture_Start);
            this.Panel_Start.Controls.Add(this.Label_Start);
            this.Panel_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Start.Location = new System.Drawing.Point(184, 161);
            this.Panel_Start.Name = "Panel_Start";
            this.Panel_Start.Size = new System.Drawing.Size(167, 42);
            this.Panel_Start.TabIndex = 10;
            this.Panel_Start.MouseEnter += new System.EventHandler(this.Panel_Start_MouseEnter);
            this.Panel_Start.MouseLeave += new System.EventHandler(this.Panel_Start_MouseLeave);
            // 
            // Picture_Start
            // 
            this.Picture_Start.Image = global::Project_TOO.Properties.Resources.Start_Test__DimGray_;
            this.Picture_Start.Location = new System.Drawing.Point(7, 6);
            this.Picture_Start.Name = "Picture_Start";
            this.Picture_Start.Size = new System.Drawing.Size(30, 30);
            this.Picture_Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Start.TabIndex = 11;
            this.Picture_Start.TabStop = false;
            this.Picture_Start.Click += new System.EventHandler(this.StartTest_Click);
            this.Picture_Start.MouseEnter += new System.EventHandler(this.Panel_Start_MouseEnter);
            this.Picture_Start.MouseLeave += new System.EventHandler(this.Panel_Start_MouseLeave);
            // 
            // Label_Start
            // 
            this.Label_Start.AutoSize = true;
            this.Label_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Start.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(75)))));
            this.Label_Start.Location = new System.Drawing.Point(41, 12);
            this.Label_Start.Name = "Label_Start";
            this.Label_Start.Size = new System.Drawing.Size(100, 18);
            this.Label_Start.TabIndex = 6;
            this.Label_Start.Text = "Starte en test";
            this.Label_Start.Click += new System.EventHandler(this.StartTest_Click);
            this.Label_Start.MouseEnter += new System.EventHandler(this.Panel_Start_MouseEnter);
            this.Label_Start.MouseLeave += new System.EventHandler(this.Panel_Start_MouseLeave);
            // 
            // Elipse_Start
            // 
            this.Elipse_Start.ElipseRadius = 25;
            this.Elipse_Start.TargetControl = this.Panel_Start;
            // 
            // Panel_Log
            // 
            this.Panel_Log.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel_Log.Controls.Add(this.Picture_Log);
            this.Panel_Log.Controls.Add(this.Label_Log);
            this.Panel_Log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Log.Location = new System.Drawing.Point(184, 209);
            this.Panel_Log.Name = "Panel_Log";
            this.Panel_Log.Size = new System.Drawing.Size(167, 42);
            this.Panel_Log.TabIndex = 12;
            this.Panel_Log.Click += new System.EventHandler(this.Panel_Log_Click);
            this.Panel_Log.MouseEnter += new System.EventHandler(this.Panel_Log_MouseEnter);
            this.Panel_Log.MouseLeave += new System.EventHandler(this.Panel_Log_MouseLeave);
            // 
            // Picture_Log
            // 
            this.Picture_Log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Picture_Log.Image = global::Project_TOO.Properties.Resources.History__DimGray_;
            this.Picture_Log.Location = new System.Drawing.Point(7, 6);
            this.Picture_Log.Name = "Picture_Log";
            this.Picture_Log.Size = new System.Drawing.Size(30, 30);
            this.Picture_Log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Log.TabIndex = 11;
            this.Picture_Log.TabStop = false;
            this.Picture_Log.Click += new System.EventHandler(this.Log_Clicked);
            this.Picture_Log.MouseEnter += new System.EventHandler(this.Panel_Log_MouseEnter);
            this.Picture_Log.MouseLeave += new System.EventHandler(this.Panel_Log_MouseLeave);
            // 
            // Label_Log
            // 
            this.Label_Log.AutoSize = true;
            this.Label_Log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Log.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(75)))));
            this.Label_Log.Location = new System.Drawing.Point(41, 12);
            this.Label_Log.Name = "Label_Log";
            this.Label_Log.Size = new System.Drawing.Size(107, 18);
            this.Label_Log.TabIndex = 6;
            this.Label_Log.Text = "Se på loggen";
            this.Label_Log.Click += new System.EventHandler(this.Log_Clicked);
            this.Label_Log.MouseEnter += new System.EventHandler(this.Panel_Log_MouseEnter);
            this.Label_Log.MouseLeave += new System.EventHandler(this.Panel_Log_MouseLeave);
            // 
            // Elipse_Log
            // 
            this.Elipse_Log.ElipseRadius = 25;
            this.Elipse_Log.TargetControl = this.Panel_Log;
            // 
            // Logo
            // 
            this.Logo.Image = global::Project_TOO.Properties.Resources.Application_Icon__DimGray_;
            this.Logo.Location = new System.Drawing.Point(222, -1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(90, 90);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 5;
            this.Logo.TabStop = false;
            // 
            // UC_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Panel_Log);
            this.Controls.Add(this.Panel_Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Logo);
            this.Name = "UC_Main";
            this.Size = new System.Drawing.Size(534, 302);
            this.Panel_Start.ResumeLayout(false);
            this.Panel_Start.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Start)).EndInit();
            this.Panel_Log.ResumeLayout(false);
            this.Panel_Log.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel_Start;
        private System.Windows.Forms.PictureBox Picture_Start;
        private System.Windows.Forms.Label Label_Start;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Start;
        private System.Windows.Forms.Panel Panel_Log;
        private System.Windows.Forms.PictureBox Picture_Log;
        private System.Windows.Forms.Label Label_Log;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Log;
    }
}
