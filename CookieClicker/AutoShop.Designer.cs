namespace CookieClicker
{
    partial class AutoShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoShop));
            cps1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cps2 = new Button();
            cps3 = new Button();
            SuspendLayout();
            // 
            // cps1
            // 
            cps1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cps1.Location = new Point(43, 321);
            cps1.Name = "cps1";
            cps1.Size = new Size(127, 40);
            cps1.TabIndex = 0;
            cps1.Text = "+1 CPS";
            cps1.UseVisualStyleBackColor = true;
            cps1.Click += cps1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(43, 364);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(299, 364);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(553, 364);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // cps2
            // 
            cps2.Anchor = AnchorStyles.Bottom;
            cps2.Location = new Point(299, 321);
            cps2.Name = "cps2";
            cps2.Size = new Size(127, 40);
            cps2.TabIndex = 4;
            cps2.Text = "+5 CPS";
            cps2.UseVisualStyleBackColor = true;
            cps2.Click += cps2_Click_1;
            // 
            // cps3
            // 
            cps3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cps3.Location = new Point(553, 321);
            cps3.Name = "cps3";
            cps3.Size = new Size(127, 40);
            cps3.TabIndex = 5;
            cps3.Text = "+10 CPS";
            cps3.UseVisualStyleBackColor = true;
            cps3.Click += cps3_Click_1;
            // 
            // AutoShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(764, 441);
            Controls.Add(cps3);
            Controls.Add(cps2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cps1);
            DoubleBuffered = true;
            Name = "AutoShop";
            Text = "AutoShop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cps1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button cps2;
        private Button cps3;
    }
}