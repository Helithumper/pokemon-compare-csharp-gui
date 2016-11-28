using System;
using Gtk;

namespace pokemoncomparecsharpgui
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("STARTED!");
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}
