using System;
//UPGRADE_TODO: The package 'javax.imageio' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using javax.imageio;
//UPGRADE_TODO: The package 'jp.sourceforge.qrcode.codec' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using jp.sourceforge.qrcode.codec;
//UPGRADE_TODO: The type 'jp.sourceforge.qrcode.codec.data.QRCodeImage' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using QRCodeImage = jp.sourceforge.qrcode.codec.data.QRCodeImage;
//UPGRADE_TODO: The type 'jp.sourceforge.qrcode.codec.exception.DecodingFailedException' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using DecodingFailedException = jp.sourceforge.qrcode.codec.exception.DecodingFailedException;
//UPGRADE_TODO: The package 'jp.sourceforge.qrcode.codec.util' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using jp.sourceforge.qrcode.codec.util;
//UPGRADE_TODO: The type 'jp.sourceforge.qrcode.codec.geom.Line' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using Line = jp.sourceforge.qrcode.codec.geom.Line;
//UPGRADE_TODO: The type 'jp.sourceforge.qrcode.codec.geom.Point' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using Point = jp.sourceforge.qrcode.codec.geom.Point;

// Example of GUI QRCode reader application

[Serializable]
public class QRCodeDecoderGUIExample:System.Windows.Forms.Form
{
	internal System.Windows.Forms.MainMenu menuBar;
	internal System.Windows.Forms.MenuItem fileMenu;
	internal System.Windows.Forms.MenuItem openMenu;
	internal System.Windows.Forms.TextBox url;
	internal System.Windows.Forms.Button button;
	internal System.Windows.Forms.FileDialog chooser;
	internal System.Drawing.Bitmap sourceImage;
	internal System.Windows.Forms.Label sourceImageLabel;
	internal J2SEDebugCanvas canvas;
	internal System.Windows.Forms.TextBox decodedText;
	internal const long serialVersionUID = 1;
	
	//UPGRADE_NOTE: Field 'EnclosingInstance' was added to class 'J2SEImage' to access its enclosing instance. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1019'"
	internal class J2SEImage : QRCodeImage
	{
		private void  InitBlock(QRCodeDecoderGUIExample enclosingInstance)
		{
			this.enclosingInstance = enclosingInstance;
		}
		private QRCodeDecoderGUIExample enclosingInstance;
		virtual public int Width
		{
			get
			{
				return image.Width;
			}
			
		}
		virtual public int Height
		{
			get
			{
				return image.Height;
			}
			
		}
		public QRCodeDecoderGUIExample Enclosing_Instance
		{
			get
			{
				return enclosingInstance;
			}
			
		}
		internal System.Drawing.Bitmap image;
		
		public J2SEImage(QRCodeDecoderGUIExample enclosingInstance, System.Drawing.Bitmap image)
		{
			InitBlock(enclosingInstance);
			this.image = image;
		}
		
		public virtual int getPixel(int x, int y)
		{
			return image.GetPixel(x, y).ToArgb();
		}
	}
	
