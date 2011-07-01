//
// In order to convert some functionality to Visual C#, the Java Language Conversion Assistant
// creates "support classes" that duplicate the original functionality.  
//
// Support classes replicate the functionality of the original code, but in some cases they are 
// substantially different architecturally. Although every effort is made to preserve the 
// original architecture of the application in the converted project, the user should be aware that 
// the primary goal of these support classes is to replicate functionality, and that at times 
// the architecture of the resulting solution may differ somewhat.
//

using System;

/// <summary>
/// Contains conversion support elements such as classes, interfaces and static methods.
/// </summary>
public class SupportClass
{
	/// <summary>
	/// Recieves a form and an integer value representing the operation to perform when the closing 
	/// event is fired.
	/// </summary>
	/// <param name="form">The form that fire the event.</param>
	/// <param name="operation">The operation to do while the form is closing.</param>
	public static void CloseOperation(System.Windows.Forms.Form form, int operation)
	{
		switch (operation)
		{
			case 0:
				break;
			case 1:
				form.Hide();
				break;
			case 2:
				form.Dispose();
				break;
			case 3:
				form.Dispose();
				System.Windows.Forms.Application.Exit();
				break;
		}
	}


	/*******************************/
	/// <summary>
	/// Class used to store and retrieve an object command specified as a String.
	/// </summary>
	public class CommandManager
	{
		/// <summary>
		/// Private Hashtable used to store objects and their commands.
		/// </summary>
		private static System.Collections.Hashtable Commands = new System.Collections.Hashtable();

		/// <summary>
		/// Sets a command to the specified object.
		/// </summary>
		/// <param name="obj">The object that has the command.</param>
		/// <param name="cmd">The command for the object.</param>
		public static void SetCommand(System.Object obj, System.String cmd)
		{
			if (obj != null)
			{
				if (Commands.Contains(obj))
					Commands[obj] = cmd;
				else
					Commands.Add(obj, cmd);
			}
		}

		/// <summary>
		/// Gets a command associated with an object.
		/// </summary>
		/// <param name="obj">The object whose command is going to be retrieved.</param>
		/// <returns>The command of the specified object.</returns>
		public static System.String GetCommand(System.Object obj)
		{
			System.String result = "";
			if (obj != null)
				result = System.Convert.ToString(Commands[obj]);
			return result;
		}



		/// <summary>
		/// Checks if the Control contains a command, if it does not it sets the default
		/// </summary>
		/// <param name="button">The control whose command will be checked</param>
		public static void CheckCommand(System.Windows.Forms.ButtonBase button)
		{
			if (button != null)
			{
				if (GetCommand(button).Equals(""))
					SetCommand(button, button.Text);
			}
		}

		/// <summary>
		/// Checks if the Control contains a command, if it does not it sets the default
		/// </summary>
		/// <param name="button">The control whose command will be checked</param>
		public static void CheckCommand(System.Windows.Forms.MenuItem menuItem)
		{
			if (menuItem != null)
			{
				if (GetCommand(menuItem).Equals(""))
					SetCommand(menuItem, menuItem.Text);
			}
		}

		/// <summary>
		/// Checks if the Control contains a command, if it does not it sets the default
		/// </summary>
		/// <param name="button">The control whose command will be checked</param>
		public static void CheckCommand(System.Windows.Forms.ComboBox comboBox)
		{
			if (comboBox != null)
			{
				if (GetCommand(comboBox).Equals(""))
					SetCommand(comboBox,"comboBoxChanged");
			}
		}

	}
	/*******************************/
/// <summary>
/// Contains methods to construct customized Buttons
/// </summary>
public class ButtonSupport
{
	/// <summary>
	/// Creates a popup style Button with an specific text.	
	/// </summary>
	/// <param name="label">The text associated with the Button</param>
	/// <returns>The new Button</returns>
	public static System.Windows.Forms.Button CreateButton(System.String label)
	{			
		System.Windows.Forms.Button tempButton = new System.Windows.Forms.Button();
		tempButton.Text = label;
		tempButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		return tempButton;
	}

	/// <summary>
	/// Sets the an specific text for the Button
	/// </summary>
	/// <param name="Button">The button to be set</param>
	/// <param name="label">The text associated with the Button</param>
	public static void SetButton(System.Windows.Forms.ButtonBase Button, System.String label)
	{
		Button.Text = label;
		Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
	}

	/// <summary>
	/// Creates a Button with an specific text and style.
	/// </summary>
	/// <param name="label">The text associated with the Button</param>
	/// <param name="style">The style of the Button</param>
	/// <returns>The new Button</returns>
	public static System.Windows.Forms.Button CreateButton(System.String label, int style)
	{
		System.Windows.Forms.Button tempButton = new System.Windows.Forms.Button();
		tempButton.Text = label;
		setStyle(tempButton,style);
		return tempButton;
	}

