using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataJuggler.DocGen.Delegates
{

	#region UpdateProgress(int max, int currentValue, string statusText);
	/// <summary>
	/// This delegate is used to send progress back to the MainForm.
	/// </summary>
	/// <param name="max"></param>
	/// <param name="currentValue"></param>
	/// <param name="statusText"></param>
	public delegate void UpdateProgress(int max, int currentValue, string statusText);
	#endregion

}
