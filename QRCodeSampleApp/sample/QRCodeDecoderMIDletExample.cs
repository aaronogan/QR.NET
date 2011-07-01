using System;
//UPGRADE_TODO: The type 'javax.microedition.lcdui.Canvas' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using Canvas = javax.microedition.lcdui.Canvas;
//UPGRADE_TODO: The type 'javax.microedition.lcdui.Command' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using Command = javax.microedition.lcdui.Command;
//UPGRADE_TODO: The type 'javax.microedition.lcdui.CommandListener' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using CommandListener = javax.microedition.lcdui.CommandListener;
//UPGRADE_TODO: The type 'javax.microedition.lcdui.Display' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using Display = javax.microedition.lcdui.Display;
//UPGRADE_TODO: The type 'javax.microedition.lcdui.Displayable' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using Displayable = javax.microedition.lcdui.Displayable;
//UPGRADE_TODO: The type 'javax.microedition.lcdui.Font' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using Font = javax.microedition.lcdui.Font;
//UPGRADE_TODO: The type 'javax.microedition.lcdui.Graphics' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using Graphics = javax.microedition.lcdui.Graphics;
//UPGRADE_TODO: The type 'javax.microedition.lcdui.Image' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using Image = javax.microedition.lcdui.Image;
//UPGRADE_TODO: The type 'javax.microedition.lcdui.TextBox' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using TextBox = javax.microedition.lcdui.TextBox;
//UPGRADE_TODO: The type 'javax.microedition.lcdui.TextField' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using TextField = javax.microedition.lcdui.TextField;
//UPGRADE_TODO: The type 'javax.microedition.media.Manager' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using Manager = javax.microedition.media.Manager;
//UPGRADE_TODO: The type 'javax.microedition.media.MediaException' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using MediaException = javax.microedition.media.MediaException;
//UPGRADE_TODO: The type 'javax.microedition.media.Player' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using Player = javax.microedition.media.Player;
//UPGRADE_TODO: The type 'javax.microedition.media.control.VideoControl' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using VideoControl = javax.microedition.media.control.VideoControl;
//UPGRADE_TODO: The type 'javax.microedition.midlet.MIDlet' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using MIDlet = javax.microedition.midlet.MIDlet;
//UPGRADE_TODO: The type 'jp.sourceforge.qrcode.codec.QRCodeDecoder' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using QRCodeDecoder = jp.sourceforge.qrcode.codec.QRCodeDecoder;
//UPGRADE_TODO: The type 'jp.sourceforge.qrcode.codec.data.QRCodeImage' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using QRCodeImage = jp.sourceforge.qrcode.codec.data.QRCodeImage;
//UPGRADE_TODO: The type 'jp.sourceforge.qrcode.codec.exception.DecodingFailedException' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using DecodingFailedException = jp.sourceforge.qrcode.codec.exception.DecodingFailedException;
//UPGRADE_TODO: The type 'jp.sourceforge.qrcode.codec.geom.Line' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using Line = jp.sourceforge.qrcode.codec.geom.Line;
//UPGRADE_TODO: The type 'jp.sourceforge.qrcode.codec.geom.Point' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using Point = jp.sourceforge.qrcode.codec.geom.Point;
//UPGRADE_TODO: The type 'jp.sourceforge.qrcode.codec.util.DebugCanvas' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using DebugCanvas = jp.sourceforge.qrcode.codec.util.DebugCanvas;

// Example of Midlet QR Code reader application

public class QRCodeDecoderMIDletExample:MIDlet
{
	private CameraCanvas cameraCanvas = null;
	private DisplayCanvas displayCanvas = null;
	private DecodedTextBox decodedTextBox = null;
	public QRCodeDecoderMIDletExample()
	{
	}
	
