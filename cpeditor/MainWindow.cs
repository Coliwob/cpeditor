using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected void menu_file_new_activate(object sender, EventArgs e)
	{
		//do nothing right now
	}

	protected void menu_file_quit_activate(object sender, EventArgs e)
	{
		Application.Quit();
	}


}