	/// <summary>
	/// Sets the specific Text and Style for the Button
	/// </summary>
	/// <param name="Button">The button to be set</param>
	/// <param name="label">The text associated with the Button</param>
	/// <param name="style">The style of the Button</param>
	public static void SetButton(System.Windows.Forms.ButtonBase Button, System.String label, int style)
	{
		Button.Text = label;
		setStyle(Button,style);
	}

	/// <summary>
	/// Creates a standard style Button that contains an specific text and/or image
	/// </summary>
	/// <param name="control">The control to be contained analized to get the text and/or image for the Button</param>
	/// <returns>The new Button</returns>
	public static System.Windows.Forms.Button CreateButton(System.Windows.Forms.Control control)
	{
		System.Windows.Forms.Button tempButton = new System.Windows.Forms.Button();
		if(control.GetType().FullName == "System.Windows.Forms.Label")
		{
			tempButton.Image = ((System.Windows.Forms.Label)control).Image;
			tempButton.Text = ((System.Windows.Forms.Label)control).Text;
			tempButton.ImageAlign = ((System.Windows.Forms.Label)control).ImageAlign;
			tempButton.TextAlign = ((System.Windows.Forms.Label)control).TextAlign;
		}
		else
		{
			if(control.GetType().FullName == "System.Windows.Forms.PictureBox")//Tentative to see maps of UIGraphic
			{
				tempButton.Image = ((System.Windows.Forms.PictureBox)control).Image;
				tempButton.ImageAlign = ((System.Windows.Forms.Label)control).ImageAlign;
			}else
				tempButton.Text = control.Text;
		}
		tempButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
		return tempButton;
	}

	/// <summary>
	/// Sets an specific text and/or image to the Button
	/// </summary>
	/// <param name="Button">The button to be set</param>
	/// <param name="control">The control to be contained analized to get the text and/or image for the Button</param>
	public static void SetButton(System.Windows.Forms.ButtonBase Button,System.Windows.Forms.Control control)
	{
		if(control.GetType().FullName == "System.Windows.Forms.Label")
		{
			Button.Image = ((System.Windows.Forms.Label)control).Image;
			Button.Text = ((System.Windows.Forms.Label)control).Text;
			Button.ImageAlign = ((System.Windows.Forms.Label)control).ImageAlign;
			Button.TextAlign = ((System.Windows.Forms.Label)control).TextAlign;
		}
		else
		{
			if(control.GetType().FullName == "System.Windows.Forms.PictureBox")//Tentative to see maps of UIGraphic
			{
				Button.Image = ((System.Windows.Forms.PictureBox)control).Image;
				Button.ImageAlign = ((System.Windows.Forms.Label)control).ImageAlign;
			}
			else
				Button.Text = control.Text;
		}
		Button.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
	}

	/// <summary>
	/// Creates a Button with an specific control and style
	/// </summary>
	/// <param name="control">The control to be contained by the button</param>
	/// <param name="style">The style of the button</param>
	/// <returns>The new Button</returns>
	public static System.Windows.Forms.Button CreateButton(System.Windows.Forms.Control control, int style)
	{
		System.Windows.Forms.Button tempButton = CreateButton(control);
		setStyle(tempButton,style);
		return tempButton;
	}

	/// <summary>
	/// Sets an specific text and/or image to the Button
	/// </summary>
	/// <param name="Button">The button to be set</param>
	/// <param name="control">The control to be contained by the button</param>
	/// <param name="style">The style of the button</param>
	public static void SetButton(System.Windows.Forms.ButtonBase Button,System.Windows.Forms.Control control,int style)
	{
		SetButton(Button,control);
		setStyle(Button,style);
	}

	/// <summary>
	/// Sets the style of the Button
	/// </summary>
	/// <param name="Button">The Button that will change its style</param>
	/// <param name="style">The new style of the Button</param>
	/// <remarks> 
	/// If style is 0 then sets a popup style to the Button, otherwise sets a standard style to the Button.
	/// </remarks>
	public static void setStyle(System.Windows.Forms.ButtonBase Button, int style)
	{
		if (  (style == 0 ) || (style ==  67108864) || (style ==  33554432) ) 
			Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		else if ( (style == 2097152) || (style == 1048576) ||  (style == 16777216 ) )
				Button.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
		else 
			throw new System.ArgumentException("illegal style: " + style);		
	}

	/// <summary>
	/// Selects the Button
	/// </summary>
	/// <param name="Button">The Button that will change its style</param>
	/// <param name="select">It determines if the button woll be selected</param>
	/// <remarks> 
	/// If select is true thebutton will be selected, otherwise not.
	/// </remarks>
	public static void setSelected(System.Windows.Forms.ButtonBase Button, bool select)
	{
		if (select)
			Button.Select();
	}

