namespace CookieClicker
{
    partial class MultiShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiShop));
            clipPanel = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel(); label1Title = new Label(); label1 = new Label(); label1Nr = new Label();
            panel2 = new Panel(); label2Title = new Label(); label2 = new Label(); label2Nr = new Label();
            panel3 = new Panel(); label3Title = new Label(); label3 = new Label(); label3Nr = new Label();
            panel4 = new Panel(); label4Title = new Label(); label4 = new Label(); label4Nr = new Label();

            clipPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout(); panel2.SuspendLayout();
            panel3.SuspendLayout(); panel4.SuspendLayout();
            SuspendLayout();

            // ── clipPanel ─────────────────────────────────────────
            clipPanel.AutoScroll = false;
            clipPanel.BackColor = Color.Transparent;
            clipPanel.Location = new Point(1, 311);
            clipPanel.Size = new Size(765, 76);
            clipPanel.Name = "clipPanel";
            clipPanel.TabIndex = 0;
            clipPanel.Controls.Add(flowLayoutPanel1);

            // ── flowLayoutPanel1 ───────────────────────────────────
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(765, 76);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);

            // ── panel1: Multi 2× ───────────────────────────────────
            panel1.Name = "panel1"; panel1.TabIndex = 1; panel1.Tag = "0";
            panel1.Click += panel1_Click; label1Title.Click += panel1_Click;
            label1.Click += panel1_Click; label1Nr.Click += panel1_Click;

            // ── panel2: Multi 5× ───────────────────────────────────
            panel2.Name = "panel2"; panel2.TabIndex = 2; panel2.Tag = "1";
            panel2.Click += panel2_Click; label2Title.Click += panel2_Click;
            label2.Click += panel2_Click; label2Nr.Click += panel2_Click;

            // ── panel3: Multi 10× ──────────────────────────────────
            panel3.Name = "panel3"; panel3.TabIndex = 3; panel3.Tag = "2";
            panel3.Click += panel3_Click; label3Title.Click += panel3_Click;
            label3.Click += panel3_Click; label3Nr.Click += panel3_Click;

            // ── panel4: Multi 25× ──────────────────────────────────
            panel4.Name = "panel4"; panel4.TabIndex = 4; panel4.Tag = "3";
            panel4.Click += panel4_Click; label4Title.Click += panel4_Click;
            label4.Click += panel4_Click; label4Nr.Click += panel4_Click;

            // ── MultiShop Form ─────────────────────────────────────
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(764, 441);
            Controls.Add(clipPanel);
            DoubleBuffered = true;
            Name = "MultiShop";
            Text = "Multiplier Shop";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false); panel1.PerformLayout();
            panel2.ResumeLayout(false); panel2.PerformLayout();
            panel3.ResumeLayout(false); panel3.PerformLayout();
            panel4.ResumeLayout(false); panel4.PerformLayout();
            clipPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel clipPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1; private Label label1Title; private Label label1; private Label label1Nr;
        private Panel panel2; private Label label2Title; private Label label2; private Label label2Nr;
        private Panel panel3; private Label label3Title; private Label label3; private Label label3Nr;
        private Panel panel4; private Label label4Title; private Label label4; private Label label4Nr;
    }
}