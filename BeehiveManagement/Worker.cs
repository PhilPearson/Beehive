using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagement
{
	class Worker : Bee
	{
		//constructor requires an array of jobs
		private string[] jobsICanDo;
		public Worker(string[] jobsICanDo, int weight)
			: base(weight) {
			this.jobsICanDo = jobsICanDo;
		}

		//variable for number of shifts worked, method to return number of shifts left
		private int shiftsToWork;
		private int shiftsWorked;
		public override int ShiftsLeft {
			get {
				return shiftsToWork - shiftsWorked;
			}
		}
		
		//variable to store current job, method to return current job
		private string currentJob = "";
		public string CurrentJob {
			get {
				return currentJob;
			}
		}

		//ask the bee to do a job over a length of time		
		public bool DoThisJob(string job, int numberOfShifts) {
			//currentJob is not empty so bee must already be busy
			if (!String.IsNullOrEmpty(currentJob))
				return false;

			//loop through the bees list of jobs and assign the job + number of shifts
			for(int i=0; i<jobsICanDo.Length; i++) {
				if(jobsICanDo[i] == job) {
					currentJob = job;
					this.shiftsToWork = numberOfShifts;
					shiftsWorked = 0;
					return true;
				}
			}
			//what just happened?
			return false;
		}

		//work a shift
		public bool WorkOneShift() {
			//currentJob is empty so nothing job
			if (String.IsNullOrEmpty(currentJob))
				return false;

			//increment shift
			shiftsWorked++;

			//if we have worked all our shifts then reset vars
			if (shiftsWorked > shiftsToWork) {
				shiftsWorked = 0;
				shiftsToWork = 0;
				currentJob = "";
				return true;
			} else {
				return false;
			}
		}
	}
}