	/// <summary>
	/// Receives a Button instance and sets the Text and Image properties.
	/// </summary>
	/// <param name="buttonInstance">Button instance to be set.</param>
	/// <param name="buttonText">Value to be set to Text.</param>
	/// <param name="icon">Value to be set to Image.</param>
	public static void SetStandardButton (System.Windows.Forms.ButtonBase buttonInstance, System.String buttonText , System.Drawing.Image icon )
	{
		buttonInstance.Text = buttonText;
		buttonInstance.Image = icon;
	}

	/// <summary>
	/// Creates a Button with a given text.
	/// </summary>
	/// <param name="buttonText">The text to be displayed in the button.</param>
	/// <returns>The new created button with text</returns>
	public static System.Windows.Forms.Button CreateStandardButton (System.String buttonText)
	{
		System.Windows.Forms.Button newButton = new System.Windows.Forms.Button();
		newButton.Text = buttonText;
		return newButton;
	}

	/// <summary>
	/// Creates a Button with a given image.
	/// </summary>
	/// <param name="buttonImage">The image to be displayed in the button.</param>
	/// <returns>The new created button with an image</returns>
	public static System.Windows.Forms.Button CreateStandardButton (System.Drawing.Image buttonImage)
	{
		System.Windows.Forms.Button newButton = new System.Windows.Forms.Button();
		newButton.Image = buttonImage;
		return newButton;
	}

	/// <summary>
	/// Creates a Button with a given image and a text.
	/// </summary>
	/// <param name="buttonText">The text to be displayed in the button.</param>
	/// <param name="buttonImage">The image to be displayed in the button.</param>
	/// <returns>The new created button with text and image</returns>
	public static System.Windows.Forms.Button CreateStandardButton (System.String buttonText, System.Drawing.Image buttonImage)
	{
		System.Windows.Forms.Button newButton = new System.Windows.Forms.Button();
		newButton.Text = buttonText;
		newButton.Image = buttonImage;
		return newButton;
	}
}
	/*******************************/
	/// <summary>
	/// Support Methods for FileDialog class. Note that several methods receive a DirectoryInfo object, but it won't be used in all cases.
	/// </summary>
	public class FileDialogSupport
	{
		/// <summary>
		/// Creates an OpenFileDialog open in a given path.
		/// </summary>
		/// <param name="path">Path to be opened by the OpenFileDialog.</param>
		/// <returns>A new instance of OpenFileDialog.</returns>
		public static System.Windows.Forms.OpenFileDialog CreateOpenFileDialog(System.IO.FileInfo path)
		{
			System.Windows.Forms.OpenFileDialog temp_fileDialog = new System.Windows.Forms.OpenFileDialog();
			temp_fileDialog.InitialDirectory = path.Directory.FullName;
			return temp_fileDialog;
		}

		/// <summary>
		/// Creates an OpenFileDialog open in a given path.
		/// </summary>
		/// <param name="path">Path to be opened by the OpenFileDialog.</param>
		/// <param name="directory">Directory to get the path from.</param>
		/// <returns>A new instance of OpenFileDialog.</returns>
		public static System.Windows.Forms.OpenFileDialog CreateOpenFileDialog(System.IO.FileInfo path, System.IO.DirectoryInfo directory)
		{
			System.Windows.Forms.OpenFileDialog temp_fileDialog = new System.Windows.Forms.OpenFileDialog();
			temp_fileDialog.InitialDirectory = path.Directory.FullName;
			return temp_fileDialog;
		}

		/// <summary>
		/// Creates a OpenFileDialog open in a given path.
		/// </summary>		
		/// <returns>A new instance of OpenFileDialog.</returns>
		public static System.Windows.Forms.OpenFileDialog CreateOpenFileDialog()
		{
			System.Windows.Forms.OpenFileDialog temp_fileDialog = new System.Windows.Forms.OpenFileDialog();
			temp_fileDialog.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);			
			return temp_fileDialog;
		}

		/// <summary>
		/// Creates an OpenFileDialog open in a given path.
		/// </summary>
		/// <param name="path">Path to be opened by the OpenFileDialog</param>
		/// <returns>A new instance of OpenFileDialog.</returns>
		public static System.Windows.Forms.OpenFileDialog CreateOpenFileDialog (System.String path)
		{
			System.Windows.Forms.OpenFileDialog temp_fileDialog = new System.Windows.Forms.OpenFileDialog();
			temp_fileDialog.InitialDirectory = path;
			return temp_fileDialog;
		}

