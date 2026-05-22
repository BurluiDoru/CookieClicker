namespace CookieClicker
{
    partial class ClickShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClickShop));
            clipPanel = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label1Nr = new Label();
            label1 = new Label();
            label1Title = new Label();
            label2Nr = new Label();
            label2 = new Label();
            label2Title = new Label();
            label3Nr = new Label();
            label3 = new Label();
            label3Title = new Label();
            label4Nr = new Label();
            label4 = new Label();
            label4Title = new Label();
            clipPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();

            // clipPanel - Ascunde bara de scroll
            clipPanel.BackColor = Color.Transparent;
            clipPanel.Controls.Add(flowLayoutPanel1);
            clipPanel.Location = new Point(1, 311);
            clipPanel.Name = "clipPanel";
            clipPanel.Size = new Size(765, 80);
            clipPanel.TabIndex = 6;

            // flowLayoutPanel1 - Aranjeaza panourile
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(765, 105);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;

            // Dimensiune fixa pentru toate panourile: 230x74
            // panel1
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 74);
            panel1.TabIndex = 0;
            panel1.Tag = "0";
            panel1.Click += panel1_Click;

            // panel2
            panel2.Location = new Point(239, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 74);
            panel2.TabIndex = 1;
            panel2.Tag = "1";
            panel2.Click += panel2_Click;

            // panel3
            panel3.Location = new Point(475, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 74);
            panel3.TabIndex = 2;
            panel3.Tag = "2";
            panel3.Click += panel3_Click;

            // panel4 (Upgrade-ul de +25 Click)
            panel4.Location = new Point(711, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 74);
            panel4.TabIndex = 3;
            panel4.Tag = "3";
            panel4.Click += panel4_Click;

            // Setari etichete
            label1Nr.Location = new Point(0, 0); label1Nr.Size = new Size(100, 23); label1Nr.Click += panel1_Click;
            label1.Location = new Point(0, 0); label1.Size = new Size(100, 23); label1.Click += panel1_Click;
            label1Title.Location = new Point(0, 0); label1Title.Size = new Size(100, 23); label1Title.Click += panel1_Click;

            label2Nr.Location = new Point(0, 0); label2Nr.Size = new Size(100, 23); label2Nr.Click += panel2_Click;
            label2.Location = new Point(0, 0); label2.Size = new Size(100, 23); label2.Click += panel2_Click;
            label2Title.Location = new Point(0, 0); label2Title.Size = new Size(100, 23); label2Title.Click += panel2_Click;

            label3Nr.Location = new Point(0, 0); label3Nr.Size = new Size(100, 23); label3Nr.Click += panel3_Click;
            label3.Location = new Point(0, 0); label3.Size = new Size(100, 23); label3.Click += panel3_Click;
            label3Title.Location = new Point(0, 0); label3Title.Size = new Size(100, 23); label3Title.Click += panel3_Click;

            label4Nr.Location = new Point(0, 0); label4Nr.Size = new Size(100, 23); label4Nr.Click += panel4_Click;
            label4.Location = new Point(0, 0); label4.Size = new Size(100, 23); label4.Click += panel4_Click;
            label4Title.Location = new Point(0, 0); label4Title.Size = new Size(100, 23); label4Title.Click += panel4_Click;

            // Setari finale fereastra
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(764, 441);
            Controls.Add(clipPanel);
            DoubleBuffered = true;
            Name = "ClickShop";
            Text = "Click Shop";
            clipPanel.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel clipPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label1Nr;
        private Label label1;
        private Label label1Title;
        private Panel panel2;
        private Label label2Nr;
        private Label label2;
        private Label label2Title;
        private Panel panel3;
        private Label label3Nr;
        private Label label3;
        private Label label3Title;
        private Panel panel4;
        private Label label4Nr;
        private Label label4;
        private Label label4Title;
    }
}