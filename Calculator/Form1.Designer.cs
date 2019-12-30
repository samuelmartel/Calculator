namespace Calculator
{
    partial class Form1
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
            this.btn_exe = new System.Windows.Forms.Button();
            this.txtbx_2 = new System.Windows.Forms.TextBox();
            this.txtbx_1 = new System.Windows.Forms.TextBox();
            this.txtbx_ans = new System.Windows.Forms.TextBox();
            this.txtbx_Op = new System.Windows.Forms.TextBox();
            this.label_Operator = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_Clr = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_exe
            // 
            this.btn_exe.Location = new System.Drawing.Point(83, 352);
            this.btn_exe.Name = "btn_exe";
            this.btn_exe.Size = new System.Drawing.Size(91, 40);
            this.btn_exe.TabIndex = 0;
            this.btn_exe.Text = "=";
            this.btn_exe.UseVisualStyleBackColor = true;
            this.btn_exe.Click += new System.EventHandler(this.btn_exe_Click);
            // 
            // txtbx_2
            // 
            this.txtbx_2.Location = new System.Drawing.Point(223, 79);
            this.txtbx_2.Name = "txtbx_2";
            this.txtbx_2.Size = new System.Drawing.Size(100, 29);
            this.txtbx_2.TabIndex = 2;
            // 
            // txtbx_1
            // 
            this.txtbx_1.Location = new System.Drawing.Point(45, 79);
            this.txtbx_1.Name = "txtbx_1";
            this.txtbx_1.Size = new System.Drawing.Size(100, 29);
            this.txtbx_1.TabIndex = 3;
            this.txtbx_1.TextChanged += new System.EventHandler(this.txtbx_1_TextChanged);
            // 
            // txtbx_ans
            // 
            this.txtbx_ans.Location = new System.Drawing.Point(223, 363);
            this.txtbx_ans.Name = "txtbx_ans";
            this.txtbx_ans.Size = new System.Drawing.Size(100, 29);
            this.txtbx_ans.TabIndex = 4;
            // 
            // txtbx_Op
            // 
            this.txtbx_Op.Location = new System.Drawing.Point(166, 79);
            this.txtbx_Op.Name = "txtbx_Op";
            this.txtbx_Op.Size = new System.Drawing.Size(37, 29);
            this.txtbx_Op.TabIndex = 5;
            // 
            // label_Operator
            // 
            this.label_Operator.AutoSize = true;
            this.label_Operator.Location = new System.Drawing.Point(136, 51);
            this.label_Operator.Name = "label_Operator";
            this.label_Operator.Size = new System.Drawing.Size(89, 25);
            this.label_Operator.TabIndex = 6;
            this.label_Operator.Text = "Operator";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(276, 138);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(47, 44);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(276, 188);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(47, 44);
            this.btn_sub.TabIndex = 8;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Location = new System.Drawing.Point(276, 238);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(47, 44);
            this.btn_mult.TabIndex = 9;
            this.btn_mult.Text = "*";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(276, 288);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(47, 44);
            this.btn_div.TabIndex = 10;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(45, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 25);
            this.Title.TabIndex = 11;
            this.Title.Text = "Calculator";
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(50, 138);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(47, 44);
            this.btn_1.TabIndex = 12;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(103, 138);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(47, 44);
            this.btn_2.TabIndex = 13;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(156, 138);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(47, 44);
            this.btn_3.TabIndex = 14;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(50, 188);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(47, 44);
            this.btn_4.TabIndex = 15;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(103, 188);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(47, 44);
            this.btn_5.TabIndex = 16;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(156, 188);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(47, 44);
            this.btn_6.TabIndex = 17;
            this.btn_6.Text = " 6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(50, 238);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(47, 44);
            this.btn_7.TabIndex = 18;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(103, 238);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(47, 44);
            this.btn_8.TabIndex = 19;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(156, 238);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(47, 44);
            this.btn_9.TabIndex = 20;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(103, 288);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(47, 44);
            this.btn_0.TabIndex = 21;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_Clr
            // 
            this.btn_Clr.Location = new System.Drawing.Point(352, 79);
            this.btn_Clr.Name = "btn_Clr";
            this.btn_Clr.Size = new System.Drawing.Size(75, 36);
            this.btn_Clr.TabIndex = 22;
            this.btn_Clr.Text = "Clear";
            this.btn_Clr.UseVisualStyleBackColor = true;
            this.btn_Clr.Click += new System.EventHandler(this.btn_Clr_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(225, 335);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(66, 25);
            this.Result.TabIndex = 23;
            this.Result.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.btn_Clr);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label_Operator);
            this.Controls.Add(this.txtbx_Op);
            this.Controls.Add(this.txtbx_ans);
            this.Controls.Add(this.txtbx_1);
            this.Controls.Add(this.txtbx_2);
            this.Controls.Add(this.btn_exe);
            this.Name = "Form1";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exe;
        private System.Windows.Forms.TextBox txtbx_2;
        private System.Windows.Forms.TextBox txtbx_1;
        private System.Windows.Forms.TextBox txtbx_ans;
        private System.Windows.Forms.TextBox txtbx_Op;
        private System.Windows.Forms.Label label_Operator;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_Clr;
        private System.Windows.Forms.Label Result;
    }
}

