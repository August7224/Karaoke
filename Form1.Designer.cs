namespace Karaoke
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnplay = new Button();
            lbllyric = new Label();
            protientrinh = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            btnexit = new Button();
            pictureBox1 = new PictureBox();
            lbltenbh = new Label();
            buttonLoi = new Button();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnplay
            // 
            btnplay.Location = new Point(12, 397);
            btnplay.Name = "btnplay";
            btnplay.Size = new Size(94, 29);
            btnplay.TabIndex = 0;
            btnplay.Text = "Thêm nhạc";
            btnplay.UseVisualStyleBackColor = true;
            btnplay.Click += btnplay_Click;
            // 
            // lbllyric
            // 
            lbllyric.AutoSize = true;
            lbllyric.Location = new Point(449, 57);
            lbllyric.Name = "lbllyric";
            lbllyric.Size = new Size(79, 20);
            lbllyric.TabIndex = 1;
            lbllyric.Text = "Hiện trạng";
            // 
            // protientrinh
            // 
            protientrinh.Location = new Point(12, 380);
            protientrinh.Name = "protientrinh";
            protientrinh.Size = new Size(776, 11);
            protientrinh.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(21, 12);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(365, 362);
            axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(641, 397);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(94, 29);
            btnexit.TabIndex = 4;
            btnexit.Text = "Thoát";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 284);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lbltenbh
            // 
            lbltenbh.AutoSize = true;
            lbltenbh.CausesValidation = false;
            lbltenbh.Location = new Point(505, 12);
            lbltenbh.Name = "lbltenbh";
            lbltenbh.Size = new Size(106, 20);
            lbltenbh.TabIndex = 6;
            lbltenbh.Text = "Dù cho tận thế";
            // 
            // buttonLoi
            // 
            buttonLoi.Location = new Point(112, 397);
            buttonLoi.Name = "buttonLoi";
            buttonLoi.Size = new Size(43, 28);
            buttonLoi.TabIndex = 8;
            buttonLoi.Text = "Lời";
            buttonLoi.UseVisualStyleBackColor = true;
            buttonLoi.Click += buttonLoi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 450);
            Controls.Add(buttonLoi);
            Controls.Add(lbltenbh);
            Controls.Add(pictureBox1);
            Controls.Add(btnexit);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(protientrinh);
            Controls.Add(lbllyric);
            Controls.Add(btnplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnplay;
        private Label lbllyric;
        private ProgressBar protientrinh;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Button btnexit;
        private PictureBox pictureBox1;
        private Label lbltenbh;
        private Button buttonLoi;
    }
}
