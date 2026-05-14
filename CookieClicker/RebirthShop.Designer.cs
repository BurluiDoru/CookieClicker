namespace CookieClicker
{
    partial class RebirthShop
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
            butonInapoi.Location = new Point(12, 12);
            butonInapoi.Name = "butonInapoi";
            butonInapoi.Size = new Size(75, 23);
            butonInapoi.TabIndex = 0;
            butonInapoi.Text = "Inapoi";
            butonInapoi.UseVisualStyleBackColor = true;
            butonInapoi.Click += butonInapoi_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(338, 251);
            button1.Name = "button1";
            button1.Size = new Size(93, 57);
            button1.TabIndex = 1;
            button1.Text = "SECRET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(338, 311);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 2;
            label1.Text = "Pret:1000 Rebirt Points";
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
            Text = "RebirthShop";
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