	public virtual void  startApp()
	{
		Displayable current = Display.getDisplay(this).getCurrent();
		if (current == null)
		{
			cameraCanvas = new CameraCanvas(this);
			displayCanvas = new DisplayCanvas(this);
			decodedTextBox = new DecodedTextBox(this);
			Display.getDisplay(this).setCurrent(cameraCanvas);
			cameraCanvas.start();
		}
		else
		{
			if (current == cameraCanvas)
			{
				cameraCanvas.start();
			}
			Display.getDisplay(this).setCurrent(current);
		}
	}
	public virtual void  pauseApp()
	{
		if (Display.getDisplay(this).getCurrent() == cameraCanvas)
		{
			cameraCanvas.stop();
		}
	}
	public virtual void  destroyApp(bool b)
	{
		if (Display.getDisplay(this).getCurrent() == cameraCanvas)
		{
			cameraCanvas.stop();
		}
	}
	private void  exitRequested()
	{
		destroyApp(false);
		notifyDestroyed();
	}
	internal virtual void  cameraCanvasExit()
	{
		exitRequested();
	}
	internal virtual void  cameraCanvasCaptured(sbyte[] pngData)
	{
		cameraCanvas.stop();
		displayCanvas.Image = pngData;
		Display.getDisplay(this).setCurrent(displayCanvas);
		Image image = Image.createImage(pngData, 0, pngData.Length);
		// TODO Uncomment below for demo on emulator
		try
		{
			image = Image.createImage("/qrcode.jpg");
		}
		catch (System.IO.IOException ioe)
		{
		}
		QRCodeDecoder decoder = new QRCodeDecoder();
		QRCodeDecoder.setCanvas(displayCanvas);
		try
		{
			decodedTextBox.DecodedString = new String(decoder.decode(new J2MEImage(image)));
		}
		catch (DecodingFailedException dfe)
		{
			displayCanvas.println("Decoding failed");
			displayCanvas.println("(" + dfe.getMessage() + ")");
			displayCanvas.println("--------");
			return ;
		}
		displayCanvas.println("--------");
		displayCanvas.addViewDecodedStringCommand();
	}
	internal virtual void  displayCanvasBack()
	{
		Display.getDisplay(this).setCurrent(cameraCanvas);
		cameraCanvas.start();
	}
	internal virtual void  decodedTextBoxBack()
	{
		Display.getDisplay(this).setCurrent(displayCanvas);
	}
	internal virtual void  toDecodedTextBox()
	{
		Display.getDisplay(this).setCurrent(decodedTextBox);
	}
}

class CameraCanvas:Canvas, CommandListener
{
	//UPGRADE_NOTE: Final was removed from the declaration of 'midlet '. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1003'"
	private QRCodeDecoderMIDletExample midlet;
	//UPGRADE_NOTE: Final was removed from the declaration of 'exitCommand '. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1003'"
	private Command exitCommand;
	private Command captureCommand = null;
	private Player player = null;
	private VideoControl videoControl = null;
	
	private bool active = false;
	
	private System.String message1 = null;
	private System.String message2 = null;
	
	
	public CameraCanvas(QRCodeDecoderMIDletExample midlet)
	{
		this.midlet = midlet;
		exitCommand = new Command("Exit", Command.EXIT, 1);
		addCommand(exitCommand);
		setCommandListener(this);
		try
		{
			player = Manager.createPlayer("capture://video");
			player.realize();
			videoControl = (VideoControl) player.getControl("VideoControl");
			if (videoControl == null)
			{
				discardPlayer();
				message1 = "Unsupported:";
				message2 = "Can't get video control";
			}
			else
			{
				videoControl.initDisplayMode(VideoControl.USE_DIRECT_VIDEO, this);
				captureCommand = new Command("Capture", Command.SCREEN, 1);
				addCommand(captureCommand);
			}
		}
		catch (System.IO.IOException ioe)
		{
			discardPlayer();
			message1 = "IOException:";
			//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Throwable.getMessage' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
			message2 = ioe.Message;
		}
		catch (MediaException me)
		{
			discardPlayer();
			message1 = "MediaException:";
			message2 = me.getMessage();
		}
		catch (System.Security.SecurityException se)
		{
			discardPlayer();
			message1 = "SecurityException";
			//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Throwable.getMessage' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
			message2 = se.Message;
		}
	}
	private void  discardPlayer()
	{
		if (player != null)
		{
			player.close();
			player = null;
		}
		videoControl = null;
	}
	public virtual void  paint(Graphics g)
	{
		g.setColor(0xFFFFFF);
		g.fillRect(0, 0, getWidth(), getHeight());
		if (message1 != null)
		{
			g.setColor(0x000000);
			g.drawString(message1, 1, 1, Graphics.TOP | Graphics.LEFT);
			g.drawString(message2, 1, 1 + g.getFont().getHeight(), Graphics.TOP | Graphics.LEFT);
		}
	}
	//UPGRADE_NOTE: Synchronized keyword was removed from method 'start'. Lock expression was added. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1027'"
	internal virtual void  start()
	{
		lock (this)
		{
			if ((player != null) && !active)
			{
				try
				{
					player.start();
					videoControl.setVisible(true);
				}
				catch (MediaException me)
				{
					message1 = "Media exception:";
					message2 = me.getMessage();
				}
				catch (System.Security.SecurityException se)
				{
					message1 = "SecurityException";
					//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Throwable.getMessage' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
					message2 = se.Message;
				}
				active = true;
			}
		}
	}
	//UPGRADE_NOTE: Synchronized keyword was removed from method 'stop'. Lock expression was added. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1027'"
	internal virtual void  stop()
	{
		lock (this)
		{
			if ((player != null) && active)
			{
				try
				{
					videoControl.setVisible(false);
					player.stop();
				}
				catch (MediaException me)
				{
					message1 = "MediaException:";
					message2 = me.getMessage();
				}
				active = false;
			}
		}
	}
	public virtual void  commandAction(Command c, Displayable d)
	{
		if (c == exitCommand)
		{
			midlet.cameraCanvasExit();
		}
		else if (c == captureCommand)
		{
			takeSnapshot();
		}
	}
	public virtual void  keyPressed(int keyCode)
	{
		if (getGameAction(keyCode) == FIRE)
		{
			takeSnapshot();
		}
	}
	private void  takeSnapshot()
	{
		if (player != null)
		{
			try
			{
				sbyte[] pngImage = videoControl.getSnapshot(null);
				midlet.cameraCanvasCaptured(pngImage);
			}
			catch (MediaException me)
			{
				message1 = "MediaException;";
				message2 = me.getMessage();
			}
		}
	}
}

