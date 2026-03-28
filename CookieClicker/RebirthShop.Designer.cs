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
            // RebirthShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(butonInapoi);
            Name = "RebirthShop";
            Text = "RebirthShop";
            ResumeLayout(false);
        }

        #endregion

        private Button butonInapoi;
    }
}