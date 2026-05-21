namespace CookieClicker
{
    partial class RebirthShop
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RebirthShop));
            butonInapoi = new Button();
            button1 = new Button();
            label1 = new Label();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // butonInapoi
            // 
            butonInapoi.BackColor = Color.FromArgb(70, 60, 50);
            butonInapoi.Cursor = Cursors.Hand;
            butonInapoi.FlatAppearance.BorderSize = 0;
            butonInapoi.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 42, 34);
            butonInapoi.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 85, 65);
            butonInapoi.FlatStyle = FlatStyle.Flat;
            butonInapoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            butonInapoi.ForeColor = Color.White;
            butonInapoi.Location = new Point(12, 12);
            butonInapoi.Name = "butonInapoi";
            butonInapoi.Size = new Size(90, 32);
            butonInapoi.TabIndex = 0;
            butonInapoi.Text = "← Back";
            butonInapoi.UseVisualStyleBackColor = false;
            butonInapoi.Click += butonInapoi_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(40, 10, 60);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(120, 40, 180);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 5, 40);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 20, 100);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(200, 140, 255);
            button1.Location = new Point(330, 245);
            button1.Name = "button1";
            button1.Size = new Size(110, 56);
            button1.TabIndex = 1;
            button1.Text = "🔮 SECRET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(200, 180, 240);
            label1.Location = new Point(330, 308);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 2;
            label1.Text = "Cost: 1000 Rebirth Points";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(512, 92);
            webView21.Name = "webView21";
            webView21.Size = new Size(265, 266);
            webView21.TabIndex = 3;
            webView21.ZoomFactor = 1D;
            // 
            // RebirthShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(webView21);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(butonInapoi);
            Name = "RebirthShop";
            Text = "Rebirth Shop";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butonInapoi;
        private Button button1;
        private Label label1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}
