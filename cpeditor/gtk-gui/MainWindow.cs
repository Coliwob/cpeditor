
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action FileAction;

	private global::Gtk.Action EditAction;

	private global::Gtk.Action HelpAction;

	private global::Gtk.Action indexAction;

	private global::Gtk.Action cutAction;

	private global::Gtk.Action copyAction;

	private global::Gtk.Action pasteAction;

	private global::Gtk.Action deleteAction;

	private global::Gtk.Action newAction;

	private global::Gtk.Action openAction;

	private global::Gtk.Action saveAction;

	private global::Gtk.Action saveAsAction;

	private global::Gtk.Action quitAction;

	private global::Gtk.Action separtorAction;

	private global::Gtk.Action newAction1;

	private global::Gtk.Action openAction1;

	private global::Gtk.Action saveAction1;

	private global::Gtk.Action saveAsAction1;

	private global::Gtk.Action cutAction1;

	private global::Gtk.Action copyAction1;

	private global::Gtk.Action pasteAction1;

	private global::Gtk.Action boldAction;

	private global::Gtk.Action italicAction;

	private global::Gtk.Action underlineAction;

	private global::Gtk.Action justifyLeftAction;

	private global::Gtk.Action justifyCenterAction;

	private global::Gtk.Action justifyRightAction;

	private global::Gtk.Action justifyFillAction1;

	private global::Gtk.Action strikethroughAction;

	private global::Gtk.RadioAction propertiesAction;

	private global::Gtk.VBox vbox2;

	private global::Gtk.MenuBar menubar1;

	private global::Gtk.Fixed fixed1;

	private global::Gtk.Toolbar toolbar1;

	private global::Gtk.FontButton fontbutton3;

	private global::Gtk.HBox hbox5;

	private global::Gtk.Fixed fixed3;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView textview1;

	private global::Gtk.Statusbar statusbar2;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.FileAction = new global::Gtk.Action("FileAction", global::Mono.Unix.Catalog.GetString("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString("File");
		w1.Add(this.FileAction, null);
		this.EditAction = new global::Gtk.Action("EditAction", global::Mono.Unix.Catalog.GetString("Edit"), null, null);
		this.EditAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Edit");
		w1.Add(this.EditAction, null);
		this.HelpAction = new global::Gtk.Action("HelpAction", global::Mono.Unix.Catalog.GetString("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Help");
		w1.Add(this.HelpAction, null);
		this.indexAction = new global::Gtk.Action("indexAction", global::Mono.Unix.Catalog.GetString("About"), null, "gtk-index");
		this.indexAction.ShortLabel = global::Mono.Unix.Catalog.GetString("About");
		w1.Add(this.indexAction, null);
		this.cutAction = new global::Gtk.Action("cutAction", global::Mono.Unix.Catalog.GetString("Cut"), null, "gtk-cut");
		this.cutAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Cut");
		w1.Add(this.cutAction, null);
		this.copyAction = new global::Gtk.Action("copyAction", global::Mono.Unix.Catalog.GetString("Copy"), null, "gtk-copy");
		this.copyAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Copy");
		w1.Add(this.copyAction, null);
		this.pasteAction = new global::Gtk.Action("pasteAction", global::Mono.Unix.Catalog.GetString("Paste"), null, "gtk-paste");
		this.pasteAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Paste");
		w1.Add(this.pasteAction, null);
		this.deleteAction = new global::Gtk.Action("deleteAction", global::Mono.Unix.Catalog.GetString("Delete"), null, "gtk-delete");
		this.deleteAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Delete");
		w1.Add(this.deleteAction, null);
		this.newAction = new global::Gtk.Action("newAction", global::Mono.Unix.Catalog.GetString("New"), null, "gtk-new");
		this.newAction.ShortLabel = global::Mono.Unix.Catalog.GetString("New");
		w1.Add(this.newAction, null);
		this.openAction = new global::Gtk.Action("openAction", global::Mono.Unix.Catalog.GetString("Open"), null, "gtk-open");
		this.openAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Open");
		w1.Add(this.openAction, null);
		this.saveAction = new global::Gtk.Action("saveAction", global::Mono.Unix.Catalog.GetString("Save"), null, "gtk-save");
		this.saveAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Save");
		w1.Add(this.saveAction, null);
		this.saveAsAction = new global::Gtk.Action("saveAsAction", global::Mono.Unix.Catalog.GetString("Save As"), null, "gtk-save-as");
		this.saveAsAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Save As");
		w1.Add(this.saveAsAction, null);
		this.quitAction = new global::Gtk.Action("quitAction", global::Mono.Unix.Catalog.GetString("Quit"), null, "gtk-quit");
		this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Quit");
		w1.Add(this.quitAction, null);
		this.separtorAction = new global::Gtk.Action("separtorAction", global::Mono.Unix.Catalog.GetString("separtor"), null, null);
		this.separtorAction.ShortLabel = global::Mono.Unix.Catalog.GetString("separtor");
		w1.Add(this.separtorAction, null);
		this.newAction1 = new global::Gtk.Action("newAction1", global::Mono.Unix.Catalog.GetString("New"), null, "gtk-new");
		this.newAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("New");
		w1.Add(this.newAction1, null);
		this.openAction1 = new global::Gtk.Action("openAction1", null, null, "gtk-open");
		w1.Add(this.openAction1, null);
		this.saveAction1 = new global::Gtk.Action("saveAction1", null, null, "gtk-save");
		w1.Add(this.saveAction1, null);
		this.saveAsAction1 = new global::Gtk.Action("saveAsAction1", null, null, "gtk-save-as");
		w1.Add(this.saveAsAction1, null);
		this.cutAction1 = new global::Gtk.Action("cutAction1", null, null, "gtk-cut");
		w1.Add(this.cutAction1, null);
		this.copyAction1 = new global::Gtk.Action("copyAction1", null, null, "gtk-copy");
		w1.Add(this.copyAction1, null);
		this.pasteAction1 = new global::Gtk.Action("pasteAction1", null, null, "gtk-paste");
		w1.Add(this.pasteAction1, null);
		this.boldAction = new global::Gtk.Action("boldAction", null, null, "gtk-bold");
		w1.Add(this.boldAction, null);
		this.italicAction = new global::Gtk.Action("italicAction", null, null, "gtk-italic");
		w1.Add(this.italicAction, null);
		this.underlineAction = new global::Gtk.Action("underlineAction", null, null, "gtk-underline");
		w1.Add(this.underlineAction, null);
		this.justifyLeftAction = new global::Gtk.Action("justifyLeftAction", null, null, "gtk-justify-left");
		w1.Add(this.justifyLeftAction, null);
		this.justifyCenterAction = new global::Gtk.Action("justifyCenterAction", null, null, "gtk-justify-center");
		w1.Add(this.justifyCenterAction, null);
		this.justifyRightAction = new global::Gtk.Action("justifyRightAction", null, null, "gtk-justify-right");
		w1.Add(this.justifyRightAction, null);
		this.justifyFillAction1 = new global::Gtk.Action("justifyFillAction1", null, null, "gtk-justify-fill");
		w1.Add(this.justifyFillAction1, null);
		this.strikethroughAction = new global::Gtk.Action("strikethroughAction", null, null, "gtk-strikethrough");
		w1.Add(this.strikethroughAction, null);
		this.propertiesAction = new global::Gtk.RadioAction("propertiesAction", null, null, "gtk-properties", 0);
		this.propertiesAction.Group = new global::GLib.SList(global::System.IntPtr.Zero);
		w1.Add(this.propertiesAction, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 1;
		// Container child vbox2.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString(@"<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='newAction' action='newAction'/><separator/><menuitem name='openAction' action='openAction'/><menuitem name='saveAction' action='saveAction'/><menuitem name='saveAsAction' action='saveAsAction'/><separator/><menuitem name='quitAction' action='quitAction'/></menu><menu name='EditAction' action='EditAction'><menuitem name='cutAction' action='cutAction'/><menuitem name='copyAction' action='copyAction'/><menuitem name='pasteAction' action='pasteAction'/><separator/><menuitem name='deleteAction' action='deleteAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='indexAction' action='indexAction'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox2.Add(this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.HeightRequest = 42;
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.UIManager.AddUiFromString(@"<ui><toolbar name='toolbar1'><toolitem name='newAction1' action='newAction1'/><separator/><toolitem name='openAction1' action='openAction1'/><toolitem name='saveAction1' action='saveAction1'/><toolitem name='saveAsAction1' action='saveAsAction1'/><separator/><toolitem name='cutAction1' action='cutAction1'/><toolitem name='copyAction1' action='copyAction1'/><toolitem name='pasteAction1' action='pasteAction1'/><separator/><toolitem name='boldAction' action='boldAction'/><toolitem name='italicAction' action='italicAction'/><toolitem name='underlineAction' action='underlineAction'/><toolitem name='strikethroughAction' action='strikethroughAction'/><separator/><toolitem name='justifyLeftAction' action='justifyLeftAction'/><toolitem name='justifyCenterAction' action='justifyCenterAction'/><toolitem name='justifyRightAction' action='justifyRightAction'/><toolitem name='justifyFillAction1' action='justifyFillAction1'/><separator/></toolbar></ui>");
		this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
		this.toolbar1.WidthRequest = 541;
		this.toolbar1.Name = "toolbar1";
		this.toolbar1.ShowArrow = false;
		this.toolbar1.ToolbarStyle = ((global::Gtk.ToolbarStyle)(3));
		this.toolbar1.IconSize = ((global::Gtk.IconSize)(3));
		this.fixed1.Add(this.toolbar1);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.toolbar1]));
		w3.X = 4;
		w3.Y = 3;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.fontbutton3 = new global::Gtk.FontButton();
		this.fontbutton3.CanFocus = true;
		this.fontbutton3.Name = "fontbutton3";
		this.fixed1.Add(this.fontbutton3);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.fontbutton3]));
		w4.X = 552;
		w4.Y = 3;
		this.vbox2.Add(this.fixed1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.fixed1]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.fixed3 = new global::Gtk.Fixed();
		this.fixed3.Name = "fixed3";
		this.fixed3.HasWindow = false;
		this.hbox5.Add(this.fixed3);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.fixed3]));
		w6.Position = 1;
		this.vbox2.Add(this.hbox5);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox5]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView();
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.textview1.WrapMode = ((global::Gtk.WrapMode)(2));
		this.GtkScrolledWindow.Add(this.textview1);
		this.vbox2.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow]));
		w9.Position = 3;
		// Container child vbox2.Gtk.Box+BoxChild
		this.statusbar2 = new global::Gtk.Statusbar();
		this.statusbar2.Name = "statusbar2";
		this.statusbar2.Spacing = 6;
		this.vbox2.Add(this.statusbar2);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.statusbar2]));
		w10.Position = 4;
		w10.Expand = false;
		w10.Fill = false;
		this.Add(this.vbox2);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 1129;
		this.DefaultHeight = 602;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.newAction.Activated += new global::System.EventHandler(this.menu_file_new_activate);
		this.quitAction.Activated += new global::System.EventHandler(this.menu_file_quit_activate);
		this.cutAction1.Activated += new global::System.EventHandler(this.Action_Cut);
		this.copyAction1.Activated += new global::System.EventHandler(this.Action_Copy);
		this.pasteAction1.Activated += new global::System.EventHandler(this.Action_Paste);
		this.boldAction.Activated += new global::System.EventHandler(this.Action_Bold);
		this.italicAction.Activated += new global::System.EventHandler(this.Action_Italic);
		this.underlineAction.Activated += new global::System.EventHandler(this.Action_Underline);
		this.justifyLeftAction.Activated += new global::System.EventHandler(this.Action_JustifyLeft);
		this.justifyCenterAction.Activated += new global::System.EventHandler(this.Action_JustifyCenter);
		this.justifyRightAction.Activated += new global::System.EventHandler(this.Action_JustifyRight);
		this.justifyFillAction1.Activated += new global::System.EventHandler(this.Action_JustifyFill);
		this.strikethroughAction.Activated += new global::System.EventHandler(this.Action_Strikethrough);
		this.fontbutton3.FontSet += new global::System.EventHandler(this.Action_SetFont);
	}
}
