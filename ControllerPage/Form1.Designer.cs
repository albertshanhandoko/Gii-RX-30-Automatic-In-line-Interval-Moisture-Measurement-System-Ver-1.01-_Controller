
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControllerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Button_Interface = new System.Windows.Forms.Button();
            this.Button_Mode = new System.Windows.Forms.Button();
            this.ButtonIPSet = new System.Windows.Forms.Button();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.Btn_CheckTemp = new System.Windows.Forms.Button();
            this.Temp_TextBox = new System.Windows.Forms.TextBox();
            this.textBox_Sensor_Status = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Btn_Check = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.ButtonProduct = new System.Windows.Forms.Button();
            this.ButtonNumInterval = new System.Windows.Forms.Button();
            this.ButtonNumPcs = new System.Windows.Forms.Button();
            this.ButtonWaitingTime = new System.Windows.Forms.Button();
            this.ButtonOption = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.Curr_Interval_TextBox = new System.Windows.Forms.TextBox();
            this.Current_Avg_TextBox = new System.Windows.Forms.TextBox();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.label_ipaddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Curr_Kernel_TextBox = new System.Windows.Forms.TextBox();
            this.Curr_Measure_TextBox = new System.Windows.Forms.TextBox();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.996961F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.996961F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.996961F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.996961F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.02735F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.996961F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.996961F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.996961F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.996961F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.996961F));
            this.tableLayoutPanel1.Controls.Add(this.Button_Interface, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button_Mode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonIPSet, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox16, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_CheckTemp, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.Temp_TextBox, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Sensor_Status, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Check, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox8, 4, 9);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.textBox9, 6, 9);
            this.tableLayoutPanel1.Controls.Add(this.ButtonProduct, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.ButtonNumInterval, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.ButtonNumPcs, 4, 10);
            this.tableLayoutPanel1.Controls.Add(this.ButtonWaitingTime, 6, 10);
            this.tableLayoutPanel1.Controls.Add(this.ButtonOption, 8, 10);
            this.tableLayoutPanel1.Controls.Add(this.textBox10, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox14, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.Curr_Interval_TextBox, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.Current_Avg_TextBox, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Start, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_ipaddress, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 8, 9);
            this.tableLayoutPanel1.Controls.Add(this.Curr_Kernel_TextBox, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.Curr_Measure_TextBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Stop, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox15, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, -5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.390748F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.955863F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.486254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.02439F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.341464F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.268292F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.536586F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.04878F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.390749F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.390749F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.390749F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.390749F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(667, 419);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Button_Interface
            // 
            this.Button_Interface.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Interface.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.SetColumnSpan(this.Button_Interface, 2);
            this.Button_Interface.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Interface.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_Interface.Location = new System.Drawing.Point(136, 42);
            this.Button_Interface.Name = "Button_Interface";
            this.tableLayoutPanel1.SetRowSpan(this.Button_Interface, 2);
            this.Button_Interface.Size = new System.Drawing.Size(124, 53);
            this.Button_Interface.TabIndex = 66;
            this.Button_Interface.Text = "INTERFACE";
            this.Button_Interface.UseVisualStyleBackColor = false;
            this.Button_Interface.Click += new System.EventHandler(this.Button_Interface_Click);
            // 
            // Button_Mode
            // 
            this.Button_Mode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Mode.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.SetColumnSpan(this.Button_Mode, 2);
            this.Button_Mode.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Mode.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_Mode.Location = new System.Drawing.Point(4, 42);
            this.Button_Mode.Name = "Button_Mode";
            this.tableLayoutPanel1.SetRowSpan(this.Button_Mode, 2);
            this.Button_Mode.Size = new System.Drawing.Size(124, 53);
            this.Button_Mode.TabIndex = 65;
            this.Button_Mode.Text = "MODE";
            this.Button_Mode.UseVisualStyleBackColor = false;
            this.Button_Mode.Click += new System.EventHandler(this.Button_Mode_Click);
            // 
            // ButtonIPSet
            // 
            this.ButtonIPSet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonIPSet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.SetColumnSpan(this.ButtonIPSet, 2);
            this.ButtonIPSet.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonIPSet.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonIPSet.Location = new System.Drawing.Point(532, 42);
            this.ButtonIPSet.Name = "ButtonIPSet";
            this.tableLayoutPanel1.SetRowSpan(this.ButtonIPSet, 2);
            this.ButtonIPSet.Size = new System.Drawing.Size(131, 54);
            this.ButtonIPSet.TabIndex = 62;
            this.ButtonIPSet.Text = "1";
            this.ButtonIPSet.UseVisualStyleBackColor = false;
            this.ButtonIPSet.Click += new System.EventHandler(this.ButtonIPSet_Click);
            // 
            // textBox16
            // 
            this.textBox16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox16.BackColor = System.Drawing.SystemColors.Control;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox16, 2);
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(44, 9);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(44, 16);
            this.textBox16.TabIndex = 5;
            this.textBox16.Text = "Mode";
            // 
            // Btn_CheckTemp
            // 
            this.Btn_CheckTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_CheckTemp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.SetColumnSpan(this.Btn_CheckTemp, 2);
            this.Btn_CheckTemp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CheckTemp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_CheckTemp.Location = new System.Drawing.Point(267, 42);
            this.Btn_CheckTemp.Name = "Btn_CheckTemp";
            this.tableLayoutPanel1.SetRowSpan(this.Btn_CheckTemp, 2);
            this.Btn_CheckTemp.Size = new System.Drawing.Size(125, 53);
            this.Btn_CheckTemp.TabIndex = 7;
            this.Btn_CheckTemp.Text = "CHECK";
            this.Btn_CheckTemp.UseVisualStyleBackColor = false;
            this.Btn_CheckTemp.Click += new System.EventHandler(this.button_CheckTemp_Click);
            // 
            // Temp_TextBox
            // 
            this.Temp_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Temp_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Temp_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Temp_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temp_TextBox.Location = new System.Drawing.Point(333, 9);
            this.Temp_TextBox.Name = "Temp_TextBox";
            this.Temp_TextBox.Size = new System.Drawing.Size(42, 17);
            this.Temp_TextBox.TabIndex = 4;
            this.Temp_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Sensor_Status
            // 
            this.textBox_Sensor_Status.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_Sensor_Status.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Sensor_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Sensor_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Sensor_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox_Sensor_Status.Location = new System.Drawing.Point(465, 9);
            this.textBox_Sensor_Status.Name = "textBox_Sensor_Status";
            this.textBox_Sensor_Status.Size = new System.Drawing.Size(59, 16);
            this.textBox_Sensor_Status.TabIndex = 3;
            this.textBox_Sensor_Status.Text = "Online";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(399, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 16);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Status";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 2);
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(171, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 16);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Interface";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(267, 9);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(44, 16);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Temp";
            // 
            // Btn_Check
            // 
            this.Btn_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Check.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.SetColumnSpan(this.Btn_Check, 2);
            this.Btn_Check.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Check.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Check.Location = new System.Drawing.Point(400, 42);
            this.Btn_Check.Name = "Btn_Check";
            this.tableLayoutPanel1.SetRowSpan(this.Btn_Check, 2);
            this.Btn_Check.Size = new System.Drawing.Size(124, 53);
            this.Btn_Check.TabIndex = 6;
            this.Btn_Check.Text = "CHECK";
            this.Btn_Check.UseVisualStyleBackColor = false;
            this.Btn_Check.Click += new System.EventHandler(this.Btn_Check_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(3, 275);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(0, 19);
            this.textBox5.TabIndex = 37;
            this.textBox5.Text = "Option";
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox8, 2);
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(275, 316);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(110, 16);
            this.textBox8.TabIndex = 10;
            this.textBox8.Text = "PCS per Interval";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox7, 2);
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(154, 316);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(87, 16);
            this.textBox7.TabIndex = 9;
            this.textBox7.Text = "No. of Intervals";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox6, 2);
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(38, 316);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(56, 17);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "Product";
            // 
            // textBox9
            // 
            this.textBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox9.BackColor = System.Drawing.SystemColors.Control;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox9, 2);
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(400, 316);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(124, 16);
            this.textBox9.TabIndex = 11;
            this.textBox9.Text = "Int. Waiting Time";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonProduct
            // 
            this.ButtonProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonProduct.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.SetColumnSpan(this.ButtonProduct, 2);
            this.ButtonProduct.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonProduct.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonProduct.Location = new System.Drawing.Point(4, 347);
            this.ButtonProduct.Name = "ButtonProduct";
            this.tableLayoutPanel1.SetRowSpan(this.ButtonProduct, 2);
            this.ButtonProduct.Size = new System.Drawing.Size(124, 66);
            this.ButtonProduct.TabIndex = 1;
            this.ButtonProduct.Text = "Corn";
            this.ButtonProduct.UseVisualStyleBackColor = false;
            this.ButtonProduct.Click += new System.EventHandler(this.button_Product_Click);
            // 
            // ButtonNumInterval
            // 
            this.ButtonNumInterval.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonNumInterval.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.SetColumnSpan(this.ButtonNumInterval, 2);
            this.ButtonNumInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNumInterval.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonNumInterval.Location = new System.Drawing.Point(136, 347);
            this.ButtonNumInterval.Name = "ButtonNumInterval";
            this.tableLayoutPanel1.SetRowSpan(this.ButtonNumInterval, 2);
            this.ButtonNumInterval.Size = new System.Drawing.Size(124, 66);
            this.ButtonNumInterval.TabIndex = 49;
            this.ButtonNumInterval.Text = "1";
            this.ButtonNumInterval.UseVisualStyleBackColor = false;
            this.ButtonNumInterval.Click += new System.EventHandler(this.button_NumInterval_Click);
            // 
            // ButtonNumPcs
            // 
            this.ButtonNumPcs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonNumPcs.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.SetColumnSpan(this.ButtonNumPcs, 2);
            this.ButtonNumPcs.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNumPcs.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonNumPcs.Location = new System.Drawing.Point(267, 347);
            this.ButtonNumPcs.Name = "ButtonNumPcs";
            this.tableLayoutPanel1.SetRowSpan(this.ButtonNumPcs, 2);
            this.ButtonNumPcs.Size = new System.Drawing.Size(125, 66);
            this.ButtonNumPcs.TabIndex = 50;
            this.ButtonNumPcs.Text = "10";
            this.ButtonNumPcs.UseVisualStyleBackColor = false;
            this.ButtonNumPcs.Click += new System.EventHandler(this.button_NumPerPcs_Click);
            // 
            // ButtonWaitingTime
            // 
            this.ButtonWaitingTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonWaitingTime.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.SetColumnSpan(this.ButtonWaitingTime, 2);
            this.ButtonWaitingTime.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonWaitingTime.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonWaitingTime.Location = new System.Drawing.Point(400, 347);
            this.ButtonWaitingTime.Name = "ButtonWaitingTime";
            this.tableLayoutPanel1.SetRowSpan(this.ButtonWaitingTime, 2);
            this.ButtonWaitingTime.Size = new System.Drawing.Size(124, 66);
            this.ButtonWaitingTime.TabIndex = 51;
            this.ButtonWaitingTime.Text = "1 min";
            this.ButtonWaitingTime.UseVisualStyleBackColor = false;
            this.ButtonWaitingTime.Click += new System.EventHandler(this.button_Time_Click);
            // 
            // ButtonOption
            // 
            this.ButtonOption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonOption.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.SetColumnSpan(this.ButtonOption, 2);
            this.ButtonOption.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOption.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonOption.Location = new System.Drawing.Point(532, 347);
            this.ButtonOption.Name = "ButtonOption";
            this.tableLayoutPanel1.SetRowSpan(this.ButtonOption, 2);
            this.ButtonOption.Size = new System.Drawing.Size(131, 66);
            this.ButtonOption.TabIndex = 52;
            this.ButtonOption.Text = "ENTER";
            this.ButtonOption.UseVisualStyleBackColor = false;
            this.ButtonOption.Click += new System.EventHandler(this.button_Option_Click);
            // 
            // textBox10
            // 
            this.textBox10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox10.BackColor = System.Drawing.SystemColors.Control;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(267, 108);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(60, 26);
            this.textBox10.TabIndex = 47;
            this.textBox10.Text = "Interval Number";
            // 
            // textBox14
            // 
            this.textBox14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox14.BackColor = System.Drawing.SystemColors.Control;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(267, 172);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(60, 26);
            this.textBox14.TabIndex = 23;
            this.textBox14.Text = "Kernel Counter";
            // 
            // Curr_Interval_TextBox
            // 
            this.Curr_Interval_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Curr_Interval_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Curr_Interval_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Curr_Interval_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Curr_Interval_TextBox.Location = new System.Drawing.Point(333, 107);
            this.Curr_Interval_TextBox.Name = "Curr_Interval_TextBox";
            this.Curr_Interval_TextBox.Size = new System.Drawing.Size(59, 28);
            this.Curr_Interval_TextBox.TabIndex = 25;
            // 
            // Current_Avg_TextBox
            // 
            this.Current_Avg_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Current_Avg_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Current_Avg_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Current_Avg_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Current_Avg_TextBox.Location = new System.Drawing.Point(333, 242);
            this.Current_Avg_TextBox.Name = "Current_Avg_TextBox";
            this.Current_Avg_TextBox.Size = new System.Drawing.Size(59, 28);
            this.Current_Avg_TextBox.TabIndex = 27;
            // 
            // Btn_Start
            // 
            this.Btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Start.BackColor = System.Drawing.Color.Lime;
            this.tableLayoutPanel1.SetColumnSpan(this.Btn_Start, 4);
            this.Btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Start.Location = new System.Drawing.Point(435, 106);
            this.Btn_Start.Name = "Btn_Start";
            this.tableLayoutPanel1.SetRowSpan(this.Btn_Start, 3);
            this.Btn_Start.Size = new System.Drawing.Size(192, 95);
            this.Btn_Start.TabIndex = 28;
            this.Btn_Start.Text = "START";
            this.Btn_Start.UseVisualStyleBackColor = false;
            this.Btn_Start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_ipaddress
            // 
            this.label_ipaddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ipaddress.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_ipaddress, 2);
            this.label_ipaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ipaddress.Location = new System.Drawing.Point(597, 9);
            this.label_ipaddress.Name = "label_ipaddress";
            this.label_ipaddress.Size = new System.Drawing.Size(0, 16);
            this.label_ipaddress.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 2);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(570, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Options";
            // 
            // Curr_Kernel_TextBox
            // 
            this.Curr_Kernel_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Curr_Kernel_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Curr_Kernel_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Curr_Kernel_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Curr_Kernel_TextBox.Location = new System.Drawing.Point(333, 171);
            this.Curr_Kernel_TextBox.Name = "Curr_Kernel_TextBox";
            this.Curr_Kernel_TextBox.Size = new System.Drawing.Size(59, 28);
            this.Curr_Kernel_TextBox.TabIndex = 26;
            // 
            // Curr_Measure_TextBox
            // 
            this.Curr_Measure_TextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Curr_Measure_TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.Curr_Measure_TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Curr_Measure_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.Curr_Measure_TextBox, 4);
            this.Curr_Measure_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Curr_Measure_TextBox.Location = new System.Drawing.Point(14, 173);
            this.Curr_Measure_TextBox.Name = "Curr_Measure_TextBox";
            this.tableLayoutPanel1.SetRowSpan(this.Curr_Measure_TextBox, 3);
            this.Curr_Measure_TextBox.Size = new System.Drawing.Size(235, 91);
            this.Curr_Measure_TextBox.TabIndex = 21;
            this.Curr_Measure_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Stop.BackColor = System.Drawing.Color.Red;
            this.tableLayoutPanel1.SetColumnSpan(this.Btn_Stop, 4);
            this.Btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Stop.Location = new System.Drawing.Point(435, 207);
            this.Btn_Stop.Name = "Btn_Stop";
            this.tableLayoutPanel1.SetRowSpan(this.Btn_Stop, 3);
            this.Btn_Stop.Size = new System.Drawing.Size(192, 97);
            this.Btn_Stop.TabIndex = 29;
            this.Btn_Stop.Text = "STOP";
            this.Btn_Stop.UseVisualStyleBackColor = false;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // textBox15
            // 
            this.textBox15.AcceptsReturn = true;
            this.textBox15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox15.BackColor = System.Drawing.SystemColors.Control;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(267, 242);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(60, 26);
            this.textBox15.TabIndex = 24;
            this.textBox15.Text = "Average Moisture";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(13, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 32);
            this.label1.TabIndex = 64;
            this.label1.Text = "Current Interval Moisture Measurement";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 413);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gii RX-30 Automatic In-line Interval Moisture Measurement System (Ver 1.01)";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_CheckTemp;
        private System.Windows.Forms.TextBox textBox_Sensor_Status;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Btn_Check;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Curr_Measure_TextBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox Temp_TextBox;
        private System.Windows.Forms.TextBox Curr_Interval_TextBox;
        private System.Windows.Forms.TextBox Curr_Kernel_TextBox;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox Current_Avg_TextBox;
        private System.Windows.Forms.Button ButtonProduct;
        private System.Windows.Forms.Button ButtonNumInterval;
        private System.Windows.Forms.Button ButtonNumPcs;
        private System.Windows.Forms.Button ButtonWaitingTime;
        private System.Windows.Forms.Button ButtonOption;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button ButtonIPSet;
        private System.Windows.Forms.Label label_ipaddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Interface;
        private System.Windows.Forms.Button Button_Mode;
    }
}

