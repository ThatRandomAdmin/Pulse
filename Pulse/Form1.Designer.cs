
namespace Pulse
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.SettingsBtn = new FontAwesome.Sharp.IconButton();
            this.AppsBtn = new FontAwesome.Sharp.IconButton();
            this.MusicBtn = new FontAwesome.Sharp.IconButton();
            this.HomeBtn = new FontAwesome.Sharp.IconButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuBtn = new FontAwesome.Sharp.IconButton();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new FontAwesome.Sharp.IconButton();
            this.MaximizeBtn = new FontAwesome.Sharp.IconButton();
            this.QuitBtn = new FontAwesome.Sharp.IconButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(110)))));
            this.MenuPanel.Controls.Add(this.SettingsBtn);
            this.MenuPanel.Controls.Add(this.AppsBtn);
            this.MenuPanel.Controls.Add(this.MusicBtn);
            this.MenuPanel.Controls.Add(this.HomeBtn);
            this.MenuPanel.Controls.Add(this.TopPanel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(240, 600);
            this.MenuPanel.TabIndex = 0;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(3)))), ((int)(((byte)(173)))));
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SettingsBtn.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.SettingsBtn.IconColor = System.Drawing.Color.Black;
            this.SettingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.Location = new System.Drawing.Point(0, 528);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.SettingsBtn.Size = new System.Drawing.Size(240, 72);
            this.SettingsBtn.TabIndex = 8;
            this.SettingsBtn.Tag = "Settings";
            this.SettingsBtn.Text = "   Settings";
            this.SettingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // AppsBtn
            // 
            this.AppsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(3)))), ((int)(((byte)(173)))));
            this.AppsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppsBtn.FlatAppearance.BorderSize = 0;
            this.AppsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AppsBtn.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppsBtn.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.AppsBtn.IconColor = System.Drawing.Color.Black;
            this.AppsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AppsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AppsBtn.Location = new System.Drawing.Point(0, 245);
            this.AppsBtn.Name = "AppsBtn";
            this.AppsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AppsBtn.Size = new System.Drawing.Size(240, 72);
            this.AppsBtn.TabIndex = 6;
            this.AppsBtn.Tag = "Apps";
            this.AppsBtn.Text = "   Apps";
            this.AppsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AppsBtn.UseVisualStyleBackColor = false;
            this.AppsBtn.Click += new System.EventHandler(this.AppsBtn_Click);
            // 
            // MusicBtn
            // 
            this.MusicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(3)))), ((int)(((byte)(173)))));
            this.MusicBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MusicBtn.FlatAppearance.BorderSize = 0;
            this.MusicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MusicBtn.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicBtn.IconChar = FontAwesome.Sharp.IconChar.Spotify;
            this.MusicBtn.IconColor = System.Drawing.Color.Black;
            this.MusicBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MusicBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MusicBtn.Location = new System.Drawing.Point(0, 173);
            this.MusicBtn.Name = "MusicBtn";
            this.MusicBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MusicBtn.Size = new System.Drawing.Size(240, 72);
            this.MusicBtn.TabIndex = 5;
            this.MusicBtn.Tag = "Music";
            this.MusicBtn.Text = "   Music";
            this.MusicBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MusicBtn.UseVisualStyleBackColor = false;
            this.MusicBtn.Click += new System.EventHandler(this.MusicBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(3)))), ((int)(((byte)(173)))));
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HomeBtn.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.HomeBtn.IconColor = System.Drawing.Color.Black;
            this.HomeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.Location = new System.Drawing.Point(0, 101);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.HomeBtn.Size = new System.Drawing.Size(240, 72);
            this.HomeBtn.TabIndex = 4;
            this.HomeBtn.Tag = "Home";
            this.HomeBtn.Text = "   Home";
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.MenuBtn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(240, 101);
            this.TopPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pulse\r\nAssistant\r\n";
            // 
            // MenuBtn
            // 
            this.MenuBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MenuBtn.FlatAppearance.BorderSize = 0;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.MenuBtn.IconColor = System.Drawing.Color.Black;
            this.MenuBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuBtn.Location = new System.Drawing.Point(159, 14);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.MenuBtn.Size = new System.Drawing.Size(60, 60);
            this.MenuBtn.TabIndex = 3;
            this.MenuBtn.Tag = "";
            this.MenuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.MinimizeBtn);
            this.HeaderPanel.Controls.Add(this.MaximizeBtn);
            this.HeaderPanel.Controls.Add(this.QuitBtn);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(240, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(760, 30);
            this.HeaderPanel.TabIndex = 100;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(110)))));
            this.MinimizeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MinimizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeBtn.IconColor = System.Drawing.Color.Black;
            this.MinimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeBtn.IconSize = 30;
            this.MinimizeBtn.Location = new System.Drawing.Point(610, 0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Padding = new System.Windows.Forms.Padding(1, 4, 0, 0);
            this.MinimizeBtn.Size = new System.Drawing.Size(50, 30);
            this.MinimizeBtn.TabIndex = 2;
            this.MinimizeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // MaximizeBtn
            // 
            this.MaximizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(110)))));
            this.MaximizeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MaximizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.MaximizeBtn.IconColor = System.Drawing.Color.Black;
            this.MaximizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaximizeBtn.IconSize = 30;
            this.MaximizeBtn.Location = new System.Drawing.Point(660, 0);
            this.MaximizeBtn.Name = "MaximizeBtn";
            this.MaximizeBtn.Padding = new System.Windows.Forms.Padding(1, 4, 0, 0);
            this.MaximizeBtn.Size = new System.Drawing.Size(50, 30);
            this.MaximizeBtn.TabIndex = 1;
            this.MaximizeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MaximizeBtn.UseVisualStyleBackColor = false;
            this.MaximizeBtn.Click += new System.EventHandler(this.MaximizeBtn_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackColor = System.Drawing.Color.Crimson;
            this.QuitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.QuitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QuitBtn.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.QuitBtn.IconColor = System.Drawing.Color.Black;
            this.QuitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.QuitBtn.IconSize = 30;
            this.QuitBtn.Location = new System.Drawing.Point(710, 0);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Padding = new System.Windows.Forms.Padding(1, 4, 0, 0);
            this.QuitBtn.Size = new System.Drawing.Size(50, 30);
            this.QuitBtn.TabIndex = 0;
            this.QuitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.QuitBtn.UseVisualStyleBackColor = false;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(240, 30);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(760, 570);
            this.contentPanel.TabIndex = 101;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(21)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.MenuPanel);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton HomeBtn;
        private System.Windows.Forms.Panel TopPanel;
        private FontAwesome.Sharp.IconButton MenuBtn;
        private FontAwesome.Sharp.IconButton SettingsBtn;
        private FontAwesome.Sharp.IconButton AppsBtn;
        private FontAwesome.Sharp.IconButton MusicBtn;
        private FontAwesome.Sharp.IconButton QuitBtn;
        private FontAwesome.Sharp.IconButton MinimizeBtn;
        private FontAwesome.Sharp.IconButton MaximizeBtn;
        private System.Windows.Forms.Panel contentPanel;
    }
}

