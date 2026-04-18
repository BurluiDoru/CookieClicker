namespace CookieClicker
{
    partial class MultiShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiShop));
            multi2x = new Button();
            label1 = new Label();
            button1 = new Button();
            multi5x = new Button();
            multi10x = new Button();
            multi25x = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // multi2x
            // 
            multi2x.Anchor = AnchorStyles.Bottom;
            multi2x.Location = new Point(51, 331);
            multi2x.Name = "multi2x";
            multi2x.Size = new Size(127, 40);
            multi2x.TabIndex = 0;
            multi2x.Text = "2x multiplayer";
            multi2x.UseVisualStyleBackColor = true;
            multi2x.Click += multi2x_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(51, 374);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(269, 340);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // multi5x
            // 
            multi5x.Anchor = AnchorStyles.Bottom;
            multi5x.Location = new Point(251, 331);
            multi5x.Name = "multi5x";
            multi5x.Size = new Size(127, 40);
            multi5x.TabIndex = 3;
            multi5x.Text = "5x multilpayer";
            multi5x.UseVisualStyleBackColor = true;
            multi5x.Click += multi5x_Click_1;
            // 
            // multi10x
            // 
            multi10x.Anchor = AnchorStyles.Bottom;
            multi10x.Location = new Point(445, 331);
            multi10x.Name = "multi10x";
            multi10x.Size = new Size(127, 40);
            multi10x.TabIndex = 4;
            multi10x.Text = "10x multiplayer";
            multi10x.UseVisualStyleBackColor = true;
            multi10x.Click += multi10x_Click_1;
            // 
            // multi25x
            // 
            multi25x.Anchor = AnchorStyles.Bottom;
            multi25x.Location = new Point(631, 331);
            multi25x.Name = "multi25x";
            multi25x.Size = new Size(127, 40);
            multi25x.TabIndex = 5;
            multi25x.Text = "25x multiplayer";
            multi25x.UseVisualStyleBackColor = true;
            multi25x.Click += multi25x_Click_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(251, 374);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(445, 374);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(631, 374);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // MultiShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(764, 441);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(multi25x);
            Controls.Add(multi10x);
            Controls.Add(multi5x);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(multi2x);
            DoubleBuffered = true;
            Name = "MultiShop";
            Text = "MultiShop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button multi2x;
        private Label label1;
        private Button button1;
        private Button multi5x;
        private Button multi10x;
        private Button multi25x;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}