namespace CookieClicker
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            ClickShop = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            MultiShop = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            AutoShop = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            timer2 = new System.Windows.Forms.Timer(components);
            buttonReset = new System.Windows.Forms.Button();
            panelshop = new System.Windows.Forms.Panel();
            buttonCloseShop = new System.Windows.Forms.Button();
            RebirthButton = new System.Windows.Forms.Button();
            RebirthPrice = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panelRebirth = new System.Windows.Forms.Panel();
            butonRebirthShop = new System.Windows.Forms.Button();

            // Controale pentru sunet si volum
            trackBarVolum = new System.Windows.Forms.TrackBar();
            labelVolum = new System.Windows.Forms.Label();
            buttonMuteClick = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(trackBarVolum)).BeginInit();
            SuspendLayout();

            // Butoanele de navigare magazin
            StyleShopButton(ClickShop, "🍪 Click Shop", new System.Drawing.Point(12, 24));
            ClickShop.Name = "ClickShop"; ClickShop.TabIndex = 0; ClickShop.Click += ClickShop_Click;
            ClickShop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;

            StyleShopButton(MultiShop, "✨ Multi Shop", new System.Drawing.Point(12, 78));
            MultiShop.Name = "MultiShop"; MultiShop.TabIndex = 10; MultiShop.Click += MultiShop_Click;
            MultiShop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;

            StyleShopButton(AutoShop, "⚙️ Auto Shop", new System.Drawing.Point(12, 130));
            AutoShop.Name = "AutoShop"; AutoShop.TabIndex = 11; AutoShop.Click += AutoShop_Click_1;
            AutoShop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;

            StyleShopButton(butonRebirthShop, "⭐ Rebirth Shop", new System.Drawing.Point(12, 186));
            butonRebirthShop.Name = "butonRebirthShop"; butonRebirthShop.TabIndex = 0;
            butonRebirthShop.BackColor = System.Drawing.Color.FromArgb(70, 50, 130);
            butonRebirthShop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(95, 70, 165);
            butonRebirthShop.Click += butonRebirthShop_Click;
            butonRebirthShop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;

            // Buton REBIRTH
            RebirthButton.BackColor = System.Drawing.Color.FromArgb(50, 180, 50);
            RebirthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            RebirthButton.FlatAppearance.BorderSize = 0;
            RebirthButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(70, 210, 70);
            RebirthButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(30, 140, 30);
            RebirthButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            RebirthButton.ForeColor = System.Drawing.Color.White;
            RebirthButton.Location = new System.Drawing.Point(898, 24);
            RebirthButton.Name = "RebirthButton";
            RebirthButton.Size = new System.Drawing.Size(130, 38);
            RebirthButton.TabIndex = 16;
            RebirthButton.Text = "🔄 REBIRTH";
            RebirthButton.UseVisualStyleBackColor = false;
            RebirthButton.Cursor = System.Windows.Forms.Cursors.Hand;
            RebirthButton.Click += RebirthButton_Click;
            RebirthButton.Anchor = System.Windows.Forms.AnchorStyles.Top;

            // Buton RESET
            buttonReset.BackColor = System.Drawing.Color.FromArgb(180, 40, 40);
            buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(210, 60, 60);
            buttonReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(140, 20, 20);
            buttonReset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonReset.ForeColor = System.Drawing.Color.White;
            buttonReset.Location = new System.Drawing.Point(1690, 964);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new System.Drawing.Size(175, 42);
            buttonReset.TabIndex = 14;
            buttonReset.Text = "⚠ Reset Progress";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonReset.Click += buttonReset_Click;
            buttonReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;

            // Eticheta volum
            labelVolum.AutoSize = true;
            labelVolum.BackColor = System.Drawing.Color.Transparent;
            labelVolum.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelVolum.ForeColor = System.Drawing.Color.White;
            labelVolum.Location = new System.Drawing.Point(1686, 895);
            labelVolum.Name = "labelVolum";
            labelVolum.Size = new System.Drawing.Size(120, 20);
            labelVolum.TabIndex = 20;
            labelVolum.Text = "🎵 Music Volume";
            labelVolum.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;

            // Bara de volum
            trackBarVolum.BackColor = System.Drawing.Color.FromArgb(40, 30, 20);
            trackBarVolum.Location = new System.Drawing.Point(1690, 920);
            trackBarVolum.Maximum = 100;
            trackBarVolum.Name = "trackBarVolum";
            trackBarVolum.Size = new System.Drawing.Size(175, 45);
            trackBarVolum.TabIndex = 21;
            trackBarVolum.TickFrequency = 10;
            trackBarVolum.Value = 50;
            trackBarVolum.Scroll += new System.EventHandler(trackBarVolum_Scroll);
            trackBarVolum.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;

            // Buton mute click
            buttonMuteClick.BackColor = System.Drawing.Color.FromArgb(45, 110, 185);
            buttonMuteClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonMuteClick.FlatAppearance.BorderSize = 0;
            buttonMuteClick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(70, 140, 210);
            buttonMuteClick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(30, 80, 150);
            buttonMuteClick.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonMuteClick.ForeColor = System.Drawing.Color.White;
            buttonMuteClick.Location = new System.Drawing.Point(1690, 840);
            buttonMuteClick.Name = "buttonMuteClick";
            buttonMuteClick.Size = new System.Drawing.Size(175, 42);
            buttonMuteClick.TabIndex = 22;
            buttonMuteClick.Text = "🔊 Click Sound: ON";
            buttonMuteClick.UseVisualStyleBackColor = false;
            buttonMuteClick.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonMuteClick.Click += new System.EventHandler(buttonMuteClick_Click);
            buttonMuteClick.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;

            // Buton inchidere magazin
            StyleShopButton(buttonCloseShop, "✖ Close Shop", new System.Drawing.Point(12, 531));
            buttonCloseShop.BackColor = System.Drawing.Color.FromArgb(90, 60, 30);
            buttonCloseShop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(120, 80, 40);
            buttonCloseShop.Name = "buttonCloseShop";
            buttonCloseShop.TabIndex = 0;
            buttonCloseShop.Click += buttonCloseShop_Click_1;
            buttonCloseShop.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;

            // Etichete text
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(1598, 18);
            label1.Name = "label1";
            label1.TabIndex = 1;
            label1.Text = "Cookies: 0";
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(1598, 63);
            label2.Name = "label2";
            label2.TabIndex = 13;
            label2.Text = "CPS: 0";
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(1598, 103);
            label3.Name = "label3";
            label3.TabIndex = 0;
            label3.Text = "Rebirth Points: 0";
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            // Pret Rebirth
            RebirthPrice.AutoSize = true;
            RebirthPrice.BackColor = System.Drawing.Color.Transparent;
            RebirthPrice.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RebirthPrice.ForeColor = System.Drawing.Color.Black;
            RebirthPrice.Location = new System.Drawing.Point(904, 71);
            RebirthPrice.Name = "RebirthPrice";
            RebirthPrice.TabIndex = 17;
            RebirthPrice.Text = "RPrice";
            RebirthPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;

            // Panouri
            panelshop.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            panelshop.BackColor = System.Drawing.Color.FromArgb(18, 12, 6);
            panelshop.Location = new System.Drawing.Point(12, 560);
            panelshop.Name = "panelshop";
            panelshop.Size = new System.Drawing.Size(780, 480);
            panelshop.TabIndex = 15;

            panelRebirth.BackColor = System.Drawing.Color.Transparent;
            panelRebirth.Dock = System.Windows.Forms.DockStyle.Fill;
            panelRebirth.Location = new System.Drawing.Point(0, 0);
            panelRebirth.Name = "panelRebirth";
            panelRebirth.Size = new System.Drawing.Size(1904, 1041);
            panelRebirth.TabIndex = 0;
            panelRebirth.Visible = false;

            // Timere
            timer1.Enabled = true; timer1.Interval = 1000; timer1.Tick += timer1_Tick;
            timer2.Enabled = true; timer2.Interval = 30; timer2.Tick += timer2_Tick;

            // Fereastra principala Form1
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1904, 1041);

            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RebirthPrice);
            Controls.Add(labelVolum);
            Controls.Add(trackBarVolum);
            Controls.Add(buttonMuteClick);

            Controls.Add(panelRebirth);
            Controls.Add(butonRebirthShop);
            Controls.Add(RebirthButton);
            Controls.Add(buttonCloseShop);
            Controls.Add(panelshop);
            Controls.Add(buttonReset);
            Controls.Add(AutoShop);
            Controls.Add(MultiShop);
            Controls.Add(ClickShop);

            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Cookie Clicker";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
            Resize += Form1_Resize;

            ((System.ComponentModel.ISupportInitialize)(trackBarVolum)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private static void StyleShopButton(System.Windows.Forms.Button btn, string text, System.Drawing.Point location)
        {
            btn.BackColor = System.Drawing.Color.FromArgb(180, 120, 40);
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(210, 150, 60);
            btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(140, 90, 20);
            btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Location = location;
            btn.Size = new System.Drawing.Size(122, 36);
            btn.Text = text;
            btn.UseVisualStyleBackColor = false;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        #endregion

        private System.Windows.Forms.Button ClickShop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MultiShop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button AutoShop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Panel panelshop;
        private System.Windows.Forms.Button buttonCloseShop;
        private System.Windows.Forms.Button RebirthButton;
        private System.Windows.Forms.Label RebirthPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelRebirth;
        private System.Windows.Forms.Button butonRebirthShop;
        private System.Windows.Forms.TrackBar trackBarVolum;
        private System.Windows.Forms.Label labelVolum;
        private System.Windows.Forms.Button buttonMuteClick;
    }
}