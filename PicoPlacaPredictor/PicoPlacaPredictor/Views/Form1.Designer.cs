
namespace PicoPlacaPredictor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtxtTime = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDate = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnVerify = new System.Windows.Forms.Button();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plate Numbers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(175)))), ((int)(((byte)(197)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.mtxtTime);
            this.panel1.Controls.Add(this.mtxtDate);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnVerify);
            this.panel1.Controls.Add(this.txtPlateNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 343);
            this.panel1.TabIndex = 3;
            // 
            // mtxtTime
            // 
            this.mtxtTime.Location = new System.Drawing.Point(120, 195);
            this.mtxtTime.Mask = "00:00";
            this.mtxtTime.Name = "mtxtTime";
            this.mtxtTime.Size = new System.Drawing.Size(141, 20);
            this.mtxtTime.TabIndex = 11;
            this.mtxtTime.ValidatingType = typeof(System.DateTime);
            this.mtxtTime.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtDate_MaskInputRejected);
            // 
            // mtxtDate
            // 
            this.mtxtDate.Location = new System.Drawing.Point(120, 108);
            this.mtxtDate.Mask = "00/00/0000";
            this.mtxtDate.Name = "mtxtDate";
            this.mtxtDate.Size = new System.Drawing.Size(141, 20);
            this.mtxtDate.TabIndex = 10;
            this.mtxtDate.ValidatingType = typeof(System.DateTime);
            this.mtxtDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtDate_MaskInputRejected);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(330, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 2, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.Silver;
            this.btnVerify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.Black;
            this.btnVerify.Image = ((System.Drawing.Image)(resources.GetObject("btnVerify.Image")));
            this.btnVerify.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerify.Location = new System.Drawing.Point(178, 267);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(181, 31);
            this.btnVerify.TabIndex = 6;
            this.btnVerify.Text = "VERIFY";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Location = new System.Drawing.Point(120, 33);
            this.txtPlateNumber.MaxLength = 4;
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(141, 20);
            this.txtPlateNumber.TabIndex = 3;
            this.txtPlateNumber.Text = "###";
            this.txtPlateNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlateNumber_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 118);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox mtxtDate;
        private System.Windows.Forms.MaskedTextBox mtxtTime;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