		/// <summary>
		/// Creates an OpenFileDialog open in a given path.
		/// </summary>
		/// <param name="path">Path to be opened by the OpenFileDialog.</param>
		/// <param name="directory">Directory to get the path from.</param>
		/// <returns>A new instance of OpenFileDialog.</returns>
		public static System.Windows.Forms.OpenFileDialog CreateOpenFileDialog(System.String path, System.IO.DirectoryInfo directory)
		{
			System.Windows.Forms.OpenFileDialog temp_fileDialog = new System.Windows.Forms.OpenFileDialog();
			temp_fileDialog.InitialDirectory = path;
			return temp_fileDialog;
		}

		/// <summary>
		/// Modifies an instance of OpenFileDialog, to open a given directory.
		/// </summary>
		/// <param name="fileDialog">OpenFileDialog instance to be modified.</param>
		/// <param name="path">Path to be opened by the OpenFileDialog.</param>
		/// <param name="directory">Directory to get the path from.</param>
		public static void SetOpenFileDialog(System.Windows.Forms.FileDialog fileDialog, System.String path, System.IO.DirectoryInfo directory)
		{
			fileDialog.InitialDirectory = path;
		}

		/// <summary>
		/// Modifies an instance of OpenFileDialog, to open a given directory.
		/// </summary>
		/// <param name="fileDialog">OpenFileDialog instance to be modified.</param>
		/// <param name="path">Path to be opened by the OpenFileDialog</param>
		public static void SetOpenFileDialog(System.Windows.Forms.FileDialog fileDialog, System.IO.FileInfo path)
		{
			fileDialog.InitialDirectory = path.Directory.FullName;
		}

		/// <summary>
		/// Modifies an instance of OpenFileDialog, to open a given directory.
		/// </summary>
		/// <param name="fileDialog">OpenFileDialog instance to be modified.</param>
		/// <param name="path">Path to be opened by the OpenFileDialog.</param>
		public static void SetOpenFileDialog(System.Windows.Forms.FileDialog fileDialog, System.String path)
		{
			fileDialog.InitialDirectory = path;
		}