class DisplayCanvas:Canvas, CommandListener, DebugCanvas
{
	virtual internal sbyte[] Image
	{
		set
		{
			image = Image.createImage(value, 0, value.Length);
		}
		
	}
	//UPGRADE_NOTE: Final was removed from the declaration of 'midlet '. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1003'"
	private QRCodeDecoderMIDletExample midlet;
	private Image image = null;
	private Command viewDecodedStringCommand = null;
	private System.String[] log = null;
	private int numCols;
	private int numRows;
	internal Font logFont = null;
	internal DisplayCanvas(QRCodeDecoderMIDletExample midlet)
	{
		this.midlet = midlet;
		addCommand(new Command("Camera", Command.BACK, 1));
		setCommandListener(this);
		logFont = Font.getDefaultFont();
		numRows = this.getHeight() / logFont.getHeight();
		numCols = this.getWidth() / logFont.charWidth('_');
		log = new System.String[numRows];
	}
	public virtual void  paint(Graphics g)
	{
		g.setColor(0xFFFFFF);
		g.fillRect(0, 0, getWidth(), getHeight());
		if (image != null)
		{
			g.drawImage(image, getWidth() / 2, getHeight() / 2, Graphics.VCENTER | Graphics.HCENTER);
		}
		g.setColor(0x000000);
		for (int i = 0; i < log.Length; i++)
		{
			if (log[i] != null)
			{
				g.drawString(log[i], 0, i * logFont.getHeight(), Graphics.TOP | Graphics.LEFT);
			}
		}
	}
	internal virtual void  addViewDecodedStringCommand()
	{
		if (viewDecodedStringCommand == null)
		{
			viewDecodedStringCommand = new Command("Result", Command.SCREEN, 1);
			addCommand(viewDecodedStringCommand);
		}
	}
	public virtual void  commandAction(Command c, Displayable d)
	{
		if (c == viewDecodedStringCommand)
		{
			midlet.toDecodedTextBox();
		}
		else
		{
			midlet.displayCanvasBack();
		}
	}
	public virtual void  drawCross(Point point, int color)
	{
		Image bufImage = Image.createImage(image.getWidth(), image.getHeight());
		Graphics g = bufImage.getGraphics();
		g.drawImage(image, 0, 0, 0);
		g.setColor(color);
		g.drawLine(point.getX() - 5, point.getY(), point.getX() + 5, point.getY());
		g.drawLine(point.getX(), point.getY() - 5, point.getX(), point.getY() + 5);
		image = bufImage;
		repaint();
	}
	public virtual void  drawLine(Line line, int color)
	{
		Image bufImage = Image.createImage(image.getWidth(), image.getHeight());
		Graphics g = bufImage.getGraphics();
		g.drawImage(image, 0, 0, 0);
		g.setColor(color);
		g.drawLine(line.getP1().getX(), line.getP1().getY(), line.getP2().getX(), line.getP2().getY());
		image = bufImage;
		repaint();
	}
	public virtual void  drawLines(Line[] lines, int color)
	{
		Image bufImage = Image.createImage(image.getWidth(), image.getHeight());
		Graphics g = bufImage.getGraphics();
		g.drawImage(image, 0, 0, 0);
		g.setColor(color);
		
		for (int i = 0; i < lines.length - 1; i++)
		{
			g.drawLine(lines[i].getP1().getX(), lines[i].getP1().getY(), lines[i].getP2().getX(), lines[i].getP2().getY());
		}
		image = bufImage;
		repaint();
	}
	public virtual void  drawMatrix(bool[][] matrix)
	{
		Image bufImage = Image.createImage(image.getWidth(), image.getHeight());
		Graphics g = bufImage.getGraphics();
		g.setColor(0xCCCCCC);
		for (int y = 0; y < matrix[0].Length; y++)
		{
			for (int x = 0; x < matrix.Length; x++)
			{
				if (matrix[x][y] == true)
					g.drawLine(x, y, x + 1, y);
			}
		}
		image = bufImage;
		repaint();
	}
	public virtual void  drawPoint(Point point, int color)
	{
		/*		Image bufImage = Image.createImage(image.getWidth(), image.getHeight());
		Graphics g = bufImage.getGraphics();
		g.drawImage(image, 0, 0, 0);
		g.setColor(color);
		g.drawLine(point.getX(), point.getY(),
		point.getX()+1, point.getY());
		image = bufImage;
		repaint();*/
	}
	public virtual void  drawPoints(Point[] points, int color)
	{
		Image bufImage = Image.createImage(image.getWidth(), image.getHeight());
		Graphics g = bufImage.getGraphics();
		g.drawImage(image, 0, 0, 0);
		g.setColor(color);
		for (int i = 0; i < points.length - 1; i++)
		{
			g.drawLine(points[i].getX(), points[i].getY(), points[i].getX() + 1, points[i].getY());
		}
		image = bufImage;
		repaint();
	}
	public virtual void  drawPolygon(Point[] points, int color)
	{
		Image bufImage = Image.createImage(image.getWidth(), image.getHeight());
		Graphics g = bufImage.getGraphics();
		g.drawImage(image, 0, 0, 0);
		g.setColor(color);
		int i = 0;
		for (; i < points.length - 1; i++)
		{
			g.drawLine(points[i].getX(), points[i].getY(), points[i + 1].getX(), points[i + 1].getY());
		}
		g.drawLine(points[i].getX(), points[i].getY(), points[0].getX(), points[0].getY());
		image = bufImage;
		repaint();
	}
	public virtual void  println(System.String message)
	{
		System.Console.Out.WriteLine(message);
		int numParts = message.Length / numCols;
		if (message.Length % numCols > 0)
		{
			numParts += 1;
		}
		System.String[] lineStrings = new System.String[numParts];
		int offset = 0;
		for (int i = 0; i < numParts - 1; i++)
		{
			lineStrings[i] = message.Substring(offset, (offset + numCols) - (offset));
			offset += numCols;
		}
		lineStrings[numParts - 1] = message.Substring(offset);
		int numLoggedLine = 0;
		if (log[log.Length - numParts] == null)
		{
			for (int i = 0; i < log.Length; i++)
			{
				if (log[i] == null)
				{
					log[i] = lineStrings[numLoggedLine];
					numLoggedLine += 1;
					if (numLoggedLine == lineStrings.Length)
						break;
				}
			}
		}
		else
		{
			int i;
			for (i = 0; i < log.Length - numParts; i++)
			{
				log[i] = log[i + numParts];
			}
			
			for (int start = i; i < log.Length; i++)
			{
				log[i] = lineStrings[i - start];
			}
		}
		repaint();
	}
}

class DecodedTextBox:TextBox, CommandListener
{
	virtual public System.String DecodedString
	{
		set
		{
			this.setString(value);
		}
		
	}
	internal QRCodeDecoderMIDletExample midlet;
	public DecodedTextBox(QRCodeDecoderMIDletExample midlet):base("Decoded String", "", 2048, TextField.ANY)
	{
		this.midlet = midlet;
		addCommand(new Command("Back", Command.BACK, 1));
		setCommandListener(this);
	}
	public virtual void  commandAction(Command c, Displayable d)
	{
		midlet.decodedTextBoxBack();
	}
}

class J2MEImage : QRCodeImage
{
	virtual public int Height
	{
		get
		{
			return image.Height;
		}
		
	}
	virtual public int Width
	{
		get
		{
			return image.Width;
		}
		
	}
	internal Image image;
	internal int[] intImage;
	public J2MEImage(Image image)
	{
		this.image = image;
		intImage = new int[image.Width * image.Height];
		image.getRGB(this.intImage, 0, image.Width, 0, 0, image.Width, image.Height);
	}
	public virtual int getPixel(int x, int y)
	{
		return intImage[x + y * image.Width];
	}
}