	internal QRCodeDecoderGUIExample()
	{
		System.Console.Out.WriteLine("Starting QRCode Decoder GUI Example ...");
		//UPGRADE_TODO: Method 'java.awt.Component.setSize' was converted to 'System.Windows.Forms.Control.Size' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtComponentsetSize_int_int'"
		Size = new System.Drawing.Size(400, 400);
		Closing += new System.ComponentModel.CancelEventHandler(this.QRCodeDecoderGUIExample_Closing_EXIT_ON_CLOSE);
		menuBar = new System.Windows.Forms.MainMenu();
		openMenu = new System.Windows.Forms.MenuItem();
		openMenu.Text = "Open Image";
		openMenu.Click += new System.EventHandler(this.actionPerformed);
		SupportClass.CommandManager.CheckCommand(openMenu);
		menuBar.MenuItems.Add(openMenu);
		Menu = menuBar;
		//UPGRADE_TODO: Constructor 'javax.swing.JTextField.JTextField' was converted to 'System.Windows.Forms.TextBox' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaxswingJTextFieldJTextField_int'"
		url = new System.Windows.Forms.TextBox();
		//UPGRADE_TODO: Method 'javax.swing.text.JTextComponent.setText' was converted to 'System.Windows.Forms.TextBoxBase.Text' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaxswingtextJTextComponentsetText_javalangString'"
		url.Text = "(Or input image url here.)";
		button = SupportClass.ButtonSupport.CreateStandardButton("Open from URL");
		button.Click += new System.EventHandler(this.actionPerformed);
		SupportClass.CommandManager.CheckCommand(button);
		System.Windows.Forms.Panel urlPanel = new System.Windows.Forms.Panel();
		//UPGRADE_TODO: Method 'java.awt.Container.add' was converted to 'System.Windows.Forms.ContainerControl.Controls.Add' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtContaineradd_javaawtComponent'"
		urlPanel.Controls.Add(url);
		//UPGRADE_TODO: Method 'java.awt.Container.add' was converted to 'System.Windows.Forms.ContainerControl.Controls.Add' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtContaineradd_javaawtComponent'"
		urlPanel.Controls.Add(button);
		button = SupportClass.ButtonSupport.CreateStandardButton("URL");
		//UPGRADE_TODO: Method 'javax.swing.JFrame.getContentPane' was converted to 'System.Windows.Forms.Form' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaxswingJFramegetContentPane'"
		//UPGRADE_TODO: Method 'java.awt.Container.add' was converted to 'System.Windows.Forms.ContainerControl.Controls.Add' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtContaineradd_javaawtComponent_javalangObject'"
		((System.Windows.Forms.ContainerControl) this).Controls.Add(urlPanel);
		urlPanel.Dock = System.Windows.Forms.DockStyle.Top;
		urlPanel.SendToBack();
		//UPGRADE_TODO: Constructor may need to be changed depending on function performed by the 'System.Windows.Forms.FileDialog' object. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1270'"
		chooser = SupportClass.FileDialogSupport.CreateOpenFileDialog("Open QR Code Image");
		//UPGRADE_ISSUE: Method 'javax.swing.JFileChooser.setFileFilter' was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1000_javaxswingJFileChoosersetFileFilter_javaxswingfilechooserFileFilter'"
		chooser.setFileFilter(new ImageFileFilter());
		//UPGRADE_TODO: Method 'java.awt.Component.setLocation' was converted to 'System.Windows.Forms.Control.Location' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtComponentsetLocation_int_int'"
		Location = new System.Drawing.Point(300, 200);
		SupportClass.SelectText(url, 0, url.Text.Length);
		//UPGRADE_TODO: Method 'java.awt.Component.setVisible' was converted to 'System.Windows.Forms.Control.Visible' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtComponentsetVisible_boolean'"
		//UPGRADE_TODO: 'System.Windows.Forms.Application.Run' must be called to start a main form. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1135'"
		Visible = true;
	}
	
