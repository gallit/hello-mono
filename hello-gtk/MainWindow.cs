using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

public partial class MainWindow: Gtk.Window
{
	//Builder builder;

	[UI] Gtk.Button button1;
	[UI] Gtk.Label label1;

	int clickedTimes;

	public static MainWindow Create ()
	{		
		var data = @"<?xml version=""1.0"" encoding=""UTF-8""?>
<interface>
	<requires lib=""gtk+"" version=""3.0"" />
	<object class=""GtkWindow"" id=""window1"">
		<property name=""can_focus"">False</property>
		<property name=""default-height"">150</property>
		<property name=""default-width"">500</property>
		<child>
			<object class=""GtkBox"" id=""box1"">
				<property name=""height"">150</property>
				<property name=""visible"">True</property>
				<property name=""can_focus"">False</property>
				<property name=""orientation"">vertical</property>
				<child>
					<object class=""GtkLabel"" id=""label1"">
						<property name=""visible"">True</property>
						<property name=""can_focus"">False</property>
						<property name=""yalign"">0.47999998927116394</property>
						<property name=""label"" translatable=""yes"">Hello World! This button has been clicked 0 time(s).</property>
					</object>
					<packing>
						<property name=""expand"">False</property>
						<property name=""fill"">True</property>
						<property name=""position"">0</property>
					</packing>
				</child>
				<child>
					<object class=""GtkButton"" id=""button1"">
						<property name=""label"" translatable=""yes"">Click me!</property>
						<property name=""visible"">True</property>
						<property name=""can_focus"">False</property>
						<property name=""receives_default"">True</property>
					</object>
					<packing>
						<property name=""expand"">False</property>
						<property name=""fill"">True</property>
						<property name=""position"">1</property>
					</packing>
				</child>
			</object>
		</child>
	</object>
</interface>";
		
		var builder = new Builder ();
		builder.AddFromString (data);
		//Builder builder = new Builder (null, "hellogtk.interfaces.MainWindow.glade", null);
		return new MainWindow (builder, builder.GetObject ("window1").Handle);
	}

	protected MainWindow (Builder builder, IntPtr handle) : base (handle)
	{
		//this.builder = builder;

		builder.Autoconnect (this);
		DeleteEvent += OnDeleteEvent;

		button1.Clicked += onButtonClick;
	}

	protected void onButtonClick (object sender, EventArgs a)
	{
		clickedTimes++;
		label1.Text = string.Format ("Hello World! This button has been clicked {0} time(s).", clickedTimes);
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
