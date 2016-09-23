/*
 * Created by SharpDevelop.
 * User: estr_iti-gn_a_ramsai
 * Date: 23.09.2016
 * Time: 11:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Import_Tool
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn E164;
		private System.Windows.Forms.DataGridViewComboBoxColumn Berechtigung;
		private System.Windows.Forms.DataGridViewComboBoxColumn Gerätetyp;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Passwort;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Chese;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn Benutzername;
		private System.Windows.Forms.DataGridViewTextBoxColumn Anzeigename;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Geschlecht;
		private System.Windows.Forms.DataGridViewCheckBoxColumn OSV;
		private System.Windows.Forms.DataGridViewCheckBoxColumn DLS;
		private System.Windows.Forms.DataGridViewCheckBoxColumn UC;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Xpressions;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.E164 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Berechtigung = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Gerätetyp = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Passwort = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Chese = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Benutzername = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Anzeigename = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Geschlecht = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.OSV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.DLS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.UC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Xpressions = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.E164,
			this.Berechtigung,
			this.Gerätetyp,
			this.Passwort,
			this.Chese,
			this.Email,
			this.Benutzername,
			this.Anzeigename,
			this.Geschlecht,
			this.OSV,
			this.DLS,
			this.UC,
			this.Xpressions});
			this.dataGridView1.Location = new System.Drawing.Point(12, 230);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1197, 333);
			this.dataGridView1.TabIndex = 0;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(12, 75);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(628, 126);
			this.dataGridView2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 204);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Teilnehmerdaten";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Standort der Einrichtung";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(653, 114);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(100, 84);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "UC";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(16, 47);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(82, 24);
			this.radioButton2.TabIndex = 9;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "SSO Import";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(16, 17);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(82, 24);
			this.radioButton1.TabIndex = 8;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "User Import";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(785, 145);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Imports erstellen";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(150, 46);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(162, 20);
			this.textBox1.TabIndex = 12;
			// 
			// E164
			// 
			this.E164.HeaderText = "E164";
			this.E164.Name = "E164";
			// 
			// Berechtigung
			// 
			this.Berechtigung.HeaderText = "Berechtigung";
			this.Berechtigung.Name = "Berechtigung";
			this.Berechtigung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Berechtigung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// Gerätetyp
			// 
			this.Gerätetyp.HeaderText = "Gerätetyp";
			this.Gerätetyp.Name = "Gerätetyp";
			this.Gerätetyp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Gerätetyp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// Passwort
			// 
			this.Passwort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.Passwort.HeaderText = "Std PW";
			this.Passwort.Name = "Passwort";
			this.Passwort.Width = 48;
			// 
			// Chese
			// 
			this.Chese.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.Chese.HeaderText = "Chese";
			this.Chese.Name = "Chese";
			this.Chese.Width = 41;
			// 
			// Email
			// 
			this.Email.HeaderText = "E-Mail";
			this.Email.Name = "Email";
			// 
			// Benutzername
			// 
			this.Benutzername.HeaderText = "Benutzername";
			this.Benutzername.Name = "Benutzername";
			// 
			// Anzeigename
			// 
			this.Anzeigename.HeaderText = "Anzeigename (Name, Vorname)";
			this.Anzeigename.Name = "Anzeigename";
			// 
			// Geschlecht
			// 
			this.Geschlecht.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.Geschlecht.HeaderText = "männlich";
			this.Geschlecht.Name = "Geschlecht";
			this.Geschlecht.Width = 53;
			// 
			// OSV
			// 
			this.OSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.OSV.HeaderText = "OSV";
			this.OSV.Name = "OSV";
			this.OSV.Width = 33;
			// 
			// DLS
			// 
			this.DLS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.DLS.HeaderText = "DLS";
			this.DLS.Name = "DLS";
			this.DLS.Width = 32;
			// 
			// UC
			// 
			this.UC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.UC.HeaderText = "UC";
			this.UC.Name = "UC";
			this.UC.Width = 26;
			// 
			// Xpressions
			// 
			this.Xpressions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.Xpressions.HeaderText = "Xpressions";
			this.Xpressions.Name = "Xpressions";
			this.Xpressions.Width = 62;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1233, 579);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MainForm";
			this.Text = "Import Tool";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
