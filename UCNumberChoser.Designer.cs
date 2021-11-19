
namespace LiveTimer
{
    partial class UCNumberChoser
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
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Sub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Num
            // 
            this.txt_Num.BackColor = System.Drawing.Color.DarkGray;
            this.txt_Num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Num.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Num.ForeColor = System.Drawing.Color.White;
            this.txt_Num.Location = new System.Drawing.Point(23, 0);
            this.txt_Num.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Num.Multiline = true;
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(32, 23);
            this.txt_Num.TabIndex = 3;
            this.txt_Num.Text = "0";
            this.txt_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Num.TextChanged += new System.EventHandler(this.txt_Num_TextChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(55, 0);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(23, 23);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = ">";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Sub
            // 
            this.btn_Sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btn_Sub.FlatAppearance.BorderSize = 0;
            this.btn_Sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sub.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Sub.ForeColor = System.Drawing.Color.White;
            this.btn_Sub.Location = new System.Drawing.Point(0, 0);
            this.btn_Sub.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Sub.Name = "btn_Sub";
            this.btn_Sub.Size = new System.Drawing.Size(23, 23);
            this.btn_Sub.TabIndex = 5;
            this.btn_Sub.Text = "<";
            this.btn_Sub.UseVisualStyleBackColor = false;
            this.btn_Sub.Click += new System.EventHandler(this.btn_Sub_Click);
            // 
            // NumberChoser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Num);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Sub);
            this.Name = "NumberChoser";
            this.Size = new System.Drawing.Size(78, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Sub;
    }
}
