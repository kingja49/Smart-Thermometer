
namespace WindowsFormsApp_11_10_SEC1
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
            this.components = new System.ComponentModel.Container();
            this.Current_Data = new System.Windows.Forms.Label();
            this.Serial_Start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Serial_Stop = new System.Windows.Forms.Button();
            this.Read_in_TS = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Current_Data
            // 
            this.Current_Data.AutoSize = true;
            this.Current_Data.Location = new System.Drawing.Point(144, 355);
            this.Current_Data.Name = "Current_Data";
            this.Current_Data.Size = new System.Drawing.Size(89, 17);
            this.Current_Data.TabIndex = 0;
            this.Current_Data.Text = "Current Data";
            this.Current_Data.Click += new System.EventHandler(this.Current_Data_Click);
            // 
            // Serial_Start
            // 
            this.Serial_Start.AccessibleName = "Serial Start";
            this.Serial_Start.Location = new System.Drawing.Point(128, 87);
            this.Serial_Start.Name = "Serial_Start";
            this.Serial_Start.Size = new System.Drawing.Size(101, 38);
            this.Serial_Start.TabIndex = 1;
            this.Serial_Start.Text = "Serial Start";
            this.Serial_Start.UseVisualStyleBackColor = true;
            this.Serial_Start.Click += new System.EventHandler(this.Serial_Start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Serial_Stop
            // 
            this.Serial_Stop.Location = new System.Drawing.Point(355, 87);
            this.Serial_Stop.Name = "Serial_Stop";
            this.Serial_Stop.Size = new System.Drawing.Size(115, 38);
            this.Serial_Stop.TabIndex = 3;
            this.Serial_Stop.Text = "Serial Stop";
            this.Serial_Stop.UseVisualStyleBackColor = true;
            this.Serial_Stop.Click += new System.EventHandler(this.Serial_Stop_Click);
            // 
            // Read_in_TS
            // 
            this.Read_in_TS.Location = new System.Drawing.Point(128, 221);
            this.Read_in_TS.Name = "Read_in_TS";
            this.Read_in_TS.Size = new System.Drawing.Size(101, 39);
            this.Read_in_TS.TabIndex = 4;
            this.Read_in_TS.Text = "Read in TS";
            this.Read_in_TS.UseVisualStyleBackColor = true;
            this.Read_in_TS.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(370, 352);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM11";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 713);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Read_in_TS);
            this.Controls.Add(this.Serial_Stop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Serial_Start);
            this.Controls.Add(this.Current_Data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Current_Data;
        private System.Windows.Forms.Button Serial_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Serial_Stop;
        private System.Windows.Forms.Button Read_in_TS;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}

