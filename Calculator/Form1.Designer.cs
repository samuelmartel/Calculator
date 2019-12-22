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
            this.SuspendLayout();
            // 
            // btn_exe
            // 
            this.btn_exe.Location = new System.Drawing.Point(77, 318);
            this.btn_exe.Name = "btn_exe";
            this.btn_exe.Size = new System.Drawing.Size(106, 36);
            this.btn_exe.TabIndex = 0;
            this.btn_exe.Text = "=";
            this.btn_exe.UseVisualStyleBackColor = true;
            this.btn_exe.Click += new System.EventHandler(this.btn_exe_Click);
            // 
            // txtbx_2
            // 
            this.txtbx_2.Location = new System.Drawing.Point(281, 131);
            this.txtbx_2.Name = "txtbx_2";
            this.txtbx_2.Size = new System.Drawing.Size(100, 29);
            this.txtbx_2.TabIndex = 2;
            // 
            // txtbx_1
            // 
            this.txtbx_1.Location = new System.Drawing.Point(77, 131);
            this.txtbx_1.Name = "txtbx_1";
            this.txtbx_1.Size = new System.Drawing.Size(100, 29);
            this.txtbx_1.TabIndex = 3;
            // 
            // txtbx_ans
            // 
            this.txtbx_ans.Location = new System.Drawing.Point(226, 318);
            this.txtbx_ans.Name = "txtbx_ans";
            this.txtbx_ans.Size = new System.Drawing.Size(100, 29);
            this.txtbx_ans.TabIndex = 4;
            // 
            // txtbx_Op
            // 
            this.txtbx_Op.Location = new System.Drawing.Point(210, 131);
            this.txtbx_Op.Name = "txtbx_Op";
            this.txtbx_Op.Size = new System.Drawing.Size(37, 29);
            this.txtbx_Op.TabIndex = 5;
            // 
            // label_Operator
            // 
            this.label_Operator.AutoSize = true;
            this.label_Operator.Location = new System.Drawing.Point(183, 103);
            this.label_Operator.Name = "label_Operator";
            this.label_Operator.Size = new System.Drawing.Size(89, 25);
            this.label_Operator.TabIndex = 6;
            this.label_Operator.Text = "Operator";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(77, 208);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(47, 44);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(130, 208);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(47, 44);
            this.btn_sub.TabIndex = 8;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Location = new System.Drawing.Point(183, 208);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(47, 44);
            this.btn_mult.TabIndex = 9;
            this.btn_mult.Text = "*";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(236, 208);
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
            this.Title.Location = new System.Drawing.Point(147, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 25);
            this.Title.TabIndex = 11;
            this.Title.Text = "Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
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
    }
}

