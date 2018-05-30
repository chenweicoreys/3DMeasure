using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XDA;

class SerialKey
{
	public static bool setSerialKey()
	{
		string _serialKey = "enter serial key here";

		if (_serialKey == "enter serial key here")
		{
			{
				if (File.Exists("serial.key"))
				{
                    //读取stream
					TextReader tr = new StreamReader("serial.key");
                    //控制台应用程序读取用户一行字符
					String serialKey = tr.ReadLine();
					tr.Close();

					if (XsControl.setSerialKey(new XsString(serialKey)))
						return true;
				}
			}


			// ask for serial key
			{
                //Interaction 弹出输入框
				String serialKey = Interaction.InputBox("Please enter valid serial key",
											"If you built this example yourself you can enter the key in \"serialkey.h\"",
											_serialKey, 100, 100);

				if (XsControl.setSerialKey(new XsString(serialKey)))
				{
					// store it
					TextWriter tw = new StreamWriter("serial.key");
					tw.WriteLine(serialKey);
					tw.Close();
					return true;
				}
				return false;
			}
		}
		return XsControl.setSerialKey(new XsString(_serialKey));
	}
}
