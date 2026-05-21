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
            label1Title = new Label();
            label1 = new Label();
            label1Nr = new Label();
            panel2 = new Panel();
            label2Title = new Label();
            label2 = new Label();
            label2Nr = new Label();
            panel3 = new Panel();
            label3Title = new Label();
            label3 = new Label();
            label3Nr = new Label();
            clipPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();

            // 
            // clipPanel
            // 
            clipPanel.BackColor = Color.Transparent;
            clipPanel.Controls.Add(flowLayoutPanel1);
            clipPanel.Location = new Point(1, 311);
            clipPanel.Name = "clipPanel";
            clipPanel.Size = new Size(765, 76);
            clipPanel.TabIndex = 0;

            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(765, 76);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;

            // 
            // panel1
            // 
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 70);
            panel1.TabIndex = 1;
            panel1.Tag = "0";
            panel1.Click += panel1_Click;

            // 
            // label1Title
            // 
            label1Title.Location = new Point(0, 0);
            label1Title.Name = "label1Title";
            label1Title.Size = new Size(100, 23);
            label1Title.TabIndex = 0;
            label1Title.Click += panel1_Click;

            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Click += panel1_Click;

            // 
            // label1Nr
            // 
            label1Nr.Location = new Point(0, 0);
            label1Nr.Name = "label1Nr";
            label1Nr.Size = new Size(100, 23);
            label1Nr.TabIndex = 0;
            label1Nr.Click += panel1_Click;

            // 
            // panel2
            // 
            panel2.Location = new Point(254, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(245, 70);
            panel2.TabIndex = 2;
            panel2.Tag = "1";
            panel2.Click += panel2_Click;

            // 
            // label2Title
            // 
            label2Title.Location = new Point(0, 0);
            label2Title.Name = "label2Title";
            label2Title.Size = new Size(100, 23);
            label2Title.TabIndex = 0;
            label2Title.Click += panel2_Click;

            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            label2.Click += panel2_Click;

            // 
            // label2Nr
            // 
            label2Nr.Location = new Point(0, 0);
            label2Nr.Name = "label2Nr";
            label2Nr.Size = new Size(100, 23);
            label2Nr.TabIndex = 0;
            label2Nr.Click += panel2_Click;

            // 
            // panel3
            // 
            panel3.Location = new Point(505, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 70);
            panel3.TabIndex = 3;
            panel3.Tag = "2";
            panel3.Click += panel3_Click;

            // 
            // label3Title
            // 
            label3Title.Location = new Point(0, 0);
            label3Title.Name = "label3Title";
            label3Title.Size = new Size(100, 23);
            label3Title.TabIndex = 0;
            label3Title.Click += panel3_Click;

            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            label3.Click += panel3_Click;

            // 
            // label3Nr
            // 
            label3Nr.Location = new Point(0, 0);
            label3Nr.Name = "label3Nr";
            label3Nr.Size = new Size(100, 23);
            label3Nr.TabIndex = 0;
            label3Nr.Click += panel3_Click;

            // 
            // ClickShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(764, 442);
            Controls.Add(clipPanel);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label1Title;
        private Label label1;
        private Label label1Nr;
        private Panel panel2;
        private Label label2Title;
        private Label label2;
        private Label label2Nr;
        private Panel panel3;
        private Label label3Title;
        private Label label3;
        private Label label3Nr;
    }
}