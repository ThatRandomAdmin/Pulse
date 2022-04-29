
namespace Pulse.Content.Home
{
    partial class HomeMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.refreshBtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.label1.Size = new System.Drawing.Size(314, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome home, ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(30, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(211, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Todays News:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(21)))), ((int)(((byte)(110)))));
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 111);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(752, 456);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(3)))), ((int)(((byte)(173)))));
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshBtn.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.refreshBtn.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.refreshBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.refreshBtn.IconSize = 25;
            this.refreshBtn.Location = new System.Drawing.Point(727, 75);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.refreshBtn.Size = new System.Drawing.Size(30, 30);
            this.refreshBtn.TabIndex = 4;
            this.refreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // HomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(21)))), ((int)(((byte)(110)))));
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "HomeMenu";
            this.Size = new System.Drawing.Size(760, 570);
            this.Load += new System.EventHandler(this.HomeMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton refreshBtn;
    }
}
