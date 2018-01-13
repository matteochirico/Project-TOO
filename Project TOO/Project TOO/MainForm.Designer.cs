namespace Project_TOO
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.Header = new System.Windows.Forms.Panel();
            this.Label_DisplayName = new System.Windows.Forms.Label();
            this.Picture_Minimize = new System.Windows.Forms.PictureBox();
            this.Picture_Exit = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Placeholder = new System.Windows.Forms.Panel();
            this.Drag_Header = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Timer_Exit = new System.Windows.Forms.Timer(this.components);
            this.Timer_Start = new System.Windows.Forms.Timer(this.components);
            this.Timer_MinimizeOut = new System.Windows.Forms.Timer(this.components);
            this.Timer_MinimizeIn = new System.Windows.Forms.Timer(this.components);
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.Header.Controls.Add(this.Label_DisplayName);
            this.Header.Controls.Add(this.Picture_Minimize);
            this.Header.Controls.Add(this.Picture_Exit);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(534, 40);
            this.Header.TabIndex = 0;
            // 
            // Label_DisplayName
            // 
            this.Label_DisplayName.AutoSize = true;
            this.Label_DisplayName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Label_DisplayName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DisplayName.ForeColor = System.Drawing.Color.White;
            this.Label_DisplayName.Location = new System.Drawing.Point(9, 11);
            this.Label_DisplayName.Name = "Label_DisplayName";
            this.Label_DisplayName.Size = new System.Drawing.Size(0, 18);
            this.Label_DisplayName.TabIndex = 7;
            // 
            // Picture_Minimize
            // 
            this.Picture_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Picture_Minimize.Image = global::Project_TOO.Properties.Resources.Minimize_Application__White_;
            this.Picture_Minimize.Location = new System.Drawing.Point(462, 8);
            this.Picture_Minimize.Name = "Picture_Minimize";
            this.Picture_Minimize.Size = new System.Drawing.Size(25, 25);
            this.Picture_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Minimize.TabIndex = 3;
            this.Picture_Minimize.TabStop = false;
            this.Picture_Minimize.Click += new System.EventHandler(this.Picture_Minimize_Click);
            // 
            // Picture_Exit
            // 
            this.Picture_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Picture_Exit.Image = global::Project_TOO.Properties.Resources.Exit_Application__White_;
            this.Picture_Exit.Location = new System.Drawing.Point(496, 5);
            this.Picture_Exit.Name = "Picture_Exit";
            this.Picture_Exit.Size = new System.Drawing.Size(30, 30);
            this.Picture_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Exit.TabIndex = 2;
            this.Picture_Exit.TabStop = false;
            this.Picture_Exit.Click += new System.EventHandler(this.Picture_Exit_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Panel_Placeholder
            // 
            this.Panel_Placeholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Placeholder.Location = new System.Drawing.Point(0, 40);
            this.Panel_Placeholder.Name = "Panel_Placeholder";
            this.Panel_Placeholder.Size = new System.Drawing.Size(534, 302);
            this.Panel_Placeholder.TabIndex = 3;
            // 
            // Drag_Header
            // 
            this.Drag_Header.Fixed = true;
            this.Drag_Header.Horizontal = true;
            this.Drag_Header.TargetControl = this.Header;
            this.Drag_Header.Vertical = true;
            // 
            // Timer_Exit
            // 
            this.Timer_Exit.Interval = 1;
            this.Timer_Exit.Tick += new System.EventHandler(this.Timer_Exit_Tick);
            // 
            // Timer_Start
            // 
            this.Timer_Start.Interval = 1;
            this.Timer_Start.Tick += new System.EventHandler(this.Timer_Start_Tick);
            // 
            // Timer_MinimizeOut
            // 
            this.Timer_MinimizeOut.Interval = 1;
            this.Timer_MinimizeOut.Tick += new System.EventHandler(this.Timer_MinimizeOut_Tick);
            // 
            // Timer_MinimizeIn
            // 
            this.Timer_MinimizeIn.Interval = 1;
            this.Timer_MinimizeIn.Tick += new System.EventHandler(this.Timer_MinimizeIn_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(534, 342);
            this.Controls.Add(this.Panel_Placeholder);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Panel_Placeholder;
        private Bunifu.Framework.UI.BunifuDragControl Drag_Header;
        private System.Windows.Forms.Timer Timer_Exit;
        private System.Windows.Forms.Timer Timer_Start;
        private System.Windows.Forms.Timer Timer_MinimizeOut;
        private System.Windows.Forms.PictureBox Picture_Minimize;
        private System.Windows.Forms.PictureBox Picture_Exit;
        private System.Windows.Forms.Timer Timer_MinimizeIn;
        public System.Windows.Forms.Label Label_DisplayName;
    }
}