	public virtual void  actionPerformed(System.Object event_sender, System.EventArgs event_Renamed)
	{
		if (event_sender.Equals(openMenu))
		{
			chooser.ShowDialog(this);
			if (new System.IO.FileInfo(chooser.FileName) == null)
				return ;
			try
			{
				sourceImage = ImageIO.read(new System.IO.FileInfo(chooser.FileName));
			}
			catch (System.Exception e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
			}
		}
		else if (SupportClass.CommandManager.GetCommand(event_sender).Equals("Open from URL"))
		{
			try
			{
				//UPGRADE_TODO: Class 'java.net.URL' was converted to a 'System.Uri' which does not throw an exception if a URL specifies an unknown protocol. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1132'"
				sourceImage = ImageIO.read(new System.Uri(url.Text));
			}
			catch (System.Exception e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
			}
		}
		else
			return ;
		
		if (sourceImageLabel != null)
		{
			//UPGRADE_TODO: Method 'javax.swing.JFrame.getContentPane' was converted to 'System.Windows.Forms.Form' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaxswingJFramegetContentPane'"
			((System.Windows.Forms.ContainerControl) this).Controls.Remove(sourceImageLabel);
		}
		
		System.Windows.Forms.Label temp_label;
		temp_label = new System.Windows.Forms.Label();
		temp_label.Image = (System.Drawing.Image) sourceImage.Clone();
		sourceImageLabel = temp_label;
		//UPGRADE_TODO: Method 'javax.swing.JFrame.getContentPane' was converted to 'System.Windows.Forms.Form' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaxswingJFramegetContentPane'"
		//UPGRADE_TODO: Method 'java.awt.Container.add' was converted to 'System.Windows.Forms.ContainerControl.Controls.Add' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtContaineradd_javaawtComponent_javalangObject'"
		((System.Windows.Forms.ContainerControl) this).Controls.Add(sourceImageLabel);
		sourceImageLabel.Dock = System.Windows.Forms.DockStyle.Left;
		sourceImageLabel.BringToFront();
		
		
		QRCodeDecoder decoder = new QRCodeDecoder();
		if (canvas != null)
		{
			//UPGRADE_TODO: Method 'javax.swing.JFrame.getContentPane' was converted to 'System.Windows.Forms.Form' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaxswingJFramegetContentPane'"
			((System.Windows.Forms.ContainerControl) this).Controls.Remove(canvas);
			//canvas.setImage(null);
		}
		canvas = new J2SEDebugCanvas();
		QRCodeDecoder.setCanvas(canvas);
		//UPGRADE_TODO: Method 'javax.swing.JFrame.getContentPane' was converted to 'System.Windows.Forms.Form' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaxswingJFramegetContentPane'"
		//UPGRADE_TODO: Method 'java.awt.Container.add' was converted to 'System.Windows.Forms.ContainerControl.Controls.Add' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtContaineradd_javaawtComponent_javalangObject'"
		((System.Windows.Forms.ContainerControl) this).Controls.Add(canvas);
		canvas.Dock = System.Windows.Forms.DockStyle.Right;
		canvas.BringToFront();
		System.String decodedString = null;
		try
		{
			decodedString = new String(decoder.decode(new J2SEImage(this, sourceImage)));
		}
		catch (DecodingFailedException e)
		{
			canvas.println(e.getMessage());
			canvas.println("--------");
			return ;
		}
		decodedString = ContentConverter.convert(decodedString);
		canvas.println("\nDecode result:");
		canvas.println(decodedString);
		canvas.println("--------");
		if (decodedText != null)
		{
			//UPGRADE_TODO: Method 'javax.swing.JFrame.getContentPane' was converted to 'System.Windows.Forms.Form' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaxswingJFramegetContentPane'"
			((System.Windows.Forms.ContainerControl) this).Controls.Remove(decodedText);
		}
		System.Windows.Forms.TextBox temp_TextBox;
		temp_TextBox = new System.Windows.Forms.TextBox();
		temp_TextBox.Multiline = true;
		temp_TextBox.WordWrap = false;
		temp_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		temp_TextBox.Text = decodedString;
		decodedText = temp_TextBox;
		decodedText.WordWrap = true;
		//UPGRADE_ISSUE: Method 'javax.swing.JTextArea.setRows' was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1000_javaxswingJTextAreasetRows_int'"
		decodedText.setRows(decodedString.Length / 20 + 1);
		if (decodedString.Length < 20)
		{
			//UPGRADE_ISSUE: Method 'javax.swing.JTextArea.setColumns' was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1000_javaxswingJTextAreasetColumns_int'"
			decodedText.setColumns(decodedString.Length);
		}
		else
		{
			//UPGRADE_ISSUE: Method 'javax.swing.JTextArea.setColumns' was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1000_javaxswingJTextAreasetColumns_int'"
			decodedText.setColumns(20);
		}
		//decodedText.setSize(sourceImageLabel.getSize().width,100);
		//UPGRADE_TODO: Method 'javax.swing.JFrame.getContentPane' was converted to 'System.Windows.Forms.Form' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaxswingJFramegetContentPane'"
		//UPGRADE_TODO: Method 'java.awt.Container.add' was converted to 'System.Windows.Forms.ContainerControl.Controls.Add' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtContaineradd_javaawtComponent_javalangObject'"
		((System.Windows.Forms.ContainerControl) this).Controls.Add(decodedText);
		decodedText.Dock = System.Windows.Forms.DockStyle.Bottom;
		decodedText.SendToBack();
		//UPGRADE_ISSUE: Method 'java.awt.Window.pack' was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1000_javaawtWindowpack'"
		pack();
	}
	[STAThread]
	public static void  Main(System.String[] args)
	{
		new QRCodeDecoderGUIExample();
	}
	private void  QRCodeDecoderGUIExample_Closing_EXIT_ON_CLOSE(System.Object sender, System.ComponentModel.CancelEventArgs  e)
	{
		e.Cancel = true;
		SupportClass.CloseOperation((System.Windows.Forms.Form) sender, 3);
	}
}

//UPGRADE_ISSUE: Class 'javax.swing.filechooser.FileFilter' was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1000_javaxswingfilechooserFileFilter'"
class ImageFileFilter:javax.swing.filechooser.FileFilter
{
	internal System.String[] acceptExtendsions = new System.String[]{"jpg", "jpeg", "gif", "png"};
	
