namespace ATETestPointsCoverageReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnOpenBoard = new System.Windows.Forms.Button();
            this.txtBoardxy = new System.Windows.Forms.TextBox();
            this.txtBoard = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRun);
            this.groupBox1.Controls.Add(this.btnOpenBoard);
            this.groupBox1.Controls.Add(this.txtBoardxy);
            this.groupBox1.Controls.Add(this.txtBoard);
            this.groupBox1.Location = new System.Drawing.Point(14, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "board_xy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "board";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(418, 27);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 50);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnOpenBoard
            // 
            this.btnOpenBoard.Location = new System.Drawing.Point(337, 27);
            this.btnOpenBoard.Name = "btnOpenBoard";
            this.btnOpenBoard.Size = new System.Drawing.Size(75, 50);
            this.btnOpenBoard.TabIndex = 2;
            this.btnOpenBoard.Text = "OPEN";
            this.btnOpenBoard.UseVisualStyleBackColor = true;
            this.btnOpenBoard.Click += new System.EventHandler(this.btnOpenBoard_Click);
            // 
            // txtBoardxy
            // 
            this.txtBoardxy.Location = new System.Drawing.Point(75, 55);
            this.txtBoardxy.Name = "txtBoardxy";
            this.txtBoardxy.Size = new System.Drawing.Size(256, 22);
            this.txtBoardxy.TabIndex = 1;
            // 
            // txtBoard
            // 
            this.txtBoard.Location = new System.Drawing.Point(75, 27);
            this.txtBoard.Name = "txtBoard";
            this.txtBoard.Size = new System.Drawing.Size(256, 22);
            this.txtBoard.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 138);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnOpenBoard;
        private System.Windows.Forms.TextBox txtBoardxy;
        private System.Windows.Forms.TextBox txtBoard;
    }
}

