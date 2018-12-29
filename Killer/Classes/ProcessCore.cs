using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Killer.Classes
{
	public class ProcessCore
	{
		/// <summary>
		/// Get all process in execution
		/// </summary>
		/// <returns>List<ProcessEntitie></returns>
		public List<ProcessEntitie> GetRunningProcess()
		{
			try
			{
				List<ProcessEntitie> processList = new List<ProcessEntitie>();

				Process[] processArray = Process.GetProcesses();

				foreach (Process p in processArray)
				{
					processList.Add(new ProcessEntitie(p.Id, p.ProcessName));
				}

				return processList;
			}
			catch (Exception ex)
			{
				Console.Write(ex.Message);
				return null;
			}
		}


	}
}