		///
		///  Use the following static methods to create instances of SaveFileDialog.
		///  By default, JFileChooser is converted as an OpenFileDialog, the following methods
		///  are provided to create file dialogs to save files.
		///	
		
		
		/// <summary>
		/// Creates a SaveFileDialog.
		/// </summary>		
		/// <returns>A new instance of SaveFileDialog.</returns>
		public static System.Windows.Forms.SaveFileDialog CreateSaveFileDialog()
		{
			System.Windows.Forms.SaveFileDialog temp_fileDialog = new System.Windows.Forms.SaveFileDialog();
			temp_fileDialog.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);			
			return temp_fileDialog;
		}

		/// <summary>
		/// Creates an SaveFileDialog open in a given path.
		/// </summary>
		/// <param name="path">Path to be opened by the SaveFileDialog.</param>
		/// <returns>A new instance of SaveFileDialog.</returns>
		public static System.Windows.Forms.SaveFileDialog CreateSaveFileDialog(System.IO.FileInfo path)
		{
			System.Windows.Forms.SaveFileDialog temp_fileDialog = new System.Windows.Forms.SaveFileDialog();
			temp_fileDialog.InitialDirectory = path.Directory.FullName;
			return temp_fileDialog;
		}

		/// <summary>
		/// Creates an SaveFileDialog open in a given path.
		/// </summary>
		/// <param name="path">Path to be opened by the SaveFileDialog.</param>
		/// <param name="directory">Directory to get the path from.</param>
		/// <returns>A new instance of SaveFileDialog.</returns>
		public static System.Windows.Forms.SaveFileDialog CreateSaveFileDialog(System.IO.FileInfo path, System.IO.DirectoryInfo directory)
		{
			System.Windows.Forms.SaveFileDialog temp_fileDialog = new System.Windows.Forms.SaveFileDialog();
			temp_fileDialog.InitialDirectory = path.Directory.FullName;
			return temp_fileDialog;
		}

		/// <summary>
		/// Creates a SaveFileDialog open in a given path.
		/// </summary>
		/// <param name="directory">Directory to get the path from.</param>
		/// <returns>A new instance of SaveFileDialog.</returns>
		public static System.Windows.Forms.SaveFileDialog CreateSaveFileDialog(System.IO.DirectoryInfo directory)
		{
			System.Windows.Forms.SaveFileDialog temp_fileDialog = new System.Windows.Forms.SaveFileDialog();
			temp_fileDialog.InitialDirectory = directory.FullName;
			return temp_fileDialog;
		}

		/// <summary>
		/// Creates an SaveFileDialog open in a given path.
		/// </summary>
		/// <param name="path">Path to be opened by the SaveFileDialog</param>
		/// <returns>A new instance of SaveFileDialog.</returns>
		public static System.Windows.Forms.SaveFileDialog CreateSaveFileDialog (System.String path)
		{
			System.Windows.Forms.SaveFileDialog temp_fileDialog = new System.Windows.Forms.SaveFileDialog();
			temp_fileDialog.InitialDirectory = path;
			return temp_fileDialog;
		}

		/// <summary>
		/// Creates an SaveFileDialog open in a given path.
		/// </summary>
		/// <param name="path">Path to be opened by the SaveFileDialog.</param>
		/// <param name="directory">Directory to get the path from.</param>
		/// <returns>A new instance of SaveFileDialog.</returns>
		public static System.Windows.Forms.SaveFileDialog CreateSaveFileDialog(System.String path, System.IO.DirectoryInfo directory)
		{
			System.Windows.Forms.SaveFileDialog temp_fileDialog = new System.Windows.Forms.SaveFileDialog();
			temp_fileDialog.InitialDirectory = path;
			return temp_fileDialog;
		}
	}
	/*******************************/
	/// <summary>
	/// Selects a range of text in the text box. 
	/// </summary>
	/// <param name="textContainer">The current text box.</param>
	/// <param name="start">The position of the first character in the current text selection within the text box.</param>
	/// <param name="offset">The number of characters to select.</param>
	public static void SelectText(System.Windows.Forms.TextBoxBase textContainer, int start, int offset)
	{
		if (offset - start < 0)
			((System.Windows.Forms.TextBoxBase)textContainer).Select(start,0);
		else
			((System.Windows.Forms.TextBoxBase)textContainer).Select(start, offset - start);
	}


	/*******************************/
	/// <summary>
	/// Writes the exception stack trace to the received stream
	/// </summary>
	/// <param name="throwable">Exception to obtain information from</param>
	/// <param name="stream">Output sream used to write to</param>
	public static void WriteStackTrace(System.Exception throwable, System.IO.TextWriter stream)
	{
		stream.Write(throwable.StackTrace);
		stream.Flush();
	}

	/*******************************/
	/// <summary>
	/// Give functions to obtain information of graphic elements
	/// </summary>
	public class GraphicsManager
	{
		//Instance of GDI+ drawing surfaces graphics hashtable
		static public GraphicsHashTable manager = new GraphicsHashTable();

		/// <summary>
		/// Creates a new Graphics object from the device context handle associated with the Graphics
		/// parameter
		/// </summary>
		/// <param name="oldGraphics">Graphics instance to obtain the parameter from</param>
		/// <returns>A new GDI+ drawing surface</returns>
		public static System.Drawing.Graphics CreateGraphics(System.Drawing.Graphics oldGraphics)
		{
			System.Drawing.Graphics createdGraphics;
			System.IntPtr hdc = oldGraphics.GetHdc();
			createdGraphics = System.Drawing.Graphics.FromHdc(hdc);
			oldGraphics.ReleaseHdc(hdc);
			return createdGraphics;
		}

		/// <summary>
		/// This method draws a Bezier curve.
		/// </summary>
		/// <param name="graphics">It receives the Graphics instance</param>
		/// <param name="array">An array of (x,y) pairs of coordinates used to draw the curve.</param>
		public static void Bezier(System.Drawing.Graphics graphics, int[] array)
		{
			System.Drawing.Pen pen;
			pen = GraphicsManager.manager.GetPen(graphics);
			try
			{
				graphics.DrawBezier(pen, array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7]);
			}
			catch(System.IndexOutOfRangeException e)
			{
				throw new System.IndexOutOfRangeException(e.ToString());
			}
		}

		/// <summary>
		/// Gets the text size width and height from a given GDI+ drawing surface and a given font
		/// </summary>
		/// <param name="graphics">Drawing surface to use</param>
		/// <param name="graphicsFont">Font type to measure</param>
		/// <param name="text">String of text to measure</param>
		/// <returns>A point structure with both size dimentions; x for width and y for height</returns>
		public static System.Drawing.Point GetTextSize(System.Drawing.Graphics graphics, System.Drawing.Font graphicsFont, System.String text)
		{
			System.Drawing.Point textSize;
			System.Drawing.SizeF tempSizeF;
			tempSizeF = graphics.MeasureString(text, graphicsFont);
			textSize = new System.Drawing.Point();
			textSize.X = (int) tempSizeF.Width;
			textSize.Y = (int) tempSizeF.Height;
			return textSize;
		}

		/// <summary>
		/// Gets the text size width and height from a given GDI+ drawing surface and a given font
		/// </summary>
		/// <param name="graphics">Drawing surface to use</param>
		/// <param name="graphicsFont">Font type to measure</param>
		/// <param name="text">String of text to measure</param>
		/// <param name="width">Maximum width of the string</param>
		/// <param name="format">StringFormat object that represents formatting information, such as line spacing, for the string</param>
		/// <returns>A point structure with both size dimentions; x for width and y for height</returns>
		public static System.Drawing.Point GetTextSize(System.Drawing.Graphics graphics, System.Drawing.Font graphicsFont, System.String text, System.Int32 width, System.Drawing.StringFormat format)
		{
			System.Drawing.Point textSize;
			System.Drawing.SizeF tempSizeF;
			tempSizeF = graphics.MeasureString(text, graphicsFont, width, format);
			textSize = new System.Drawing.Point();
			textSize.X = (int) tempSizeF.Width;
			textSize.Y = (int) tempSizeF.Height;
			return textSize;
		}

		/// <summary>
		/// Gives functionality over a hashtable of GDI+ drawing surfaces
		/// </summary>
		public class GraphicsHashTable:System.Collections.Hashtable 
		{
			/// <summary>
			/// Gets the graphics object from the given control
			/// </summary>
			/// <param name="control">Control to obtain the graphics from</param>
			/// <returns>A graphics object with the control's characteristics</returns>
			public System.Drawing.Graphics GetGraphics(System.Windows.Forms.Control control)
			{
				System.Drawing.Graphics graphic;
				if (control.Visible == true)
				{
					graphic = control.CreateGraphics();
					SetColor(graphic, control.ForeColor);
					SetFont(graphic, control.Font);
				}
				else
				{
					graphic = null;
				}
				return graphic;
			}

			/// <summary>
			/// Sets the background color property to the given graphics object in the hashtable. If the element doesn't exist, then it adds the graphic element to the hashtable with the given background color.
			/// </summary>
			/// <param name="graphic">Graphic element to search or add</param>
			/// <param name="color">Background color to set</param>
			public void SetBackColor(System.Drawing.Graphics graphic, System.Drawing.Color color)
			{
				if (this[graphic] != null)
					((GraphicsProperties) this[graphic]).BackColor = color;
				else
				{
					GraphicsProperties tempProps = new GraphicsProperties();
					tempProps.BackColor = color;
					Add(graphic, tempProps);
				}
			}

			/// <summary>
			/// Gets the background color property to the given graphics object in the hashtable. If the element doesn't exist, then it returns White.
			/// </summary>
			/// <param name="graphic">Graphic element to search</param>
			/// <returns>The background color of the graphic</returns>
			public System.Drawing.Color GetBackColor(System.Drawing.Graphics graphic)
			{
				if (this[graphic] == null)
					return System.Drawing.Color.White;
				else
					return ((GraphicsProperties) this[graphic]).BackColor;
			}

			/// <summary>
			/// Sets the text color property to the given graphics object in the hashtable. If the element doesn't exist, then it adds the graphic element to the hashtable with the given text color.
			/// </summary>
			/// <param name="graphic">Graphic element to search or add</param>
			/// <param name="color">Text color to set</param>
			public void SetTextColor(System.Drawing.Graphics graphic, System.Drawing.Color color)
			{
				if (this[graphic] != null)
					((GraphicsProperties) this[graphic]).TextColor = color;
				else
				{
					GraphicsProperties tempProps = new GraphicsProperties();
					tempProps.TextColor = color;
					Add(graphic, tempProps);
				}
			}

			/// <summary>
			/// Gets the text color property to the given graphics object in the hashtable. If the element doesn't exist, then it returns White.
			/// </summary>
			/// <param name="graphic">Graphic element to search</param>
			/// <returns>The text color of the graphic</returns>
			public System.Drawing.Color GetTextColor(System.Drawing.Graphics graphic) 
			{
				if (this[graphic] == null)
					return System.Drawing.Color.White;
				else
					return ((GraphicsProperties) this[graphic]).TextColor;
			}

			/// <summary>
			/// Sets the GraphicBrush property to the given graphics object in the hashtable. If the element doesn't exist, then it adds the graphic element to the hashtable with the given GraphicBrush.
			/// </summary>
			/// <param name="graphic">Graphic element to search or add</param>
			/// <param name="brush">GraphicBrush to set</param>
			public void SetBrush(System.Drawing.Graphics graphic, System.Drawing.SolidBrush brush) 
			{
				if (this[graphic] != null)
					((GraphicsProperties) this[graphic]).GraphicBrush = brush;
				else
				{
					GraphicsProperties tempProps = new GraphicsProperties();
					tempProps.GraphicBrush = brush;
					Add(graphic, tempProps);
				}
			}
			
			/// <summary>
			/// Sets the GraphicBrush property to the given graphics object in the hashtable. If the element doesn't exist, then it adds the graphic element to the hashtable with the given GraphicBrush.
			/// </summary>
			/// <param name="graphic">Graphic element to search or add</param>
			/// <param name="brush">GraphicBrush to set</param>
			public void SetPaint(System.Drawing.Graphics graphic, System.Drawing.Brush brush) 
			{
				if (this[graphic] != null)
					((GraphicsProperties) this[graphic]).PaintBrush = brush;
				else
				{
					GraphicsProperties tempProps = new GraphicsProperties();
					tempProps.PaintBrush = brush;
					Add(graphic, tempProps);
				}
			}
			
			/// <summary>
			/// Sets the GraphicBrush property to the given graphics object in the hashtable. If the element doesn't exist, then it adds the graphic element to the hashtable with the given GraphicBrush.
			/// </summary>
			/// <param name="graphic">Graphic element to search or add</param>
			/// <param name="color">Color to set</param>
			public void SetPaint(System.Drawing.Graphics graphic, System.Drawing.Color color) 
			{
				System.Drawing.Brush brush = new System.Drawing.SolidBrush(color);
				if (this[graphic] != null)
					((GraphicsProperties) this[graphic]).PaintBrush = brush;
				else
				{
					GraphicsProperties tempProps = new GraphicsProperties();
					tempProps.PaintBrush = brush;
					Add(graphic, tempProps);
				}
			}


			/// <summary>
			/// Gets the HatchBrush property to the given graphics object in the hashtable. If the element doesn't exist, then it returns Blank.
			/// </summary>
			/// <param name="graphic">Graphic element to search</param>
			/// <returns>The HatchBrush setting of the graphic</returns>
			public System.Drawing.Drawing2D.HatchBrush GetBrush(System.Drawing.Graphics graphic)
			{
				if (this[graphic] == null)
					return new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Plaid,System.Drawing.Color.Black,System.Drawing.Color.Black);
				else
					return new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Plaid,((GraphicsProperties) this[graphic]).GraphicBrush.Color,((GraphicsProperties) this[graphic]).GraphicBrush.Color);
			}
			
			/// <summary>
			/// Gets the HatchBrush property to the given graphics object in the hashtable. If the element doesn't exist, then it returns Blank.
			/// </summary>
			/// <param name="graphic">Graphic element to search</param>
			/// <returns>The Brush setting of the graphic</returns>
			public System.Drawing.Brush GetPaint(System.Drawing.Graphics graphic)
			{
				if (this[graphic] == null)
					return new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Plaid,System.Drawing.Color.Black,System.Drawing.Color.Black);
				else
					return ((GraphicsProperties) this[graphic]).PaintBrush;
			}

			/// <summary>
			/// Sets the GraphicPen property to the given graphics object in the hashtable. If the element doesn't exist, then it adds the graphic element to the hashtable with the given Pen.
			/// </summary>
			/// <param name="graphic">Graphic element to search or add</param>
			/// <param name="pen">Pen to set</param>
			public void SetPen(System.Drawing.Graphics graphic, System.Drawing.Pen pen) 
			{
				if (this[graphic] != null)
					((GraphicsProperties) this[graphic]).GraphicPen = pen;
				else
				{
					GraphicsProperties tempProps = new GraphicsProperties();
					tempProps.GraphicPen = pen;
					Add(graphic, tempProps);
				}
			}

			/// <summary>
			/// Gets the GraphicPen property to the given graphics object in the hashtable. If the element doesn't exist, then it returns Black.
			/// </summary>
			/// <param name="graphic">Graphic element to search</param>
			/// <returns>The GraphicPen setting of the graphic</returns>
			public System.Drawing.Pen GetPen(System.Drawing.Graphics graphic)
			{
				if (this[graphic] == null)
					return System.Drawing.Pens.Black;
				else
					return ((GraphicsProperties) this[graphic]).GraphicPen;
			}

			/// <summary>
			/// Sets the GraphicFont property to the given graphics object in the hashtable. If the element doesn't exist, then it adds the graphic element to the hashtable with the given Font.
			/// </summary>
			/// <param name="graphic">Graphic element to search or add</param>
			/// <param name="Font">Font to set</param>
			public void SetFont(System.Drawing.Graphics graphic, System.Drawing.Font font) 
			{
				if (this[graphic] != null)
					((GraphicsProperties) this[graphic]).GraphicFont = font;
				else
				{
					GraphicsProperties tempProps = new GraphicsProperties();
					tempProps.GraphicFont = font;
					Add(graphic,tempProps);
				}
			}

			/// <summary>
			/// Gets the GraphicFont property to the given graphics object in the hashtable. If the element doesn't exist, then it returns Microsoft Sans Serif with size 8.25.
			/// </summary>
			/// <param name="graphic">Graphic element to search</param>
			/// <returns>The GraphicFont setting of the graphic</returns>
			public System.Drawing.Font GetFont(System.Drawing.Graphics graphic)
			{
				if (this[graphic] == null)
					return new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				else
					return ((GraphicsProperties) this[graphic]).GraphicFont;
			}

			/// <summary>
			/// Sets the color properties for a given Graphics object. If the element doesn't exist, then it adds the graphic element to the hashtable with the color properties set with the given value.
			/// </summary>
			/// <param name="graphic">Graphic element to search or add</param>
			/// <param name="color">Color value to set</param>
			public void SetColor(System.Drawing.Graphics graphic, System.Drawing.Color color) 
			{
				if (this[graphic] != null)
				{
					((GraphicsProperties) this[graphic]).GraphicPen.Color = color;
					((GraphicsProperties) this[graphic]).GraphicBrush.Color = color;
					((GraphicsProperties) this[graphic]).color = color;
				}
				else
				{
					GraphicsProperties tempProps = new GraphicsProperties();
					tempProps.GraphicPen.Color = color;
					tempProps.GraphicBrush.Color = color;
					tempProps.color = color;
					Add(graphic,tempProps);
				}
			}

			/// <summary>
			/// Gets the color property to the given graphics object in the hashtable. If the element doesn't exist, then it returns Black.
			/// </summary>
			/// <param name="graphic">Graphic element to search</param>
			/// <returns>The color setting of the graphic</returns>
			public System.Drawing.Color GetColor(System.Drawing.Graphics graphic) 
			{
				if (this[graphic] == null)
					return System.Drawing.Color.Black;
				else
					return ((GraphicsProperties) this[graphic]).color;
			}

			/// <summary>
			/// This method gets the TextBackgroundColor of a Graphics instance
			/// </summary>
			/// <param name="graphic">The graphics instance</param>
			/// <returns>The color value in ARGB encoding</returns>
			public System.Drawing.Color GetTextBackgroundColor(System.Drawing.Graphics graphic)
			{
				if (this[graphic] == null)
					return System.Drawing.Color.Black;
				else 
				{ 
					return ((GraphicsProperties) this[graphic]).TextBackgroundColor;
				}
			}

			/// <summary>
			/// This method set the TextBackgroundColor of a Graphics instace
			/// </summary>
			/// <param name="graphic">The graphics instace</param>
			/// <param name="color">The System.Color to set the TextBackgroundColor</param>
			public void SetTextBackgroundColor(System.Drawing.Graphics graphic, System.Drawing.Color color) 
			{
				if (this[graphic] != null)
				{
					((GraphicsProperties) this[graphic]).TextBackgroundColor = color;								
				}
				else
				{
					GraphicsProperties tempProps = new GraphicsProperties();
					tempProps.TextBackgroundColor = color;				
					Add(graphic,tempProps);
				}
			}

			/// <summary>
			/// Structure to store properties from System.Drawing.Graphics objects
			/// </summary>
			class GraphicsProperties
			{
				public System.Drawing.Color TextBackgroundColor = System.Drawing.Color.Black;
				public System.Drawing.Color color = System.Drawing.Color.Black;
				public System.Drawing.Color BackColor = System.Drawing.Color.White;
				public System.Drawing.Color TextColor = System.Drawing.Color.Black;
				public System.Drawing.SolidBrush GraphicBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
				public System.Drawing.Brush PaintBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
				public System.Drawing.Pen   GraphicPen = new System.Drawing.Pen(System.Drawing.Color.Black);
				public System.Drawing.Font  GraphicFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			}
		}
	}

	/*******************************/
	/// <summary>
	/// Creates a GraphicsPath from two Int Arrays with a specific number of points.
	/// </summary>
	/// <param name="xPoints">Int Array to set the X points of the GraphicsPath</param>
	/// <param name="yPoints">Int Array to set the Y points of the GraphicsPath</param>
	/// <param name="pointsNumber">Number of points to add to the GraphicsPath</param>
	/// <returns>A new GraphicsPath</returns>
	public static System.Drawing.Drawing2D.GraphicsPath CreateGraphicsPath(int[] xPoints, int[] yPoints, int pointsNumber)
	{
		System.Drawing.Drawing2D.GraphicsPath tempGraphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
		if (pointsNumber == 2)
			tempGraphicsPath.AddLine(xPoints[0], yPoints[0], xPoints[1], yPoints[1]);
		else
		{
			System.Drawing.Point[] tempPointArray = new System.Drawing.Point[pointsNumber];
			for (int index = 0; index < pointsNumber; index++)
				tempPointArray[index] = new System.Drawing.Point(xPoints[index], yPoints[index]);

			tempGraphicsPath.AddPolygon(tempPointArray);
		}
		return tempGraphicsPath;
	}

}
