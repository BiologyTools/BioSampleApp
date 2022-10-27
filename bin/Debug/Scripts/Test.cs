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
		Bio.BioImage.OpenOME("F://TESTIMAGES//Plate1-Blue-A-12-Scene-3-P3-F2-03.czi");
		App.Channels[0].Min = 50; 
		App.Channels[0].Max = 1915;
		App.Channels[1].Min = 86;
		App.Channels[1].Max = 1740;
		App.Channels[2].Min = 537;
		App.Channels[2].Max = 2122;
		return "OK";
	}
}