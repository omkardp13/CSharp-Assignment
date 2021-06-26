
namespace _1DArray
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
            this.lbl_Employee_ID = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Maximum = new System.Windows.Forms.Button();
            this.btn_Sum = new System.Windows.Forms.Button();
            this.tb_Maximum = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Employee_Master = new System.Windows.Forms.Label();
            this.tb_Sum = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Employee_ID
            // 
            this.lbl_Employee_ID.AutoSize = true;
            this.lbl_Employee_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_ID.Location = new System.Drawing.Point(167, 127);
            this.lbl_Employee_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Employee_ID.Name = "lbl_Employee_ID";
            this.lbl_Employee_ID.Size = new System.Drawing.Size(68, 29);
            this.lbl_Employee_ID.TabIndex = 88;
            this.lbl_Employee_ID.Text = "Array";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 46;
            this.listBox1.Location = new System.Drawing.Point(142, 207);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(114, 280);
            this.listBox1.TabIndex = 89;
            // 
            // btn_Maximum
            // 
            this.btn_Maximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Maximum.ForeColor = System.Drawing.Color.Chocolate;
            this.btn_Maximum.Location = new System.Drawing.Point(615, 217);
            this.btn_Maximum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Maximum.Name = "btn_Maximum";
            this.btn_Maximum.Size = new System.Drawing.Size(238, 53);
            this.btn_Maximum.TabIndex = 183;
            this.btn_Maximum.Text = "Maximum ";
            this.btn_Maximum.UseVisualStyleBackColor = true;
            this.btn_Maximum.Click += new System.EventHandler(this.btn_Maximum_Click);
            // 
            // btn_Sum
            // 
            this.btn_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sum.ForeColor = System.Drawing.Color.Chocolate;
            this.btn_Sum.Location = new System.Drawing.Point(615, 368);
            this.btn_Sum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Sum.Name = "btn_Sum";
            this.btn_Sum.Size = new System.Drawing.Size(238, 63);
            this.btn_Sum.TabIndex = 184;
            this.btn_Sum.Text = "Sum";
            this.btn_Sum.UseVisualStyleBackColor = true;
            this.btn_Sum.Click += new System.EventHandler(this.btn_Sum_Click);
            // 
            // tb_Maximum
            // 
            this.tb_Maximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Maximum.Location = new System.Drawing.Point(955, 217);
            this.tb_Maximum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Maximum.MaxLength = 20;
            this.tb_Maximum.Name = "tb_Maximum";
            this.tb_Maximum.Size = new System.Drawing.Size(455, 53);
            this.tb_Maximum.TabIndex = 185;
            this.tb_Maximum.TextChanged += new System.EventHandler(this.tb_Maximum_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Chocolate;
            this.button2.Location = new System.Drawing.Point(51, 539);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(339, 63);
            this.button2.TabIndex = 187;
            this.button2.Text = "Display Array";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Chocolate;
            this.btn_Clear.Location = new System.Drawing.Point(615, 539);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(238, 63);
            this.btn_Clear.TabIndex = 188;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Chocolate;
            this.button1.Location = new System.Drawing.Point(1049, 539);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 63);
            this.button1.TabIndex = 189;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.lbl_Employee_Master);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1491, 87);
            this.panel1.TabIndex = 190;
            // 
            // lbl_Employee_Master
            // 
            this.lbl_Employee_Master.AutoSize = true;
            this.lbl_Employee_Master.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Master.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Employee_Master.Location = new System.Drawing.Point(634, 9);
            this.lbl_Employee_Master.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Employee_Master.Name = "lbl_Employee_Master";
            this.lbl_Employee_Master.Size = new System.Drawing.Size(237, 57);
            this.lbl_Employee_Master.TabIndex = 32;
            this.lbl_Employee_Master.Text = "1-D Array";
            // 
            // tb_Sum
            // 
            this.tb_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sum.Location = new System.Drawing.Point(955, 371);
            this.tb_Sum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Sum.MaxLength = 20;
            this.tb_Sum.Name = "tb_Sum";
            this.tb_Sum.Size = new System.Drawing.Size(455, 53);
            this.tb_Sum.TabIndex = 186;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1491, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_Sum);
            this.Controls.Add(this.tb_Maximum);
            this.Controls.Add(this.btn_Sum);
            this.Controls.Add(this.btn_Maximum);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_Employee_ID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_ID;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Maximum;
        private System.Windows.Forms.Button btn_Sum;
        private System.Windows.Forms.TextBox tb_Maximum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Employee_Master;
        private System.Windows.Forms.TextBox tb_Sum;
    }
}