	public System.String getDescription()
	{
		return "QR Code Image files (*.jpg,*.png,*.gif,*.png)";
	}
	public bool accept(System.IO.FileInfo f)
	{
		if (System.IO.Directory.Exists(f.FullName))
			return true;
		
		System.String extension = getExtension(f);
		if (extension == null)
			return true;
		for (int i = 0; i < acceptExtendsions.Length; i++)
		{
			if (extension.Equals(acceptExtendsions[i]))
				return true;
		}
		return false;
	}
	
	internal virtual System.String getExtension(System.IO.FileInfo f)
	{
		System.String ext = null;
		System.String s = f.Name;
		int i = s.LastIndexOf('.');
		
		if (i > 0 && i < s.Length - 1)
		{
			ext = s.Substring(i + 1).ToLower();
		}
		return ext;
	}
}


[Serializable]
class J2SEDebugCanvas:System.Windows.Forms.Control, DebugCanvas
{
	virtual public int FontColor
	{
		set
		{
		}
		
	}
	virtual public System.Drawing.Bitmap Image
	{
		get
		{
			return image;
		}
		
		set
		{
			this.image = value;
		}
		
	}
	internal System.Drawing.Bitmap image;
	
	
	protected override void  OnPaint(System.Windows.Forms.PaintEventArgs g_EventArg)
	{
		System.Drawing.Graphics g = null;
		if (g_EventArg != null)
			g = g_EventArg.Graphics;
		if (image != null)
			g.drawImage(image, 0, 0, java.awt.Color.WHITE, null);
	}
	
	public virtual void  println(System.String string_Renamed)
	{
		System.Console.Out.WriteLine(string_Renamed);
	}
	
	public virtual void  drawMatrix(bool[][] matrix)
	{
		if (image == null)
		{
			image = new System.Drawing.Bitmap(matrix.Length, matrix[0].Length, (System.Drawing.Imaging.PixelFormat) System.Drawing.Imaging.PixelFormat.Format32bppArgb);
			//UPGRADE_TODO: Method 'java.awt.Component.setSize' was converted to 'System.Windows.Forms.Control.Size' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtComponentsetSize_int_int'"
			Size = new System.Drawing.Size(matrix.Length, matrix[0].Length);
		}
		System.Drawing.Graphics g2d = System.Drawing.Graphics.FromImage(image);
		g2d.setColor(java.awt.Color.WHITE);
		int width = Width;
		for (int x = 0; x < matrix.Length; x++)
		{
			g2d.DrawLine(SupportClass.GraphicsManager.manager.GetPen(g2d), x, 0, x, width);
		}
		g2d.setColor(java.awt.Color.BLACK);
		for (int x = 0; x < matrix.Length; x++)
		{
			for (int y = 0; y < matrix[0].Length; y++)
			{
				if (matrix[x][y] == true)
					g2d.DrawLine(SupportClass.GraphicsManager.manager.GetPen(g2d), x, y, x, y);
			}
		}
		//UPGRADE_TODO: Method 'java.awt.Component.repaint' was converted to 'System.Windows.Forms.Control.Refresh' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtComponentrepaint'"
		Refresh();
	}
	
	public virtual void  drawLine(Line line, int color)
	{
		System.Drawing.Graphics g2d = System.Drawing.Graphics.FromImage(image);
		//UPGRADE_TODO: Constructor 'java.awt.Color.Color' was converted to 'System.Drawing.Color.FromArgb' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtColorColor_int'"
		SupportClass.GraphicsManager.manager.SetColor(g2d, System.Drawing.Color.FromArgb(color));
		g2d.drawLine(line.getP1().getX(), line.getP1().getY(), line.getP2().getX(), line.getP2().getY());
		//UPGRADE_TODO: Method 'java.awt.Component.repaint' was converted to 'System.Windows.Forms.Control.Refresh' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtComponentrepaint'"
		Refresh();
	}
	
	public virtual void  drawLines(Line[] lines, int color)
	{
		System.Drawing.Graphics g2d = System.Drawing.Graphics.FromImage(image);
		//UPGRADE_TODO: Constructor 'java.awt.Color.Color' was converted to 'System.Drawing.Color.FromArgb' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtColorColor_int'"
		SupportClass.GraphicsManager.manager.SetColor(g2d, System.Drawing.Color.FromArgb(color));
		for (int i = 0; i < lines.length; i++)
		{
			g2d.drawLine(lines[i].getP1().getX(), lines[i].getP1().getY(), lines[i].getP2().getX(), lines[i].getP2().getY());
		}
		//UPGRADE_TODO: Method 'java.awt.Component.repaint' was converted to 'System.Windows.Forms.Control.Refresh' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtComponentrepaint'"
		Refresh();
	}
	
