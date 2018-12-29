using Killer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Killer
{
	public partial class frmMain : Form
	{
		private ProcessCore processCore;
		public frmMain()
		{
			InitializeComponent();
			this.processCore = new ProcessCore();
		}

		private void btnScan_Click(object sender, EventArgs e)
		{
			listWindowsProcess.Items.Clear();
			List<ProcessEntitie> processEntitieList = processCore.GetRunningProcess();
			foreach (ProcessEntitie pe in processEntitieList) {
				listWindowsProcess.Items.Add(String.Format("{0}-{1}", pe.Id, pe.Name));
			}
		}
	}
}
