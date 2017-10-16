using System.Collections.Generic;
using System;
using Pango;
using Gtk;

public partial class MainWindow : Gtk.Window
{
	public static TextView selectedTextView;
	public static Clipboard _clipboard;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
		selectedTextView = textview1;
		CreateTags(selectedTextView.Buffer);

		_clipboard = Gtk.Clipboard.Get(Gdk.Atom.Intern("CLIPBOARD", false));
	}

	protected void CreateTags(TextBuffer buffer)
	{
		TextTag tag_bold = new TextTag("bold");
		tag_bold.Weight = Pango.Weight.Bold;
		buffer.TagTable.Add(tag_bold);

		TextTag tag_italic = new TextTag("italic");
		tag_italic.Style = Pango.Style.Italic;
		buffer.TagTable.Add(tag_italic);

		TextTag tag_underline = new TextTag("underline");
		tag_underline.Underline = Underline.Single;
		buffer.TagTable.Add(tag_underline);

		TextTag tag_strikethrough = new TextTag("strikethrough");
		tag_strikethrough.Strikethrough = true;
		buffer.TagTable.Add(tag_strikethrough);

		TextTag tag_jjustify = new TextTag("jjustify");
		tag_jjustify.Justification = Justification.Fill;
		buffer.TagTable.Add(tag_jjustify);

		TextTag tag_jcenter = new TextTag("jcenter");
		tag_jcenter.Justification = Justification.Center;
		buffer.TagTable.Add(tag_jcenter);

		TextTag tag_jleft = new TextTag("jleft");
		tag_jleft.Justification = Justification.Left;
		buffer.TagTable.Add(tag_jleft);

		TextTag tag_jright = new TextTag("jright");
		tag_jright.Justification = Justification.Right;
		buffer.TagTable.Add(tag_jright);

	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected void menu_file_new_activate(object sender, EventArgs e)
	{
		selectedTextView.Buffer.Clear();
	}
	protected void menu_file_quit_activate(object sender, EventArgs e)
	{
		Application.Quit();
	}

	protected bool CheckForTag(TextBuffer buffer, List<string> tagstrings, TextIter A, TextIter B)
	{

		foreach (string tagstring in tagstrings)
		{
			while (A.Compare(B) < 0)
			{
				Console.WriteLine(A.Compare(B));
				foreach (TextTag t in A.Tags)
				{
					if (t.Name == tagstring) return true;
				}
				A.ForwardChar();
			}
		}
		return false;
	}

	protected void Action_Bold(object sender, EventArgs e)
	{
		TextIter A, B;
		if (selectedTextView.Buffer.GetSelectionBounds(out A, out B))
		{
			if (CheckForTag(selectedTextView.Buffer, new List<string> { "bold" }, A, B))
			{
				selectedTextView.Buffer.RemoveTag("bold", A, B);
			}
			else
			{
				selectedTextView.Buffer.ApplyTag("bold", A, B);
			}
		}
	}
	protected void Action_Italic(object sender, EventArgs e)
	{
		TextIter A, B;
		if (selectedTextView.Buffer.GetSelectionBounds(out A, out B))
		{
			if (CheckForTag(selectedTextView.Buffer, new List<string> { "italic" }, A, B))
			{
				selectedTextView.Buffer.RemoveTag("italic", A, B);
			}
			else
			{
				selectedTextView.Buffer.ApplyTag("italic", A, B);
			}
		}
	}
	protected void Action_Underline(object sender, EventArgs e)
	{
		TextIter A, B;
		if (selectedTextView.Buffer.GetSelectionBounds(out A, out B))
		{
			if (CheckForTag(selectedTextView.Buffer, new List<string> { "underline" }, A, B))
			{
				selectedTextView.Buffer.RemoveTag("underline", A, B);
			}
			else
			{
				selectedTextView.Buffer.ApplyTag("underline", A, B);
			}
		}	}
	protected void Action_Strikethrough(object sender, EventArgs e)
	{
		TextIter A, B;
		if (selectedTextView.Buffer.GetSelectionBounds(out A, out B))
		{
			if (CheckForTag(selectedTextView.Buffer, new List<string> { "strikethrough" }, A, B))
			{
				selectedTextView.Buffer.RemoveTag("strikethrough", A, B);
			}
			else
			{
				selectedTextView.Buffer.ApplyTag("strikethrough", A, B);
			}
		}	}

	protected void Action_Cut(object sender, EventArgs e)
	{
		selectedTextView.Buffer.CutClipboard(_clipboard, true);
	}
	protected void Action_Copy(object sender, EventArgs e)
	{
		selectedTextView.Buffer.CopyClipboard(_clipboard);
	}
	protected void Action_Paste(object sender, EventArgs e)
	{
		selectedTextView.Buffer.PasteClipboard(_clipboard);
	}

	protected void Text_ApplyJustification(string tag, TextIter A, TextIter B)
	{
		selectedTextView.Buffer.RemoveTag("jcenter", A, B);
		selectedTextView.Buffer.RemoveTag("jleft", A, B);
		selectedTextView.Buffer.RemoveTag("jright", A, B);
		selectedTextView.Buffer.RemoveTag("jjustify", A, B);
		selectedTextView.Buffer.ApplyTag(tag, A, B);
	}
	protected void Text_GetLines(TextBuffer buffer, out TextIter A, out TextIter B)
	{
		TextIter C, D;

		if (selectedTextView.Buffer.GetSelectionBounds(out C, out D))
		{
			A = selectedTextView.Buffer.GetIterAtLine(C.Line);
			B = selectedTextView.Buffer.GetIterAtLine(D.Line);
			while (!B.EndsLine())
			{
				B.ForwardChar();
			}
		}
		else
		{
			int cursor = selectedTextView.Buffer.CursorPosition;
			int line = selectedTextView.Buffer.GetIterAtOffset(cursor).Line;
			B = A = selectedTextView.Buffer.GetIterAtLine(line);
			while (!B.EndsLine())
			{
				B.ForwardChar();
			}
		}
	}
	protected void Action_JustifyLeft(object sender, EventArgs e)
	{
		TextIter A, B;
		Text_GetLines(selectedTextView.Buffer, out A, out B);
		Text_ApplyJustification("jleft", A, B);
	}
	protected void Action_JustifyCenter(object sender, EventArgs e)
	{

		TextIter A, B;
		Text_GetLines(selectedTextView.Buffer, out A, out B);
		Text_ApplyJustification("jcenter", A, B);

	}
	protected void Action_JustifyRight(object sender, EventArgs e)
	{
		TextIter A, B;
		Text_GetLines(selectedTextView.Buffer, out A, out B);
		Text_ApplyJustification("jright", A, B);
	}
	protected void Action_JustifyFill(object sender, EventArgs e)
	{
		TextIter A, B;
		Text_GetLines(selectedTextView.Buffer, out A, out B);
		Text_ApplyJustification("jjustify", A, B);
	}

	protected void Action_SetFont(object sender, EventArgs e)
	{
		

		//Create a tag, and give it a searchable name.
		FontButton b = sender as FontButton;
		TextTag font = new TextTag("FONT" + b.FontName);
		font.Font = b.FontName;
		selectedTextView.Buffer.TagTable.Add(font);

		Console.WriteLine("FONT: " + b.FontName);
		TextIter A, B;
		if (selectedTextView.Buffer.GetSelectionBounds(out A, out B))
		{
			selectedTextView.Buffer.ApplyTag("FONT" + b.FontName, A, B);
		}


	}


}

