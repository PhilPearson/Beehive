namespace BeehiveManagement
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
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.shifts = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAssignJobToBee = new System.Windows.Forms.Button();
			this.workerBeeJob = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnWorkNextShift = new System.Windows.Forms.Button();
			this.report = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.shifts);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnAssignJobToBee);
			this.groupBox1.Controls.Add(this.workerBeeJob);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(302, 104);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Worke Bee Assignments";
			// 
			// shifts
			// 
			this.shifts.Location = new System.Drawing.Point(223, 37);
			this.shifts.Name = "shifts";
			this.shifts.Size = new System.Drawing.Size(62, 20);
			this.shifts.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(220, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Shifts";
			// 
			// btnAssignJobToBee
			// 
			this.btnAssignJobToBee.Location = new System.Drawing.Point(10, 65);
			this.btnAssignJobToBee.Name = "btnAssignJobToBee";
			this.btnAssignJobToBee.Size = new System.Drawing.Size(199, 23);
			this.btnAssignJobToBee.TabIndex = 2;
			this.btnAssignJobToBee.Text = "Assign this job to a bee";
			this.btnAssignJobToBee.UseVisualStyleBackColor = true;
			this.btnAssignJobToBee.Click += new System.EventHandler(this.btnAssignJobToBee_Click);
			// 
			// workerBeeJob
			// 
			this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.workerBeeJob.FormattingEnabled = true;
			this.workerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
			this.workerBeeJob.Location = new System.Drawing.Point(10, 37);
			this.workerBeeJob.Name = "workerBeeJob";
			this.workerBeeJob.Size = new System.Drawing.Size(199, 21);
			this.workerBeeJob.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Worker bee job";
			// 
			// btnWorkNextShift
			// 
			this.btnWorkNextShift.Location = new System.Drawing.Point(320, 24);
			this.btnWorkNextShift.Name = "btnWorkNextShift";
			this.btnWorkNextShift.Size = new System.Drawing.Size(71, 67);
			this.btnWorkNextShift.TabIndex = 1;
			this.btnWorkNextShift.Text = "Work the next shift";
			this.btnWorkNextShift.UseVisualStyleBackColor = true;
			this.btnWorkNextShift.Click += new System.EventHandler(this.btnWorkNextShift_Click);
			// 
			// report
			// 
			this.report.Location = new System.Drawing.Point(12, 123);
			this.report.Multiline = true;
			this.report.Name = "report";
			this.report.Size = new System.Drawing.Size(379, 189);
			this.report.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(406, 324);
			this.Controls.Add(this.report);
			this.Controls.Add(this.btnWorkNextShift);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Beehive Management System";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown shifts;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAssignJobToBee;
		private System.Windows.Forms.ComboBox workerBeeJob;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnWorkNextShift;
		private System.Windows.Forms.TextBox report;
	}
}

