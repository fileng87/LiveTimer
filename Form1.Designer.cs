
namespace LiveTimer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_page = new System.Windows.Forms.Panel();
            this.pnl_btn = new System.Windows.Forms.Panel();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_endTime = new System.Windows.Forms.Button();
            this.btn_startTime = new System.Windows.Forms.Button();
            this.btn_setTime = new System.Windows.Forms.Button();
            this.pnl_nowTime = new System.Windows.Forms.Panel();
            this.lab_nowTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lab_titel = new System.Windows.Forms.Label();
            this.pnl_default = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_page.SuspendLayout();
            this.pnl_nowTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_page
            // 
            this.pnl_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnl_page.Controls.Add(this.pnl_btn);
            this.pnl_page.Controls.Add(this.btn_show);
            this.pnl_page.Controls.Add(this.btn_endTime);
            this.pnl_page.Controls.Add(this.btn_startTime);
            this.pnl_page.Controls.Add(this.btn_setTime);
            this.pnl_page.Controls.Add(this.pnl_nowTime);
            this.pnl_page.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_page.Location = new System.Drawing.Point(0, 0);
            this.pnl_page.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_page.Name = "pnl_page";
            this.pnl_page.Size = new System.Drawing.Size(175, 392);
            this.pnl_page.TabIndex = 0;
            // 
            // pnl_btn
            // 
            this.pnl_btn.BackColor = System.Drawing.Color.White;
            this.pnl_btn.Location = new System.Drawing.Point(0, 205);
            this.pnl_btn.Name = "pnl_btn";
            this.pnl_btn.Size = new System.Drawing.Size(3, 100);
            this.pnl_btn.TabIndex = 1;
            this.pnl_btn.Visible = false;
            // 
            // btn_show
            // 
            this.btn_show.FlatAppearance.BorderSize = 0;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_show.ForeColor = System.Drawing.Color.White;
            this.btn_show.Location = new System.Drawing.Point(0, 345);
            this.btn_show.Margin = new System.Windows.Forms.Padding(0);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(175, 47);
            this.btn_show.TabIndex = 1;
            this.btn_show.Text = "顯示投影";
            this.btn_show.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_endTime
            // 
            this.btn_endTime.FlatAppearance.BorderSize = 0;
            this.btn_endTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_endTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_endTime.ForeColor = System.Drawing.Color.White;
            this.btn_endTime.Location = new System.Drawing.Point(0, 276);
            this.btn_endTime.Margin = new System.Windows.Forms.Padding(0);
            this.btn_endTime.Name = "btn_endTime";
            this.btn_endTime.Size = new System.Drawing.Size(175, 47);
            this.btn_endTime.TabIndex = 1;
            this.btn_endTime.Text = "結束時間";
            this.btn_endTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_endTime.UseVisualStyleBackColor = true;
            this.btn_endTime.Click += new System.EventHandler(this.btn_endTime_Click);
            // 
            // btn_startTime
            // 
            this.btn_startTime.FlatAppearance.BorderSize = 0;
            this.btn_startTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_startTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_startTime.ForeColor = System.Drawing.Color.White;
            this.btn_startTime.Location = new System.Drawing.Point(0, 229);
            this.btn_startTime.Margin = new System.Windows.Forms.Padding(0);
            this.btn_startTime.Name = "btn_startTime";
            this.btn_startTime.Size = new System.Drawing.Size(175, 47);
            this.btn_startTime.TabIndex = 1;
            this.btn_startTime.Text = "開始時間";
            this.btn_startTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_startTime.UseVisualStyleBackColor = true;
            this.btn_startTime.Click += new System.EventHandler(this.btn_startTime_Click);
            // 
            // btn_setTime
            // 
            this.btn_setTime.FlatAppearance.BorderSize = 0;
            this.btn_setTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_setTime.ForeColor = System.Drawing.Color.White;
            this.btn_setTime.Location = new System.Drawing.Point(0, 182);
            this.btn_setTime.Margin = new System.Windows.Forms.Padding(0);
            this.btn_setTime.Name = "btn_setTime";
            this.btn_setTime.Size = new System.Drawing.Size(175, 47);
            this.btn_setTime.TabIndex = 1;
            this.btn_setTime.Text = "切換倒數";
            this.btn_setTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_setTime.UseVisualStyleBackColor = true;
            this.btn_setTime.Click += new System.EventHandler(this.btn_setTime_Click);
            // 
            // pnl_nowTime
            // 
            this.pnl_nowTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnl_nowTime.Controls.Add(this.lab_nowTime);
            this.pnl_nowTime.Controls.Add(this.pictureBox1);
            this.pnl_nowTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_nowTime.Location = new System.Drawing.Point(0, 0);
            this.pnl_nowTime.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_nowTime.Name = "pnl_nowTime";
            this.pnl_nowTime.Size = new System.Drawing.Size(175, 182);
            this.pnl_nowTime.TabIndex = 0;
            // 
            // lab_nowTime
            // 
            this.lab_nowTime.AutoSize = true;
            this.lab_nowTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_nowTime.ForeColor = System.Drawing.Color.White;
            this.lab_nowTime.Location = new System.Drawing.Point(9, 143);
            this.lab_nowTime.Name = "lab_nowTime";
            this.lab_nowTime.Size = new System.Drawing.Size(158, 21);
            this.lab_nowTime.TabIndex = 1;
            this.lab_nowTime.Text = "現在時間：00:00:00";
            this.lab_nowTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LiveTimer.Properties.Resources.toppng_com_browser_history_clock_icon_vector_white_541x541;
            this.pictureBox1.Location = new System.Drawing.Point(42, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(381, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "X";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.FlatAppearance.BorderSize = 0;
            this.btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hide.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_hide.ForeColor = System.Drawing.Color.White;
            this.btn_hide.Location = new System.Drawing.Point(356, 0);
            this.btn_hide.Margin = new System.Windows.Forms.Padding(0);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(25, 25);
            this.btn_hide.TabIndex = 1;
            this.btn_hide.Text = "_";
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.pnl_top.Controls.Add(this.lab_titel);
            this.pnl_top.Controls.Add(this.btn_hide);
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(175, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(406, 25);
            this.pnl_top.TabIndex = 3;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseDown);
            this.pnl_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseMove);
            this.pnl_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseUp);
            // 
            // lab_titel
            // 
            this.lab_titel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_titel.AutoSize = true;
            this.lab_titel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_titel.ForeColor = System.Drawing.Color.White;
            this.lab_titel.Location = new System.Drawing.Point(3, 6);
            this.lab_titel.Name = "lab_titel";
            this.lab_titel.Size = new System.Drawing.Size(32, 16);
            this.lab_titel.TabIndex = 5;
            this.lab_titel.Text = "主頁";
            this.lab_titel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_default
            // 
            this.pnl_default.AutoSize = true;
            this.pnl_default.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_default.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pnl_default.Location = new System.Drawing.Point(175, 25);
            this.pnl_default.Name = "pnl_default";
            this.pnl_default.Size = new System.Drawing.Size(406, 367);
            this.pnl_default.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(581, 392);
            this.Controls.Add(this.pnl_default);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_page);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_page.ResumeLayout(false);
            this.pnl_nowTime.ResumeLayout(false);
            this.pnl_nowTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_page;
        private System.Windows.Forms.Panel pnl_nowTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_setTime;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_endTime;
        private System.Windows.Forms.Button btn_startTime;
        private System.Windows.Forms.Label lab_nowTime;
        private System.Windows.Forms.Panel pnl_btn;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_default;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lab_titel;
    }
}

