
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.Alignment alignment2;
	
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.Label pokemonType;
	
	private global::Gtk.Entry entry1;
	
	private global::Gtk.Alignment alignment1;
	
	private global::Gtk.Button GoButton;
	
	private global::Gtk.Label outputText;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Homogeneous = true;
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 0.2F);
		this.alignment2.Name = "alignment2";
		// Container child alignment2.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		this.vbox1.BorderWidth = ((uint)(10));
		// Container child vbox1.Gtk.Box+BoxChild
		this.pokemonType = new global::Gtk.Label ();
		this.pokemonType.Name = "pokemonType";
		this.pokemonType.LabelProp = global::Mono.Unix.Catalog.GetString ("<i>Enter Pokemon Type:</i>");
		this.pokemonType.UseMarkup = true;
		this.vbox1.Add (this.pokemonType);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.pokemonType]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.entry1 = new global::Gtk.Entry ();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '●';
		this.vbox1.Add (this.entry1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.entry1]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		this.alignment2.Add (this.vbox1);
		this.hbox1.Add (this.alignment2);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.alignment2]));
		w4.Position = 0;
		w4.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 0.75F, 0.1F);
		this.alignment1.Name = "alignment1";
		// Container child alignment1.Gtk.Container+ContainerChild
		this.GoButton = new global::Gtk.Button ();
		this.GoButton.TooltipMarkup = "Press to get Effectiveness";
		this.GoButton.CanFocus = true;
		this.GoButton.Events = ((global::Gdk.EventMask)(768));
		this.GoButton.Name = "GoButton";
		this.GoButton.UseUnderline = true;
		this.GoButton.Label = global::Mono.Unix.Catalog.GetString ("Effectiveness!");
		this.alignment1.Add (this.GoButton);
		this.hbox1.Add (this.alignment1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.alignment1]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.outputText = new global::Gtk.Label ();
		this.outputText.Name = "outputText";
		this.outputText.LabelProp = global::Mono.Unix.Catalog.GetString ("2x Effectiveness:\n\n1/2x Effectiveness:\n\n0x Effectiveness:");
		this.outputText.UseMarkup = true;
		this.hbox1.Add (this.outputText);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.outputText]));
		w7.Position = 2;
		this.Add (this.hbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 570;
		this.DefaultHeight = 186;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.GoButton.Clicked += new global::System.EventHandler (this.OnGoButtonClicked);
	}
}