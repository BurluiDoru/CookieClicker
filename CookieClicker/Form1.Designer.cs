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
            ClickShop = new Button();
            label1 = new Label();
            MultiShop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            AutoShop = new Button();
            label2 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            buttonReset = new Button();
            panelshop = new Panel();
            buttonCloseShop = new Button();
            RebirthButton = new Button();
            RebirthPrice = new Label();
            label3 = new Label();
            panelRebirth = new Panel();
            butonRebirthShop = new Button();

            // stat panels
            panelCookies = new Panel();
            panelCPS = new Panel();
            panelRebirthPoints = new Panel();
            panelPretRebirth = new Panel();

            SuspendLayout();

            // ── Shop nav buttons ───────────────────────────────────
            StyleShopButton(ClickShop, "🍪 Click Shop",   new Point(12, 24));
            StyleShopButton(MultiShop,        "✨ Multi Shop",   new Point(12, 78));
            StyleShopButton(AutoShop,         "⚙️ Auto Shop",    new Point(12, 130));
            StyleShopButton(butonRebirthShop, "⭐ Rebirth Shop", new Point(12, 186));

            ClickShop.Name       = "ClickShop";       ClickShop.TabIndex  = 0;  ClickShop.Click       += ClickShop_Click;
            MultiShop.Name       = "MultiShop";       MultiShop.TabIndex  = 10; MultiShop.Click       += MultiShop_Click;
            AutoShop.Name        = "AutoShop";         AutoShop.TabIndex  = 11; AutoShop.Click        += AutoShop_Click_1;
            butonRebirthShop.Name = "butonRebirthShop"; butonRebirthShop.TabIndex = 0;
            butonRebirthShop.BackColor = Color.FromArgb(70, 50, 130);
            butonRebirthShop.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 70, 165);
            butonRebirthShop.AutoSize = true;
            butonRebirthShop.Click += butonRebirthShop_Click;

            // ── REBIRTH button ─────────────────────────────────────
            RebirthButton.BackColor = Color.FromArgb(50, 180, 50);
            RebirthButton.FlatStyle = FlatStyle.Flat;
            RebirthButton.FlatAppearance.BorderSize = 0;
            RebirthButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 210, 70);
            RebirthButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 140, 30);
            RebirthButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            RebirthButton.ForeColor = Color.White;
            RebirthButton.Location = new Point(898, 24);
            RebirthButton.Name = "RebirthButton";
            RebirthButton.Size = new Size(130, 38);
            RebirthButton.TabIndex = 16;
            RebirthButton.Text = "🔄 REBIRTH";
            RebirthButton.UseVisualStyleBackColor = false;
            RebirthButton.Cursor = Cursors.Hand;
            RebirthButton.Click += RebirthButton_Click;

            // ── RESET button ───────────────────────────────────────
            buttonReset.BackColor = Color.FromArgb(180, 40, 40);
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 60, 60);
            buttonReset.FlatAppearance.MouseDownBackColor = Color.FromArgb(140, 20, 20);
            buttonReset.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReset.ForeColor = Color.White;
            buttonReset.Location = new Point(1690, 964);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(175, 42);
            buttonReset.TabIndex = 14;
            buttonReset.Text = "⚠ Reset Progress";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Cursor = Cursors.Hand;
            buttonReset.Click += buttonReset_Click;

            // ── Close Shop button ──────────────────────────────────
            StyleShopButton(buttonCloseShop, "✖ Close Shop", new Point(12, 531));
            buttonCloseShop.BackColor = Color.FromArgb(90, 60, 30);
            buttonCloseShop.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 80, 40);
            buttonCloseShop.Name = "buttonCloseShop";
            buttonCloseShop.TabIndex = 0;
            buttonCloseShop.Click += buttonCloseShop_Click_1;

            // ── Stat panels (black) ────────────────────────────────
            StyleStatPanel(panelCookies,       new Point(1590, 12),  280, 40);
            StyleStatPanel(panelCPS,           new Point(1590, 58),  280, 34);
            StyleStatPanel(panelRebirthPoints, new Point(1590, 98),  280, 34);
            StyleStatPanel(panelPretRebirth,   new Point(898, 66),   280, 28);

            // ── label1: Cookies ────────────────────────────────────
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(8, 6);
            label1.Name = "label1"; label1.TabIndex = 1;
            label1.Text = "Cookies: 0";
            panelCookies.Controls.Add(label1);

            // ── label2: CPS ────────────────────────────────────────
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(8, 5);
            label2.Name = "label2"; label2.TabIndex = 13;
            label2.Text = "CPS: 0";
            panelCPS.Controls.Add(label2);

            // ── label3: Rebirth Points ─────────────────────────────
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(8, 5);
            label3.Name = "label3"; label3.TabIndex = 0;
            label3.Text = "Rebirth Points: 0";
            panelRebirthPoints.Controls.Add(label3);

            // ── RebirthPrice ───────────────────────────────────────
            RebirthPrice.AutoSize = true;
            RebirthPrice.BackColor = Color.Transparent;
            RebirthPrice.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            RebirthPrice.ForeColor = Color.Black;
            RebirthPrice.Location = new Point(6, 5);
            RebirthPrice.Name = "RebirthPrice"; RebirthPrice.TabIndex = 17;
            RebirthPrice.Text = "RPrice";
            panelPretRebirth.Controls.Add(RebirthPrice);

            // ── panelshop ──────────────────────────────────────────
            panelshop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelshop.BackColor = Color.FromArgb(18, 12, 6);
            panelshop.Location = new Point(12, 560);
            panelshop.Name = "panelshop";
            panelshop.Size = new Size(780, 480);
            panelshop.TabIndex = 15;

            // ── panelRebirth ───────────────────────────────────────
            panelRebirth.BackColor = Color.Transparent;
            panelRebirth.Dock = DockStyle.Fill;
            panelRebirth.Location = new Point(0, 0);
            panelRebirth.Name = "panelRebirth";
            panelRebirth.Size = new Size(1904, 1041);
            panelRebirth.TabIndex = 0;
            panelRebirth.Visible = false;

            // ── timers ─────────────────────────────────────────────
            timer1.Enabled = true; timer1.Interval = 1000; timer1.Tick += timer1_Tick;
            timer2.Enabled = true; timer2.Interval = 30;   timer2.Tick += timer2_Tick;

            // ── Form1 ──────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panelRebirth);
            Controls.Add(butonRebirthShop);
            Controls.Add(panelRebirthPoints);
            Controls.Add(panelCPS);
            Controls.Add(panelCookies);
            Controls.Add(panelPretRebirth);
            Controls.Add(RebirthButton);
            Controls.Add(buttonCloseShop);
            Controls.Add(panelshop);
            Controls.Add(buttonReset);
            Controls.Add(AutoShop);
            Controls.Add(MultiShop);
            Controls.Add(ClickShop);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Cookie Clicker";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        private static void StyleShopButton(Button btn, string text, Point location)
        {
            btn.BackColor = Color.FromArgb(180, 120, 40);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 150, 60);
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(140, 90, 20);
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn.ForeColor = Color.White;
            btn.Location = location;
            btn.Size = new Size(122, 36);
            btn.Text = text;
            btn.UseVisualStyleBackColor = false;
            btn.Cursor = Cursors.Hand;
        }

        private static void StyleStatPanel(Panel pnl, Point location, int width, int height)
        {
            pnl.BackColor = Color.Transparent;
            pnl.Location = location;
            pnl.Size = new Size(width, height);
            pnl.Padding = new Padding(6, 4, 6, 4);
        }

        #endregion

        private System.Windows.Forms.Button ClickShop;
        private System.Windows.Forms.Label label1;
        private Button MultiShop;
        private System.Windows.Forms.Timer timer1;
        private Button AutoShop;
        private Label label2;
        private System.Windows.Forms.Timer timer2;
        private Button buttonReset;
        private Panel panelshop;
        private Button buttonCloseShop;
        private Button RebirthButton;
        private Label RebirthPrice;
        private Label label3;
        private Panel panelRebirth;
        private Button butonRebirthShop;
        private Panel panelCookies;
        private Panel panelCPS;
        private Panel panelRebirthPoints;
        private Panel panelPretRebirth;
    }
}
