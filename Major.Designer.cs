using System.Windows.Forms;

namespace Shcool_management
{
	partial class Major
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
            this.lstMajor = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkMaj = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMajDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMajNameKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMajName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMajID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDepID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDepName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstMajor
            // 
            this.lstMajor.FormattingEnabled = true;
            this.lstMajor.ItemHeight = 40;
            this.lstMajor.Location = new System.Drawing.Point(13, 132);
            this.lstMajor.Name = "lstMajor";
            this.lstMajor.Size = new System.Drawing.Size(263, 364);
            this.lstMajor.TabIndex = 24;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 89);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(263, 37);
            this.txtSearch.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 39);
            this.label1.TabIndex = 27;
            this.label1.Text = "ស្វែងរកជំនាញ";
            // 
            // checkMaj
            // 
            this.checkMaj.AutoSize = true;
            this.checkMaj.Location = new System.Drawing.Point(147, 560);
            this.checkMaj.Name = "checkMaj";
            this.checkMaj.Size = new System.Drawing.Size(18, 17);
            this.checkMaj.TabIndex = 36;
            this.checkMaj.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 39);
            this.label4.TabIndex = 35;
            this.label4.Text = "ពណ៌នាមុខជំនាញ៖";
            // 
            // txtMajDesc
            // 
            this.txtMajDesc.Location = new System.Drawing.Point(521, 365);
            this.txtMajDesc.Multiline = true;
            this.txtMajDesc.Name = "txtMajDesc";
            this.txtMajDesc.Size = new System.Drawing.Size(238, 37);
            this.txtMajDesc.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 39);
            this.label3.TabIndex = 33;
            this.label3.Text = "ឈ្មោះជំនាញ(ខ្មែរ)៖";
            // 
            // txtMajNameKH
            // 
            this.txtMajNameKH.Location = new System.Drawing.Point(521, 249);
            this.txtMajNameKH.Multiline = true;
            this.txtMajNameKH.Name = "txtMajNameKH";
            this.txtMajNameKH.Size = new System.Drawing.Size(238, 37);
            this.txtMajNameKH.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 39);
            this.label2.TabIndex = 31;
            this.label2.Text = "ឈ្មោះជំនាញ៖";
            // 
            // txtMajName
            // 
            this.txtMajName.Location = new System.Drawing.Point(521, 187);
            this.txtMajName.Multiline = true;
            this.txtMajName.Name = "txtMajName";
            this.txtMajName.Size = new System.Drawing.Size(238, 37);
            this.txtMajName.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 39);
            this.label5.TabIndex = 29;
            this.label5.Text = "លេខសម្គាល់ជំនាញ៖";
            // 
            // txtMajID
            // 
            this.txtMajID.Location = new System.Drawing.Point(521, 130);
            this.txtMajID.Multiline = true;
            this.txtMajID.Name = "txtMajID";
            this.txtMajID.Size = new System.Drawing.Size(238, 37);
            this.txtMajID.TabIndex = 28;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(338, 620);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 49);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "លុប";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(163, 620);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 49);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.Text = "កែតម្រូវ";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(13, 620);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(113, 49);
            this.btnNew.TabIndex = 37;
            this.btnNew.Text = "បន្ថែមថ្មី";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(567, 620);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(113, 49);
            this.btnLogOut.TabIndex = 40;
            this.btnLogOut.Text = "ចាកចេញ";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 550);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 39);
            this.label6.TabIndex = 41;
            this.label6.Text = "នៅដំណើរការ៖";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(291, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 39);
            this.label7.TabIndex = 43;
            this.label7.Text = "លេខសម្គាល់ដេប៉ាតឺម៉ង់៖";
            // 
            // txtDepID
            // 
            this.txtDepID.Location = new System.Drawing.Point(521, 425);
            this.txtDepID.Multiline = true;
            this.txtDepID.Name = "txtDepID";
            this.txtDepID.Size = new System.Drawing.Size(238, 37);
            this.txtDepID.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(291, 488);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 39);
            this.label8.TabIndex = 45;
            this.label8.Text = "ឈ្មោះដេប៉ាតឺម៉ង់៖";
            // 
            // txtDepName
            // 
            this.txtDepName.Location = new System.Drawing.Point(521, 484);
            this.txtDepName.Multiline = true;
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(238, 37);
            this.txtDepName.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Khmer OS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(291, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 39);
            this.label9.TabIndex = 47;
            this.label9.Text = "តម្លៃជំនាញ៖";
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(521, 303);
            this.txtFee.Multiline = true;
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(238, 37);
            this.txtFee.TabIndex = 46;
            // 
            // Major
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 713);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDepName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDepID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.checkMaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMajDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMajNameKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMajName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMajID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstMajor);
            this.Font = new System.Drawing.Font("Khmer OS", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Major";
            this.Text = "Major";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private ListBox lstMajor;
		private TextBox txtSearch;
		private Label label1;
		private CheckBox checkMaj;
		private Label label4;
		private TextBox txtMajDesc;
		private Label label3;
		private TextBox txtMajNameKH;
		private Label label2;
		private TextBox txtMajName;
		private Label label5;
		private TextBox txtMajID;
		private Button btnDelete;
		private Button btnEdit;
		private Button btnNew;
		private Button btnLogOut;
		private Label label6;
		private Label label7;
		private TextBox txtDepID;
		private Label label8;
		private TextBox txtDepName;
		private Label label9;
		private TextBox txtFee;
	}
}