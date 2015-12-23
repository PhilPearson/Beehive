using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeehiveManagement
{
	public partial class Form1 : Form
	{
		//declare a global queen variable, will assign the queen object on init
		Queen queen;

		public Form1() {
			InitializeComponent();
			//create an array to store workers
			Worker[] workers = new Worker[4];

			//create the workers, assigning each to a job role
			workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 175);
			workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" },114);
			workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" },149);
			workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing",
													"Egg care", "Baby bee tutoring",
													"Hive maintenance", "Sting patrol"},155);
			
			//assign the queen object and pass in the array of workers
			queen = new Queen(workers, 175);
		}

		private void btnAssignJobToBee_Click(object sender, EventArgs e) {
			if(queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false) {
				MessageBox.Show("No workers are available to do the job '" + workerBeeJob.Text + "'", "The queen bee says...");
			} else {
				MessageBox.Show("The job '" + workerBeeJob.Text + "' will be done in "+shifts.Value + " shifts", "The queen bee says...");
			}
		}

		private void btnWorkNextShift_Click(object sender, EventArgs e) {
			report.Text = queen.WorkTheNextShift();
		}
	}
}
