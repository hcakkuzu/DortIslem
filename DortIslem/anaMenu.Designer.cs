namespace DortIslem
{
    partial class anaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaMenu));
            this.cikisBtn = new System.Windows.Forms.PictureBox();
            this.playBtn = new System.Windows.Forms.PictureBox();
            this.thropyBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cikisBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thropyBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // cikisBtn
            // 
            this.cikisBtn.BackColor = System.Drawing.Color.Transparent;
            this.cikisBtn.BackgroundImage = global::DortIslem.Properties.Resources.cikisbtn;
            this.cikisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cikisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisBtn.Location = new System.Drawing.Point(422, -2);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(79, 71);
            this.cikisBtn.TabIndex = 0;
            this.cikisBtn.TabStop = false;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.Transparent;
            this.playBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playBtn.Image = global::DortIslem.Properties.Resources.playbutton;
            this.playBtn.Location = new System.Drawing.Point(204, 145);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(97, 101);
            this.playBtn.TabIndex = 1;
            this.playBtn.TabStop = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // thropyBtn
            // 
            this.thropyBtn.BackColor = System.Drawing.Color.Transparent;
            this.thropyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thropyBtn.Image = global::DortIslem.Properties.Resources.thropy1;
            this.thropyBtn.Location = new System.Drawing.Point(210, 257);
            this.thropyBtn.Name = "thropyBtn";
            this.thropyBtn.Size = new System.Drawing.Size(87, 87);
            this.thropyBtn.TabIndex = 1;
            this.thropyBtn.TabStop = false;
            this.thropyBtn.Click += new System.EventHandler(this.thropyBtn_Click);
            // 
            // anaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.thropyBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.cikisBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "anaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dort-Islem";
            ((System.ComponentModel.ISupportInitialize)(this.cikisBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thropyBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cikisBtn;
        private System.Windows.Forms.PictureBox playBtn;
        private System.Windows.Forms.PictureBox thropyBtn;

    }
}

