using System;
using Gtk;
using System.Runtime.Remoting.Messaging;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnGoButtonClicked (object sender, EventArgs e)
	{
		outputText.Markup = "<u>TESTING</u><b>TESTING</b>";
	}
}
