
namespace LiveTimer
{
    partial class UCSetTime
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lab_Time = new System.Windows.Forms.Label();
            this.txt_H = new System.Windows.Forms.TextBox();
            this.btn_H_Add = new System.Windows.Forms.Button();
            this.btn_H_Sub = new System.Windows.Forms.Button();
            this.lab_H = new System.Windows.Forms.Label();
            this.txt_M = new System.Windows.Forms.TextBox();
            this.btn_M_Add = new System.Windows.Forms.Button();
            this.btn_M_Sub = new System.Windows.Forms.Button();
            this.lab_M = new System.Windows.Forms.Label();
            this.txt_S = new System.Windows.Forms.TextBox();
            this.btn_S_Add = new System.Windows.Forms.Button();
            this.btn_S_Sub = new System.Windows.Forms.Button();
            this.lab_S = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Stop = new System.Windows.Forms.Button();
            this.pnl_title = new System.Windows.Forms.Panel();
            this.pnl_contral = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.pnl_title.SuspendLayout();
            this.pnl_contral.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_Time
            // 
            this.lab_Time.AutoSize = true;
            this.lab_Time.Font = new System.Drawing.Font("微軟正黑體", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Time.ForeColor = System.Drawing.Color.White;
            this.lab_Time.Location = new System.Drawing.Point(19, 47);
            this.lab_Time.Name = "lab_Time";
            this.lab_Time.Size = new System.Drawing.Size(371, 101);
            this.lab_Time.TabIndex = 0;
            this.lab_Time.Text = "00:00:00";
            // 
            // txt_H
            // 
            this.txt_H.BackColor = System.Drawing.Color.DarkGray;
            this.txt_H.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_H.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_H.ForeColor = System.Drawing.Color.White;
            this.txt_H.Location = new System.Drawing.Point(103, 49);
            this.txt_H.Margin = new System.Windows.Forms.Padding(0);
            this.txt_H.Multiline = true;
            this.txt_H.Name = "txt_H";
            this.txt_H.Size = new System.Drawing.Size(32, 23);
            this.txt_H.TabIndex = 1;
            this.txt_H.Text = "0";
            this.txt_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_H.TextChanged += new System.EventHandler(this.txt_H_TextChanged);
            // 
            // btn_H_Add
            // 
            this.btn_H_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btn_H_Add.FlatAppearance.BorderSize = 0;
            this.btn_H_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_H_Add.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_H_Add.ForeColor = System.Drawing.Color.White;
            this.btn_H_Add.Location = new System.Drawing.Point(135, 49);
            this.btn_H_Add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_H_Add.Name = "btn_H_Add";
            this.btn_H_Add.Size = new System.Drawing.Size(23, 23);
            this.btn_H_Add.TabIndex = 2;
            this.btn_H_Add.Text = ">";
            this.btn_H_Add.UseVisualStyleBackColor = false;
            this.btn_H_Add.Click += new System.EventHandler(this.btn_H_Add_Click);
            // 
            // btn_H_Sub
            // 
            this.btn_H_Sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btn_H_Sub.FlatAppearance.BorderSize = 0;
            this.btn_H_Sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_H_Sub.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_H_Sub.ForeColor = System.Drawing.Color.White;
            this.btn_H_Sub.Location = new System.Drawing.Point(80, 49);
            this.btn_H_Sub.Margin = new System.Windows.Forms.Padding(0);
            this.btn_H_Sub.Name = "btn_H_Sub";
            this.btn_H_Sub.Size = new System.Drawing.Size(23, 23);
            this.btn_H_Sub.TabIndex = 2;
            this.btn_H_Sub.Text = "<";
            this.btn_H_Sub.UseVisualStyleBackColor = false;
            this.btn_H_Sub.Click += new System.EventHandler(this.btn_H_Sub_Click);
            // 
            // lab_H
            // 
            this.lab_H.AutoSize = true;
            this.lab_H.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_H.ForeColor = System.Drawing.Color.White;
            this.lab_H.Location = new System.Drawing.Point(77, 33);
            this.lab_H.Name = "lab_H";
            this.lab_H.Size = new System.Drawing.Size(32, 16);
            this.lab_H.TabIndex = 3;
            this.lab_H.Text = "小時";
            // 
            // txt_M
            // 
            this.txt_M.BackColor = System.Drawing.Color.DarkGray;
            this.txt_M.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_M.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_M.ForeColor = System.Drawing.Color.White;
            this.txt_M.Location = new System.Drawing.Point(187, 49);
            this.txt_M.Margin = new System.Windows.Forms.Padding(0);
            this.txt_M.Multiline = true;
            this.txt_M.Name = "txt_M";
            this.txt_M.Size = new System.Drawing.Size(32, 23);
            this.txt_M.TabIndex = 1;
            this.txt_M.Text = "0";
            this.txt_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_M.TextChanged += new System.EventHandler(this.txt_M_TextChanged);
            // 
            // btn_M_Add
            // 
            this.btn_M_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btn_M_Add.FlatAppearance.BorderSize = 0;
            this.btn_M_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_M_Add.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_M_Add.ForeColor = System.Drawing.Color.White;
            this.btn_M_Add.Location = new System.Drawing.Point(219, 49);
            this.btn_M_Add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_M_Add.Name = "btn_M_Add";
            this.btn_M_Add.Size = new System.Drawing.Size(23, 23);
            this.btn_M_Add.TabIndex = 2;
            this.btn_M_Add.Text = ">";
            this.btn_M_Add.UseVisualStyleBackColor = false;
            this.btn_M_Add.Click += new System.EventHandler(this.btn_M_Add_Click);
            // 
            // btn_M_Sub
            // 
            this.btn_M_Sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btn_M_Sub.FlatAppearance.BorderSize = 0;
            this.btn_M_Sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_M_Sub.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_M_Sub.ForeColor = System.Drawing.Color.White;
            this.btn_M_Sub.Location = new System.Drawing.Point(164, 49);
            this.btn_M_Sub.Margin = new System.Windows.Forms.Padding(0);
            this.btn_M_Sub.Name = "btn_M_Sub";
            this.btn_M_Sub.Size = new System.Drawing.Size(23, 23);
            this.btn_M_Sub.TabIndex = 2;
            this.btn_M_Sub.Text = "<";
            this.btn_M_Sub.UseVisualStyleBackColor = false;
            this.btn_M_Sub.Click += new System.EventHandler(this.btn_M_Sub_Click);
            // 
            // lab_M
            // 
            this.lab_M.AutoSize = true;
            this.lab_M.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_M.ForeColor = System.Drawing.Color.White;
            this.lab_M.Location = new System.Drawing.Point(161, 33);
            this.lab_M.Name = "lab_M";
            this.lab_M.Size = new System.Drawing.Size(32, 16);
            this.lab_M.TabIndex = 3;
            this.lab_M.Text = "分鐘";
            // 
            // txt_S
            // 
            this.txt_S.BackColor = System.Drawing.Color.DarkGray;
            this.txt_S.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_S.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_S.ForeColor = System.Drawing.Color.White;
            this.txt_S.Location = new System.Drawing.Point(271, 49);
            this.txt_S.Margin = new System.Windows.Forms.Padding(0);
            this.txt_S.Multiline = true;
            this.txt_S.Name = "txt_S";
            this.txt_S.Size = new System.Drawing.Size(32, 23);
            this.txt_S.TabIndex = 1;
            this.txt_S.Text = "0";
            this.txt_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_S.TextChanged += new System.EventHandler(this.txt_S_TextChanged);
            // 
            // btn_S_Add
            // 
            this.btn_S_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btn_S_Add.FlatAppearance.BorderSize = 0;
            this.btn_S_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_S_Add.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_S_Add.ForeColor = System.Drawing.Color.White;
            this.btn_S_Add.Location = new System.Drawing.Point(303, 49);
            this.btn_S_Add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_S_Add.Name = "btn_S_Add";
            this.btn_S_Add.Size = new System.Drawing.Size(23, 23);
            this.btn_S_Add.TabIndex = 2;
            this.btn_S_Add.Text = ">";
            this.btn_S_Add.UseVisualStyleBackColor = false;
            this.btn_S_Add.Click += new System.EventHandler(this.btn_S_Add_Click);
            // 
            // btn_S_Sub
            // 
            this.btn_S_Sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btn_S_Sub.FlatAppearance.BorderSize = 0;
            this.btn_S_Sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_S_Sub.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_S_Sub.ForeColor = System.Drawing.Color.White;
            this.btn_S_Sub.Location = new System.Drawing.Point(248, 49);
            this.btn_S_Sub.Margin = new System.Windows.Forms.Padding(0);
            this.btn_S_Sub.Name = "btn_S_Sub";
            this.btn_S_Sub.Size = new System.Drawing.Size(23, 23);
            this.btn_S_Sub.TabIndex = 2;
            this.btn_S_Sub.Text = "<";
            this.btn_S_Sub.UseVisualStyleBackColor = false;
            this.btn_S_Sub.Click += new System.EventHandler(this.btn_S_Sub_Click);
            // 
            // lab_S
            // 
            this.lab_S.AutoSize = true;
            this.lab_S.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_S.ForeColor = System.Drawing.Color.White;
            this.lab_S.Location = new System.Drawing.Point(245, 33);
            this.lab_S.Name = "lab_S";
            this.lab_S.Size = new System.Drawing.Size(32, 16);
            this.lab_S.TabIndex = 3;
            this.lab_S.Text = "秒鐘";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Location = new System.Drawing.Point(164, 96);
            this.btn_start.Margin = new System.Windows.Forms.Padding(0);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(78, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "開始計時";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btn_Stop.FlatAppearance.BorderSize = 0;
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stop.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Stop.ForeColor = System.Drawing.Color.White;
            this.btn_Stop.Location = new System.Drawing.Point(248, 96);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(78, 23);
            this.btn_Stop.TabIndex = 2;
            this.btn_Stop.Text = "停止計時";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // pnl_title
            // 
            this.pnl_title.Controls.Add(this.lab_Time);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(406, 199);
            this.pnl_title.TabIndex = 4;
            // 
            // pnl_contral
            // 
            this.pnl_contral.Controls.Add(this.btn_reset);
            this.pnl_contral.Controls.Add(this.txt_H);
            this.pnl_contral.Controls.Add(this.btn_H_Add);
            this.pnl_contral.Controls.Add(this.lab_S);
            this.pnl_contral.Controls.Add(this.txt_M);
            this.pnl_contral.Controls.Add(this.lab_M);
            this.pnl_contral.Controls.Add(this.btn_M_Add);
            this.pnl_contral.Controls.Add(this.lab_H);
            this.pnl_contral.Controls.Add(this.txt_S);
            this.pnl_contral.Controls.Add(this.btn_S_Sub);
            this.pnl_contral.Controls.Add(this.btn_S_Add);
            this.pnl_contral.Controls.Add(this.btn_M_Sub);
            this.pnl_contral.Controls.Add(this.btn_start);
            this.pnl_contral.Controls.Add(this.btn_H_Sub);
            this.pnl_contral.Controls.Add(this.btn_Stop);
            this.pnl_contral.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_contral.Location = new System.Drawing.Point(0, 205);
            this.pnl_contral.Name = "pnl_contral";
            this.pnl_contral.Size = new System.Drawing.Size(406, 160);
            this.pnl_contral.TabIndex = 1;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(80, 96);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(0);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(78, 23);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // UCSetTime
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.pnl_contral);
            this.Controls.Add(this.pnl_title);
            this.Name = "UCSetTime";
            this.Size = new System.Drawing.Size(406, 365);
            this.Load += new System.EventHandler(this.SetTime_Load);
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.pnl_contral.ResumeLayout(false);
            this.pnl_contral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lab_Time;
        private System.Windows.Forms.TextBox txt_H;
        private System.Windows.Forms.Button btn_H_Add;
        private System.Windows.Forms.Button btn_H_Sub;
        private System.Windows.Forms.Label lab_H;
        private System.Windows.Forms.TextBox txt_M;
        private System.Windows.Forms.Button btn_M_Add;
        private System.Windows.Forms.Button btn_M_Sub;
        private System.Windows.Forms.Label lab_M;
        private System.Windows.Forms.TextBox txt_S;
        private System.Windows.Forms.Button btn_S_Add;
        private System.Windows.Forms.Button btn_S_Sub;
        private System.Windows.Forms.Label lab_S;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Panel pnl_contral;
        private System.Windows.Forms.Button btn_reset;
    }
}
