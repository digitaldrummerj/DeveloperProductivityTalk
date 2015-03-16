using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace WindowsService1
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			ServiceBase[] ServicesToRun;
			ServicesToRun = new ServiceBase[] 
            { 
                new Service1() 
            };

			if (Environment.UserInteractive)
			{
				Console.WriteLine("Service Started");
				Console.WriteLine("Press Enter to Exit....");
				Console.ReadLine();


			}
			else
			{
				ServiceBase.Run(ServicesToRun);	
			}
			
		}
	}
}
