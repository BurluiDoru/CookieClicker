namespace CookieClicker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
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
            SuspendLayout();
            // 
            // ClickShop
            // 
            ClickShop.BackColor = Color.Transparent;
            ClickShop.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ClickShop.Location = new Point(12, 24);
            ClickShop.Margin = new Padding(3, 2, 3, 2);
            ClickShop.Name = "ClickShop";
            ClickShop.Size = new Size(105, 30);
            ClickShop.TabIndex = 0;
            ClickShop.Text = "Click Shop";
            ClickShop.UseVisualStyleBackColor = false;
            ClickShop.Click += ClickShop_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1627, 21);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 1;
            label1.Text = "Cookies: 0";
            // 
            // MultiShop
            // 
            MultiShop.BackColor = Color.Transparent;
            MultiShop.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            MultiShop.Location = new Point(12, 78);
            MultiShop.Margin = new Padding(3, 2, 3, 2);
            MultiShop.Name = "MultiShop";
            MultiShop.Size = new Size(105, 30);
            MultiShop.TabIndex = 10;
            MultiShop.Text = "Multi Shop";
            MultiShop.UseVisualStyleBackColor = false;
            MultiShop.Click += MultiShop_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // AutoShop
            // 
            AutoShop.BackColor = Color.Transparent;
            AutoShop.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AutoShop.Location = new Point(12, 130);
            AutoShop.Name = "AutoShop";
            AutoShop.Size = new Size(105, 30);
            AutoShop.TabIndex = 11;
            AutoShop.Text = "Auto Shop";
            AutoShop.UseVisualStyleBackColor = false;
            AutoShop.Click += AutoShop_Click_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1627, 75);
            label2.Name = "label2";
            label2.Size = new Size(59, 30);
            label2.TabIndex = 13;
            label2.Text = "CPS:";
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 30;
            timer2.Tick += timer2_Tick;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.Red;
            buttonReset.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReset.Location = new Point(1680, 964);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(183, 43);
            buttonReset.TabIndex = 14;
            buttonReset.Text = "Reset Progress";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // panelshop
            // 
            panelshop.BackColor = SystemColors.ControlLight;
            panelshop.Location = new Point(12, 560);
            panelshop.Name = "panelshop";
            panelshop.Size = new Size(780, 480);
            panelshop.TabIndex = 15;
            // 
            // buttonCloseShop
            // 
            buttonCloseShop.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCloseShop.Location = new Point(12, 531);
            buttonCloseShop.Name = "buttonCloseShop";
            buttonCloseShop.Size = new Size(105, 30);
            buttonCloseShop.TabIndex = 0;
            buttonCloseShop.Text = "Close Shop";
            buttonCloseShop.UseVisualStyleBackColor = true;
            buttonCloseShop.Click += buttonCloseShop_Click_1;
            // 
            // RebirthButton
            // 
            RebirthButton.BackColor = Color.Transparent;
            RebirthButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RebirthButton.ForeColor = SystemColors.ControlText;
            RebirthButton.Location = new Point(898, 24);
            RebirthButton.Name = "RebirthButton";
            RebirthButton.Size = new Size(105, 30);
            RebirthButton.TabIndex = 16;
            RebirthButton.Text = "REBIRTH";
            RebirthButton.UseVisualStyleBackColor = false;
            RebirthButton.Click += RebirthButton_Click;
            // 
            // RebirthPrice
            // 
            RebirthPrice.AutoSize = true;
            RebirthPrice.BackColor = Color.Transparent;
            RebirthPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RebirthPrice.Location = new Point(898, 57);
            RebirthPrice.Name = "RebirthPrice";
            RebirthPrice.Size = new Size(53, 20);
            RebirthPrice.TabIndex = 17;
            RebirthPrice.Text = "RPrice";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1627, 130);
            label3.Name = "label3";
            label3.Size = new Size(91, 30);
            label3.TabIndex = 0;
            label3.Text = "RPoints";
            // 
            // panelRebirth
            // 
            panelRebirth.BackColor = Color.Transparent;
            panelRebirth.Dock = DockStyle.Fill;
            panelRebirth.Location = new Point(0, 0);
            panelRebirth.Name = "panelRebirth";
            panelRebirth.Size = new Size(1904, 1041);
            panelRebirth.TabIndex = 0;
            panelRebirth.Visible = false;
            // 
            // butonRebirthShop
            // 
            butonRebirthShop.AutoSize = true;
            butonRebirthShop.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            butonRebirthShop.Location = new Point(12, 186);
            butonRebirthShop.Name = "butonRebirthShop";
            butonRebirthShop.Size = new Size(110, 30);
            butonRebirthShop.TabIndex = 0;
            butonRebirthShop.Text = "Rebirth Shop";
            butonRebirthShop.UseVisualStyleBackColor = true;
            butonRebirthShop.Click += butonRebirthShop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panelRebirth);
            Controls.Add(butonRebirthShop);
            Controls.Add(label3);
            Controls.Add(RebirthPrice);
            Controls.Add(RebirthButton);
            Controls.Add(buttonCloseShop);
            Controls.Add(panelshop);
            Controls.Add(buttonReset);
            Controls.Add(label2);
            Controls.Add(AutoShop);
            Controls.Add(MultiShop);
            Controls.Add(label1);
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
    }
}