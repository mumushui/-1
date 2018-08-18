namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.set_alm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sevonBox0 = new System.Windows.Forms.PictureBox();
            this.sevonBox1 = new System.Windows.Forms.PictureBox();
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sevonBox3 = new System.Windows.Forms.PictureBox();
            this.rdyBox0 = new System.Windows.Forms.PictureBox();
            this.ercBox0 = new System.Windows.Forms.PictureBox();
            this.rdyBox1 = new System.Windows.Forms.PictureBox();
            this.ercBox1 = new System.Windows.Forms.PictureBox();
            this.rdyBox3 = new System.Windows.Forms.PictureBox();
            this.ercBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inpBox0 = new System.Windows.Forms.PictureBox();
            this.inpBox1 = new System.Windows.Forms.PictureBox();
            this.inpBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sevonBox0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevonBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevonBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdyBox0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ercBox0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdyBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ercBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdyBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ercBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpBox0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 273);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "启动";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(12, 336);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 1;
            this.stop.Text = "停止";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // set_alm
            // 
            this.set_alm.Location = new System.Drawing.Point(12, 45);
            this.set_alm.Name = "set_alm";
            this.set_alm.Size = new System.Drawing.Size(185, 23);
            this.set_alm.TabIndex = 2;
            this.set_alm.Text = "设置alm信号";
            this.set_alm.UseVisualStyleBackColor = true;
            this.set_alm.Click += new System.EventHandler(this.set_alm_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "检查电机驱动信号电平";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sevonBox0
            // 
            this.sevonBox0.Location = new System.Drawing.Point(275, 102);
            this.sevonBox0.Name = "sevonBox0";
            this.sevonBox0.Size = new System.Drawing.Size(24, 22);
            this.sevonBox0.TabIndex = 4;
            this.sevonBox0.TabStop = false;
            // 
            // sevonBox1
            // 
            this.sevonBox1.Location = new System.Drawing.Point(275, 139);
            this.sevonBox1.Name = "sevonBox1";
            this.sevonBox1.Size = new System.Drawing.Size(23, 21);
            this.sevonBox1.TabIndex = 5;
            this.sevonBox1.TabStop = false;
            // 
            // label0
            // 
            this.label0.AccessibleDescription = "";
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(230, 108);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(23, 12);
            this.label0.TabIndex = 6;
            this.label0.Text = "0轴";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "1轴";
            // 
            // label3
            // 
            this.label3.AccessibleDescription = "";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "3轴";
            // 
            // sevonBox3
            // 
            this.sevonBox3.Location = new System.Drawing.Point(275, 179);
            this.sevonBox3.Name = "sevonBox3";
            this.sevonBox3.Size = new System.Drawing.Size(23, 21);
            this.sevonBox3.TabIndex = 5;
            this.sevonBox3.TabStop = false;
            // 
            // rdyBox0
            // 
            this.rdyBox0.Location = new System.Drawing.Point(350, 102);
            this.rdyBox0.Name = "rdyBox0";
            this.rdyBox0.Size = new System.Drawing.Size(24, 22);
            this.rdyBox0.TabIndex = 4;
            this.rdyBox0.TabStop = false;
            // 
            // ercBox0
            // 
            this.ercBox0.Location = new System.Drawing.Point(419, 102);
            this.ercBox0.Name = "ercBox0";
            this.ercBox0.Size = new System.Drawing.Size(24, 22);
            this.ercBox0.TabIndex = 4;
            this.ercBox0.TabStop = false;
            // 
            // rdyBox1
            // 
            this.rdyBox1.Location = new System.Drawing.Point(350, 139);
            this.rdyBox1.Name = "rdyBox1";
            this.rdyBox1.Size = new System.Drawing.Size(24, 22);
            this.rdyBox1.TabIndex = 4;
            this.rdyBox1.TabStop = false;
            // 
            // ercBox1
            // 
            this.ercBox1.Location = new System.Drawing.Point(419, 139);
            this.ercBox1.Name = "ercBox1";
            this.ercBox1.Size = new System.Drawing.Size(24, 22);
            this.ercBox1.TabIndex = 4;
            this.ercBox1.TabStop = false;
            // 
            // rdyBox3
            // 
            this.rdyBox3.Location = new System.Drawing.Point(350, 179);
            this.rdyBox3.Name = "rdyBox3";
            this.rdyBox3.Size = new System.Drawing.Size(24, 22);
            this.rdyBox3.TabIndex = 4;
            this.rdyBox3.TabStop = false;
            // 
            // ercBox3
            // 
            this.ercBox3.Location = new System.Drawing.Point(419, 179);
            this.ercBox3.Name = "ercBox3";
            this.ercBox3.Size = new System.Drawing.Size(24, 22);
            this.ercBox3.TabIndex = 4;
            this.ercBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(263, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "sevon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(347, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "rdy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(492, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "inp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(416, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "erc";
            // 
            // inpBox0
            // 
            this.inpBox0.Location = new System.Drawing.Point(495, 102);
            this.inpBox0.Name = "inpBox0";
            this.inpBox0.Size = new System.Drawing.Size(24, 22);
            this.inpBox0.TabIndex = 4;
            this.inpBox0.TabStop = false;
            // 
            // inpBox1
            // 
            this.inpBox1.Location = new System.Drawing.Point(495, 139);
            this.inpBox1.Name = "inpBox1";
            this.inpBox1.Size = new System.Drawing.Size(24, 22);
            this.inpBox1.TabIndex = 4;
            this.inpBox1.TabStop = false;
            // 
            // inpBox3
            // 
            this.inpBox3.Location = new System.Drawing.Point(495, 179);
            this.inpBox3.Name = "inpBox3";
            this.inpBox3.Size = new System.Drawing.Size(24, 22);
            this.inpBox3.TabIndex = 4;
            this.inpBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 429);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.sevonBox3);
            this.Controls.Add(this.sevonBox1);
            this.Controls.Add(this.inpBox3);
            this.Controls.Add(this.ercBox3);
            this.Controls.Add(this.inpBox1);
            this.Controls.Add(this.ercBox1);
            this.Controls.Add(this.rdyBox3);
            this.Controls.Add(this.rdyBox1);
            this.Controls.Add(this.inpBox0);
            this.Controls.Add(this.ercBox0);
            this.Controls.Add(this.rdyBox0);
            this.Controls.Add(this.sevonBox0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.set_alm);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sevonBox0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevonBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevonBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdyBox0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ercBox0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdyBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ercBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdyBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ercBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpBox0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button set_alm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox sevonBox0;
        private System.Windows.Forms.PictureBox sevonBox1;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox sevonBox3;
        private System.Windows.Forms.PictureBox rdyBox0;
        private System.Windows.Forms.PictureBox ercBox0;
        private System.Windows.Forms.PictureBox rdyBox1;
        private System.Windows.Forms.PictureBox ercBox1;
        private System.Windows.Forms.PictureBox rdyBox3;
        private System.Windows.Forms.PictureBox ercBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox inpBox0;
        private System.Windows.Forms.PictureBox inpBox1;
        private System.Windows.Forms.PictureBox inpBox3;
    }
}

