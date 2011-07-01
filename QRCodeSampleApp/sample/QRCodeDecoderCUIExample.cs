using System;
//UPGRADE_TODO: The type 'jp.sourceforge.qrcode.codec.QRCodeDecoder' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using QRCodeDecoder = jp.sourceforge.qrcode.codec.QRCodeDecoder;
//UPGRADE_TODO: The type 'jp.sourceforge.qrcode.codec.data.QRCodeImage' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using QRCodeImage = jp.sourceforge.qrcode.codec.data.QRCodeImage;
//UPGRADE_TODO: The type 'jp.sourceforge.qrcode.codec.exception.DecodingFailedException' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using DecodingFailedException = jp.sourceforge.qrcode.codec.exception.DecodingFailedException;
//UPGRADE_TODO: The type 'jp.sourceforge.qrcode.codec.exception.InvalidVersionInfoException' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using InvalidVersionInfoException = jp.sourceforge.qrcode.codec.exception.InvalidVersionInfoException;
//UPGRADE_TODO: The type 'javax.imageio.ImageIO' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
using ImageIO = javax.imageio.ImageIO;

// Smallest example of QRCode Decoder

public class QRCodeDecoderCUIExample
{
	[STAThread]
	public static void  Main(System.String[] args)
	{
		/*
		if (args.length < 1) {
		System.out.println("Usage: QRCodeDecoderCUIExample imageFilePath");
		System.exit(0);
		}
		*/
		QRCodeDecoder decoder = new QRCodeDecoder();
		System.IO.FileInfo imageFile = new System.IO.FileInfo("C:\\Source\\qrcode\\5265.jpg");
		System.Drawing.Bitmap image = null;
		try
		{
			image = ImageIO.read(imageFile);
		}
		catch (System.IO.IOException e)
		{
			//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Throwable.getMessage' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
			System.Console.Out.WriteLine("Error: " + e.Message);
		}
		try
		{
			System.String decodedData = new String(decoder.decode(new J2SEImage(image)));
			System.Console.Out.WriteLine(decodedData);
		}
		catch (DecodingFailedException dfe)
		{
			System.Console.Out.WriteLine("Error: " + dfe.getMessage());
		}
	}
}

class J2SEImage : QRCodeImage
{
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
	internal System.Drawing.Bitmap image;
	
	public J2SEImage(System.Drawing.Bitmap image)
	{
		this.image = image;
	}
	
	public virtual int getPixel(int x, int y)
	{
		return image.GetPixel(x, y).ToArgb();
	}
}