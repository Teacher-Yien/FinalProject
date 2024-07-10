using System.Drawing;
using System.Windows.Forms;

namespace Shcool_management
{
	partial class Invoice
	{
		private System.ComponentModel.IContainer components = null;

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

		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.BookID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HireDate = new System.Windows.Forms.Label();
            this.txtInvNo = new System.Windows.Forms.TextBox();
            this.txtPaidAmo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtToAmo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.ComMajorID = new System.Windows.Forms.ComboBox();
            this.ComStuID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.ComStaffID = new System.Windows.Forms.ComboBox();
            this.txtStaffPos = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ស្វែងរក";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F);
            this.txtSearch.Location = new System.Drawing.Point(34, 73);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(265, 44);
            this.txtSearch.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.Font = new System.Drawing.Font("!Khmer OS Siemreap", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(35, 616);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(201, 60);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "បញ្ចូលវិកាយប័ត្រ";
            this.btnInsert.UseVisualStyleBackColor = false;
            // 
            // BookID
            // 
            this.BookID.AutoSize = true;
            this.BookID.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookID.Location = new System.Drawing.Point(506, 94);
            this.BookID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(190, 39);
            this.BookID.TabIndex = 0;
            this.BookID.Text = "លេខសម្គាល់វិក្ក័យប័ត្រ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(506, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "តម្លៃសរុប";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(506, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "លេខសម្គាល់ជំនាញ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(506, 348);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 39);
            this.label6.TabIndex = 0;
            this.label6.Text = "លេខសម្គាល់សិស្ស";
            // 
            // HireDate
            // 
            this.HireDate.AutoSize = true;
            this.HireDate.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HireDate.Location = new System.Drawing.Point(506, 504);
            this.HireDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HireDate.Name = "HireDate";
            this.HireDate.Size = new System.Drawing.Size(126, 39);
            this.HireDate.TabIndex = 0;
            this.HireDate.Text = "ឈ្មោះបុគ្គលិក";
            // 
            // txtInvNo
            // 
            this.txtInvNo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtInvNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvNo.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F);
            this.txtInvNo.Location = new System.Drawing.Point(701, 88);
            this.txtInvNo.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txtInvNo.Name = "txtInvNo";
            this.txtInvNo.ReadOnly = true;
            this.txtInvNo.Size = new System.Drawing.Size(454, 44);
            this.txtInvNo.TabIndex = 1;
            // 
            // txtPaidAmo
            // 
            this.txtPaidAmo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaidAmo.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F);
            this.txtPaidAmo.Location = new System.Drawing.Point(701, 242);
            this.txtPaidAmo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPaidAmo.Name = "txtPaidAmo";
            this.txtPaidAmo.Size = new System.Drawing.Size(454, 44);
            this.txtPaidAmo.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(305, 72);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 47);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "ស្វែងរក";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtToAmo
            // 
            this.txtToAmo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToAmo.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F);
            this.txtToAmo.Location = new System.Drawing.Point(701, 191);
            this.txtToAmo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtToAmo.Name = "txtToAmo";
            this.txtToAmo.Size = new System.Drawing.Size(454, 44);
            this.txtToAmo.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(508, 399);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 39);
            this.label10.TabIndex = 0;
            this.label10.Text = "ឈ្មោះសិស្ស";
            // 
            // txtStaffName
            // 
            this.txtStaffName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStaffName.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F);
            this.txtStaffName.Location = new System.Drawing.Point(701, 499);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(454, 44);
            this.txtStaffName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("!Khmer OS Siemreap", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(325, 616);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "កែប្រែវិកាយប័ត្រ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(506, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "ថ្ងៃចេញវិក្ក័យប័ត្រ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(506, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "ចំនួនសរុប";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(506, 552);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "តួនាទីបុគ្គលិក";
            // 
            // txtDate
            // 
            this.txtDate.CalendarFont = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(701, 145);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(454, 33);
            this.txtDate.TabIndex = 4;
            // 
            // ComMajorID
            // 
            this.ComMajorID.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F);
            this.ComMajorID.FormattingEnabled = true;
            this.ComMajorID.Location = new System.Drawing.Point(701, 292);
            this.ComMajorID.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ComMajorID.Name = "ComMajorID";
            this.ComMajorID.Size = new System.Drawing.Size(456, 44);
            this.ComMajorID.TabIndex = 5;
            // 
            // ComStuID
            // 
            this.ComStuID.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F);
            this.ComStuID.FormattingEnabled = true;
            this.ComStuID.Location = new System.Drawing.Point(701, 344);
            this.ComStuID.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ComStuID.Name = "ComStuID";
            this.ComStuID.Size = new System.Drawing.Size(456, 44);
            this.ComStuID.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(508, 450);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 39);
            this.label8.TabIndex = 0;
            this.label8.Text = "លេខសម្គាល់បុគ្គលិក";
            // 
            // txtStuName
            // 
            this.txtStuName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStuName.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F);
            this.txtStuName.Location = new System.Drawing.Point(701, 395);
            this.txtStuName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(454, 44);
            this.txtStuName.TabIndex = 1;
            // 
            // ComStaffID
            // 
            this.ComStaffID.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F);
            this.ComStaffID.FormattingEnabled = true;
            this.ComStaffID.Location = new System.Drawing.Point(701, 448);
            this.ComStaffID.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ComStaffID.Name = "ComStaffID";
            this.ComStaffID.Size = new System.Drawing.Size(456, 44);
            this.ComStaffID.TabIndex = 5;
            // 
            // txtStaffPos
            // 
            this.txtStaffPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStaffPos.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F);
            this.txtStaffPos.Location = new System.Drawing.Point(701, 549);
            this.txtStaffPos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStaffPos.Name = "txtStaffPos";
            this.txtStaffPos.Size = new System.Drawing.Size(454, 44);
            this.txtStaffPos.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(34, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 446);
            this.panel1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("!Khmer OS Siemreap", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1033, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 64);
            this.button2.TabIndex = 8;
            this.button2.Text = "បោះពុម្ព";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 689);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ComStaffID);
            this.Controls.Add(this.ComStuID);
            this.Controls.Add(this.ComMajorID);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.txtStaffPos);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.txtPaidAmo);
            this.Controls.Add(this.txtToAmo);
            this.Controls.Add(this.txtInvNo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HireDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Invoice";
            this.Text = "Invoice\'s Form";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Label label1;
		private TextBox txtSearch;
		private Button btnInsert;
		private Label BookID;
		private Label label3;
		private Label label5;
		private Label label6;
		private Label HireDate;
		private TextBox txtInvNo;
		private TextBox txtPaidAmo;
		private Button btnSearch;
		private TextBox txtToAmo;
		private Label label10;
		private TextBox txtStaffName;
		private Button button1;
		private Label label2;
		private Label label4;
		private Label label7;
		private DateTimePicker txtDate;
		private ComboBox ComMajorID;
		private ComboBox ComStuID;
		private Label label8;
		private TextBox txtStuName;
		private ComboBox ComStaffID;
		private TextBox txtStaffPos;
		private Panel panel1;
		private Button button2;
	}
}