	public virtual void  drawPolygon(System.Drawing.Point[] points, int color)
	{
		System.Drawing.Graphics g2d = System.Drawing.Graphics.FromImage(image);
		//UPGRADE_TODO: Constructor 'java.awt.Color.Color' was converted to 'System.Drawing.Color.FromArgb' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtColorColor_int'"
		SupportClass.GraphicsManager.manager.SetColor(g2d, System.Drawing.Color.FromArgb(color));
		int numPoints = points.Length;
		int[] polygonX = new int[numPoints];
		int[] polygonY = new int[numPoints];
		for (int i = 0; i < numPoints; i++)
		{
			//UPGRADE_TODO: Method 'java.awt.Point.getX' was converted to 'System.Drawing.Point.X' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtPointgetX'"
			polygonX[i] = (int) (points[i].X);
			//UPGRADE_TODO: Method 'java.awt.Point.getY' was converted to 'System.Drawing.Point.Y' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtPointgetY'"
			polygonY[i] = (int) (points[i].Y);
		}
		g2d.DrawPath(SupportClass.GraphicsManager.manager.GetPen(g2d), SupportClass.CreateGraphicsPath(polygonX, polygonY, numPoints));
		//UPGRADE_TODO: Method 'java.awt.Component.repaint' was converted to 'System.Windows.Forms.Control.Refresh' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtComponentrepaint'"
		Refresh();
	}
	
	public virtual void  drawPoints(System.Drawing.Point[] points, int color)
	{
		System.Drawing.Graphics g2d = System.Drawing.Graphics.FromImage(image);
		//UPGRADE_TODO: Constructor 'java.awt.Color.Color' was converted to 'System.Drawing.Color.FromArgb' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtColorColor_int'"
		SupportClass.GraphicsManager.manager.SetColor(g2d, System.Drawing.Color.FromArgb(color));
		for (int i = 0; i < points.Length; i++)
		{
			//UPGRADE_TODO: Method 'java.awt.Point.getX' was converted to 'System.Drawing.Point.X' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtPointgetX'"
			//UPGRADE_TODO: Method 'java.awt.Point.getY' was converted to 'System.Drawing.Point.Y' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtPointgetY'"
			g2d.drawLine(points[i].X, points[i].Y, points[i].X, points[i].Y);
		}
		//UPGRADE_TODO: Method 'java.awt.Component.repaint' was converted to 'System.Windows.Forms.Control.Refresh' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtComponentrepaint'"
		Refresh();
	}
	
	
	//UPGRADE_NOTE: ref keyword was added to struct-type parameters. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1303'"
	public virtual void  drawPoint(ref System.Drawing.Point point, int color)
	{
		System.Drawing.Graphics g2d = System.Drawing.Graphics.FromImage(image);
		//UPGRADE_TODO: Constructor 'java.awt.Color.Color' was converted to 'System.Drawing.Color.FromArgb' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtColorColor_int'"
		SupportClass.GraphicsManager.manager.SetColor(g2d, System.Drawing.Color.FromArgb(color));
		//UPGRADE_TODO: Method 'java.awt.Point.getX' was converted to 'System.Drawing.Point.X' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtPointgetX'"
		//UPGRADE_TODO: Method 'java.awt.Point.getY' was converted to 'System.Drawing.Point.Y' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtPointgetY'"
		g2d.drawLine(point.X, point.Y, point.X, point.Y);
		//UPGRADE_TODO: Method 'java.awt.Component.repaint' was converted to 'System.Windows.Forms.Control.Refresh' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtComponentrepaint'"
		Refresh();
	}
	
	//UPGRADE_NOTE: ref keyword was added to struct-type parameters. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1303'"
	public virtual void  drawCross(ref System.Drawing.Point point, int color)
	{
		//UPGRADE_TODO: Method 'java.awt.Point.getX' was converted to 'System.Drawing.Point.X' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtPointgetX'"
		int x = (int) (point.X);
		//UPGRADE_TODO: Method 'java.awt.Point.getY' was converted to 'System.Drawing.Point.Y' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaawtPointgetY'"
		int y = (int) (point.Y);
		
		Line[] lines = new Line[]{new Line(x - 5, y - 1, x + 5, y - 1), new Line(x - 1, y - 5, x - 1, y + 5), new Line(x - 5, y + 1, x + 5, y + 1), new Line(x + 1, y - 5, x + 1, y + 5), new Line(x - 5, y, x + 5, y), new Line(x, y - 5, x, y + 5)};
		drawLines(lines, color);
	}
}