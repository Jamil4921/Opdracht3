namespace Oefening2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkItemVideo = new System.Windows.Forms.Button();
            this.removeAllVideo = new System.Windows.Forms.Button();
            this.removeVideo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textVideo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkPrice = new System.Windows.Forms.Button();
            this.clearPrice = new System.Windows.Forms.Button();
            this.removePrice = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video game name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkItemVideo);
            this.panel1.Controls.Add(this.removeAllVideo);
            this.panel1.Controls.Add(this.removeVideo);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textVideo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(30, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 133);
            this.panel1.TabIndex = 1;
            // 
            // checkItemVideo
            // 
            this.checkItemVideo.Location = new System.Drawing.Point(732, 18);
            this.checkItemVideo.Name = "checkItemVideo";
            this.checkItemVideo.Size = new System.Drawing.Size(94, 29);
            this.checkItemVideo.TabIndex = 6;
            this.checkItemVideo.Text = "check item";
            this.checkItemVideo.UseVisualStyleBackColor = true;
            this.checkItemVideo.Click += new System.EventHandler(this.checkItemVideo_Click);
            // 
            // removeAllVideo
            // 
            this.removeAllVideo.Location = new System.Drawing.Point(615, 18);
            this.removeAllVideo.Name = "removeAllVideo";
            this.removeAllVideo.Size = new System.Drawing.Size(94, 29);
            this.removeAllVideo.TabIndex = 5;
            this.removeAllVideo.Text = "Clear";
            this.removeAllVideo.UseVisualStyleBackColor = true;
            this.removeAllVideo.Click += new System.EventHandler(this.removeAllVideo_Click);
            // 
            // removeVideo
            // 
            this.removeVideo.Location = new System.Drawing.Point(499, 17);
            this.removeVideo.Name = "removeVideo";
            this.removeVideo.Size = new System.Drawing.Size(94, 29);
            this.removeVideo.TabIndex = 4;
            this.removeVideo.Text = "Remove item";
            this.removeVideo.UseVisualStyleBackColor = true;
            this.removeVideo.Click += new System.EventHandler(this.removeVideo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(23, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(495, 27);
            this.textBox1.TabIndex = 3;
            // 
            // textVideo
            // 
            this.textVideo.Location = new System.Drawing.Point(23, 18);
            this.textVideo.Name = "textVideo";
            this.textVideo.Size = new System.Drawing.Size(340, 27);
            this.textVideo.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add to list";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Video game price";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkPrice);
            this.panel2.Controls.Add(this.clearPrice);
            this.panel2.Controls.Add(this.removePrice);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textPrice);
            this.panel2.Location = new System.Drawing.Point(27, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1279, 125);
            this.panel2.TabIndex = 4;
            // 
            // checkPrice
            // 
            this.checkPrice.Location = new System.Drawing.Point(854, 25);
            this.checkPrice.Name = "checkPrice";
            this.checkPrice.Size = new System.Drawing.Size(94, 29);
            this.checkPrice.TabIndex = 11;
            this.checkPrice.Text = "Check price";
            this.checkPrice.UseVisualStyleBackColor = true;
            this.checkPrice.Click += new System.EventHandler(this.checkPrice_Click);
            // 
            // clearPrice
            // 
            this.clearPrice.Location = new System.Drawing.Point(735, 23);
            this.clearPrice.Name = "clearPrice";
            this.clearPrice.Size = new System.Drawing.Size(94, 29);
            this.clearPrice.TabIndex = 10;
            this.clearPrice.Text = "Clear";
            this.clearPrice.UseVisualStyleBackColor = true;
            this.clearPrice.Click += new System.EventHandler(this.clearPrice_Click);
            // 
            // removePrice
            // 
            this.removePrice.Location = new System.Drawing.Point(552, 23);
            this.removePrice.Name = "removePrice";
            this.removePrice.Size = new System.Drawing.Size(160, 29);
            this.removePrice.TabIndex = 9;
            this.removePrice.Text = "remove price";
            this.removePrice.UseVisualStyleBackColor = true;
            this.removePrice.Click += new System.EventHandler(this.removePrice_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add price to list";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(26, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(495, 27);
            this.textBox2.TabIndex = 7;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(26, 25);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(340, 27);
            this.textPrice.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 642);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button removeVideo;
        private TextBox textBox1;
        private TextBox textVideo;
        private Button button1;
        private Button checkItemVideo;
        private Button removeAllVideo;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Button checkPrice;
        private Button clearPrice;
        private Button removePrice;
        private Button button2;
        private TextBox textBox2;
        private TextBox textPrice;
    }
}