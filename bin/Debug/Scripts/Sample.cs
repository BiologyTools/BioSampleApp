//css_reference Bio.dll;

using System;
using System.Windows.Forms;
using System.Drawing;
using Bio;
using System.Threading;

public class Loader
{
	public string Load()
	{
		do
		{
			Bio.Scripting.State s = Bio.Scripting.GetState();
			if (s != null)
			{
				if (!s.processed)
				{
					
					s.processed = true;
				}
			}
		} while (true);
		return "OK";
	}
}