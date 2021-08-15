
namespace ControllerPage
{
    partial class FormThreshold
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_thereshold_maxvalue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_disable = new System.Windows.Forms.RadioButton();
            this.button_thereshold_apply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_thereshold_minvalue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_enable = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_thereshold_maxvalue, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_disable, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_thereshold_apply, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_thereshold_minvalue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_enable, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 14);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(618, 558);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // button_thereshold_maxvalue
            // 
            this.button_thereshold_maxvalue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_thereshold_maxvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thereshold_maxvalue.Location = new System.Drawing.Point(393, 347);
            this.button_thereshold_maxvalue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_thereshold_maxvalue.Name = "button_thereshold_maxvalue";
            this.button_thereshold_maxvalue.Size = new System.Drawing.Size(141, 82);
            this.button_thereshold_maxvalue.TabIndex = 9;
            this.button_thereshold_maxvalue.Text = "12";
            this.button_thereshold_maxvalue.UseVisualStyleBackColor = true;
            this.button_thereshold_maxvalue.Click += new System.EventHandler(this.button_maxthereshold_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(109, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Threshold Setting";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton_disable
            // 
            this.radioButton_disable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_disable.BackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButton_disable.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_disable.Location = new System.Drawing.Point(314, 88);
            this.radioButton_disable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_disable.Name = "radioButton_disable";
            this.radioButton_disable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton_disable.Size = new System.Drawing.Size(298, 129);
            this.radioButton_disable.TabIndex = 5;
            this.radioButton_disable.TabStop = true;
            this.radioButton_disable.Text = "Disable";
            this.radioButton_disable.UseVisualStyleBackColor = false;
            // 
            // button_thereshold_apply
            // 
            this.button_thereshold_apply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_thereshold_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thereshold_apply.Location = new System.Drawing.Point(388, 461);
            this.button_thereshold_apply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_thereshold_apply.Name = "button_thereshold_apply";
            this.button_thereshold_apply.Size = new System.Drawing.Size(150, 80);
            this.button_thereshold_apply.TabIndex = 3;
            this.button_thereshold_apply.Text = "Close";
            this.button_thereshold_apply.UseVisualStyleBackColor = true;
            this.button_thereshold_apply.Click += new System.EventHandler(this.Btn_close_thereshold_click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 370);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Maximum Value";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_thereshold_minvalue
            // 
            this.button_thereshold_minvalue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_thereshold_minvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thereshold_minvalue.Location = new System.Drawing.Point(393, 240);
            this.button_thereshold_minvalue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_thereshold_minvalue.Name = "button_thereshold_minvalue";
            this.button_thereshold_minvalue.Size = new System.Drawing.Size(141, 74);
            this.button_thereshold_minvalue.TabIndex = 8;
            this.button_thereshold_minvalue.Text = "10";
            this.button_thereshold_minvalue.UseVisualStyleBackColor = true;
            this.button_thereshold_minvalue.Click += new System.EventHandler(this.button_minthereshold_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minimum Value";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton_enable
            // 
            this.radioButton_enable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton_enable.BackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButton_enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_enable.Location = new System.Drawing.Point(5, 88);
            this.radioButton_enable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_enable.Name = "radioButton_enable";
            this.radioButton_enable.Size = new System.Drawing.Size(300, 129);
            this.radioButton_enable.TabIndex = 4;
            this.radioButton_enable.TabStop = true;
            this.radioButton_enable.Text = "Enable";
            this.radioButton_enable.UseVisualStyleBackColor = false;
            this.radioButton_enable.CheckedChanged += new System.EventHandler(this.radioButton_enable_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(79, 461);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 80);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_TheresholdApply_Click);
            // 
            // FormThreshold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 591);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormThreshold";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThreshold";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_thereshold_apply;
        private System.Windows.Forms.RadioButton radioButton_enable;
        private System.Windows.Forms.RadioButton radioButton_disable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button_thereshold_maxvalue;
        public System.Windows.Forms.Button button_thereshold_minvalue;
        private System.Windows.Forms.Button button1;
    }
}