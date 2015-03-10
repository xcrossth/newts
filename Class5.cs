using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
[StandardModule]
internal sealed class Class5
{
	public const short short_0 = 260;
	public const long long_0 = 2035711L;
	public static long long_1;
	public const long long_2 = 4L;
	public const long long_3 = 76L;
	public const long long_4 = 80L;
	public const long long_5 = 1594L;
	public const long long_6 = 1004L;
	public const long long_7 = 4837L;
	public const long fXfpwyGkm = 1408L;
	public static long long_8;
	public const long long_9 = 41176L;
	public const long long_10 = 41180L;
	private const int int_0 = 5;
	private const int int_1 = 207;
	static Class5()
	{
		Class5.long_1 = 9465848L;
		Class5.long_8 = checked(Class5.long_1 + 4508L);
	}
	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ReadProcessMemory(int int_2, int int_3, ref byte byte_0, int int_4, ref int int_5);
	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "ReadProcessMemory", ExactSpelling = true, SetLastError = true)]
	public static extern int ReadProcessMemory_1(int int_2, int int_3, ref int int_4, int int_5, ref int int_6);
	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "ReadProcessMemory", ExactSpelling = true, SetLastError = true)]
	public static extern int ReadProcessMemory_2(int int_2, int int_3, ref short short_1, int int_4, ref int int_5);
	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "ReadProcessMemory", ExactSpelling = true, SetLastError = true)]
	public static extern int ReadProcessMemory_3(int int_2, int int_3, ref ushort ushort_0, int int_4, ref int int_5);
	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int WriteProcessMemory(int int_2, int int_3, ref long long_11, int int_4, int int_5);
	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowThreadProcessId(int int_2, ref int int_3);
	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int OpenProcess(int int_2, int int_3, int int_4);
	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SetForegroundWindow(int int_2);
	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetForegroundWindow();
	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int CloseHandle(int int_2);
	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, int int_2, int int_3);
	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetClassNameA(int int_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_3);
	public static void smethod_0(RichTextBox richTextBox_0, string string_0, Color color_0)
	{
		int length = richTextBox_0.Text.Length;
		richTextBox_0.AppendText(string_0 + "\r\n\r\n");
		richTextBox_0.Select(length, checked(string_0.Length + 1));
		richTextBox_0.SelectionColor = color_0;
		richTextBox_0.Select(length, 0);
		richTextBox_0.ScrollToCaret();
		if (richTextBox_0.Lines.Length >= 150)
		{
			richTextBox_0.Clear();
		}
	}
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_1(string string_0)
	{
		try
		{
			string text = Class1.Form0_0.Info.DirectoryPath + "\\log.txt";
			if (!Class1.Class0_0.FileSystem.FileExists(text))
			{
				new FileStream(text, FileMode.Create, FileAccess.Write);
			}
			StreamWriter streamWriter = new StreamWriter(text, true);
			streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
			streamWriter.WriteLine(string_0);
			streamWriter.Close();
		}
		catch (Exception expr_63)
		{
			ProjectData.SetProjectError(expr_63);
			ProjectData.ClearProjectError();
		}
	}
	public static int smethod_2(int int_2)
	{
		checked
		{
			int num3 = 0;
			if (int_2 > 0)
			{
				int num = Class5.OpenProcess(2035711, 0, int_2);
				int arg_1F_0 = num;
				int arg_1F_1 = (int)Class5.long_1;
				int arg_1F_3 = 4;
				int num2 = 0;
				Class5.ReadProcessMemory_1(arg_1F_0, arg_1F_1, ref num3, arg_1F_3, ref num2);
				int arg_3A_0 = num;
				int arg_3A_1 = (int)(unchecked((long)num3) + 4837L);
				int arg_3A_3 = 4;
				num2 = 0;
				Class5.ReadProcessMemory_1(arg_3A_0, arg_3A_1, ref num3, arg_3A_3, ref num2);
				if (num > 0)
				{
					Class5.CloseHandle(num);
				}
			}
			return num3;
		}
	}
	public static string smethod_3(byte[] byte_0)
	{
		string text = "";
		checked
		{
			for (int i = 0; i < byte_0.Length; i++)
			{
				byte b = byte_0[i];
				text += b.ToString("X2");
			}
			return text;
		}
	}
	public static byte[] smethod_4(string string_0)
	{
		checked
		{
			byte[] array = new byte[(int)Math.Round(unchecked((double)string_0.Length / 2.0 - 1.0)) + 1];
			try
			{
				for (int i = 0; i < string_0.Length; i += 2)
				{
					array[(int)Math.Round((double)i / 2.0)] = byte.Parse(string_0.Substring(i, 2), NumberStyles.HexNumber);
				}
			}
			catch (Exception expr_62)
			{
				ProjectData.SetProjectError(expr_62);
				Interaction.MsgBox(string_0, MsgBoxStyle.OkOnly, null);
				ProjectData.ClearProjectError();
			}
			return array;
		}
	}
	public static byte[] smethod_5(byte[] byte_0)
	{
		checked
		{
			byte[] array = new byte[byte_0.Length - 1 + 1];
			int arg_14_0 = 0;
			int num = byte_0.Length - 1;
			for (int i = arg_14_0; i <= num; i++)
			{
				array[i] = (byte)(byte_0[i] ^ 173);
			}
			return array;
		}
	}
	public static string smethod_6(byte[] byte_0)
	{
		string text = "";
		int arg_0D_0 = 0;
		checked
		{
			int num = byte_0.Length - 1;
			for (int i = arg_0D_0; i <= num; i++)
			{
				text += Conversions.ToString(Strings.Chr((int)byte_0[i]));
			}
			return text;
		}
	}
	public static string smethod_7(int int_2)
	{
		string text = "";
		int num = 0;
        int num2 = 0;
        int num3 = 0;
		if (int_2 >= 86400)
		{
			text = Conversions.ToString(int_2 / 86400) + " ngày ";
			if (int_2 % 86400 / 3600 > 9)
			{
				num = int_2 % 86400 / 3600;
			}
			else
			{
				num = Conversions.ToInteger(Conversions.ToString(0) + Conversions.ToString(int_2 % 86400 / 3600));
			}
			if (int_2 % 86400 % 3600 / 60 > 9)
			{
				num2 = int_2 % 86400 % 3600 / 60;
			}
			else
			{
				num2 = Conversions.ToInteger(Conversions.ToString(0) + Conversions.ToString(int_2 % 86400 % 3600 / 60));
			}
			if (int_2 % 86400 % 3600 % 60 > 9)
			{
				num3 = int_2 % 86400 % 3600 % 60;
			}
			else
			{
				num3 = Conversions.ToInteger(Conversions.ToString(0) + Conversions.ToString(int_2 % 86400 % 3600 % 60));
			}
		}
		else
		{
			if (int_2 < 86400 & int_2 >= 3600)
			{
				if (int_2 / 3600 > 9)
				{
					num = int_2 / 3600;
				}
				else
				{
					num = Conversions.ToInteger(Conversions.ToString(0) + Conversions.ToString(int_2 / 3600));
				}
				if (int_2 % 3600 / 60 > 9)
				{
					num2 = int_2 % 3600 / 60;
				}
				else
				{
					num2 = Conversions.ToInteger(Conversions.ToString(0) + Conversions.ToString(int_2 % 3600 / 60));
				}
				if (int_2 % 3600 % 60 > 9)
				{
					num3 = int_2 % 3600 % 60;
				}
				else
				{
					num3 = Conversions.ToInteger(Conversions.ToString(0) + Conversions.ToString(int_2 % 3600 % 60));
				}
			}
			else
			{
				if (int_2 < 3600 & int_2 >= 60)
				{
					if (int_2 / 60 > 9)
					{
						num2 = int_2 / 60;
					}
					else
					{
						num2 = Conversions.ToInteger(Conversions.ToString(0) + Conversions.ToString(int_2 / 60));
					}
					if (int_2 % 60 > 9)
					{
						num3 = int_2 % 60;
					}
					else
					{
						num3 = Conversions.ToInteger(Conversions.ToString(0) + Conversions.ToString(int_2 % 60));
					}
				}
				else
				{
					if (int_2 < 60)
					{
						if (int_2 > 9)
						{
							num3 = int_2;
						}
						else
						{
							num3 = Conversions.ToInteger(Conversions.ToString(0) + Conversions.ToString(int_2));
						}
					}
				}
			}
		}
		return string.Concat(new string[]
		{
			text,
			num.ToString("00"),
			":",
			num2.ToString("00"),
			":",
			num3.ToString("00")
		});
	}
	public static string smethod_8(int int_2)
	{
		string result;
		switch (int_2)
		{
		case 1:
			result = "Địa";
			break;
		case 2:
			result = "Thuỷ";
			break;
		case 3:
			result = "Hoả";
			break;
		case 4:
			result = "Phong";
			break;
		default:
			result = "Không";
			break;
		}
		return result;
	}
	public static int smethod_9(byte[] byte_0)
	{
		return Convert.ToInt32(Class5.smethod_3(new byte[]
		{
			byte_0[1],
			byte_0[0]
		}), 16);
	}
	public static int smethod_10(byte[] byte_0)
	{
		return Convert.ToInt32(Class5.smethod_3(new byte[]
		{
			byte_0[3],
			byte_0[2],
			byte_0[1],
			byte_0[0]
		}), 16);
	}
	public static string smethod_11(int int_2)
	{
		return int_2.ToString("X4").Substring(2, 2) + int_2.ToString("X4").Substring(0, 2);
	}
	public static string smethod_12(int int_2)
	{
		return int_2.ToString("X8").Substring(6, 2) + int_2.ToString("X8").Substring(4, 2) + int_2.ToString("X8").Substring(2, 2) + int_2.ToString("X8").Substring(0, 2);
	}
	public static string smethod_13(string string_0)
	{
		string text = "";
		int arg_10_0 = 0;
		checked
		{
			int num = string_0.Length - 1;
			for (int i = arg_10_0; i <= num; i++)
			{
				text += Strings.AscW(string_0.Substring(i, 1)).ToString("X2");
			}
			return text;
		}
	}
	public static int smethod_14(string string_0)
	{
		byte[] array = Class5.smethod_4(string_0);
		int result = 0;
		switch (array.Length)
		{
		case 2:
			result = Convert.ToInt32(Class5.smethod_3(new byte[]
			{
				array[1],
				array[0]
			}), 16);
			break;
		case 4:
			result = Convert.ToInt32(Class5.smethod_3(new byte[]
			{
				array[3],
				array[2],
				array[1],
				array[0]
			}), 16);
			break;
		}
		return result;
	}
	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int SendMessage(IntPtr intptr_0, int int_2, int int_3, int int_4);
	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetWindow(IntPtr intptr_0, int int_2);
	public static void smethod_15(int int_2, ref ComboBox comboBox_0)
	{
		try
		{
			IntPtr window = Class5.GetWindow(comboBox_0.Handle, 5);
			if (!window.Equals(IntPtr.Zero))
			{
				Class5.SendMessage(window, 207, int_2, 0);
				comboBox_0.Refresh();
			}
		}
		catch (Exception expr_3F)
		{
			ProjectData.SetProjectError(expr_3F);
			ProjectData.ClearProjectError();
		}
	}
	public static Color smethod_16(int int_2)
	{
		Color result = SystemColors.Control;
		switch (int_2)
		{
		case 1:
			result = Color.Peru;
			break;
		case 2:
			result = Color.DodgerBlue;
			break;
		case 3:
			result = Color.LightCoral;
			break;
		case 4:
			result = Color.LimeGreen;
			break;
		}
		return result;
	}
	public static string smethod_17(string string_0)
	{
		string str = "áàäãÕå¡¢ÆÇ£â¤¥¦ç§éèë¨©êª«¬­®íìïî¸óòöõ÷ô¯°±²µ½¾¶·ÞþúùüûøßÑ×ØæñýÏÖÛÜðÁÀÄÃÁÅ\u0081‚AAƒÂ„…†\u0006‡ÉÈËˆ‰ÊŠ‹Œ\u008dÊÍÌ›Î˜ÓÒ???Ô\u008f\u0090‘’´•–—³ÚÙœ\u009dÚ¿º»¼ÿ¹ÝŸ???Ð";
		string @string = "áàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵđÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖƠỚỜỞỠÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴĐ";
		string text = "";
		object obj;
		object loopObj;
        int i = 0;
        obj = i;
        loopObj = i;
        if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 0, checked(string_0.Length - 1), 1, ref loopObj, ref obj))
		{
			do
			{
				string text2 = string_0.Substring(Conversions.ToInteger(obj), 1);
				if (Operators.CompareString(text2, "\r", false) == 0)
				{
					text += "\r";
				}
				else
				{
					if (Operators.CompareString(text2, "\n", false) == 0)
					{
						text += "\n";
					}
					else
					{
						object obj2 = Strings.InStr(@string, text2, CompareMethod.Binary);
						if (Operators.ConditionalCompareObjectLessEqual(obj2, 0, false))
						{
							text += text2;
						}
						else
						{
							text += Strings.Mid(str, Conversions.ToInteger(obj2), 1);
						}
					}
				}
			}
			while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, loopObj, ref obj));
		}
		return text;
	}
	public static byte[] smethod_18(DataSet dataSet_0)
	{
		byte[] result;
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress);
			dataSet_0.WriteXml(gZipStream, XmlWriteMode.WriteSchema);
			gZipStream.Close();
			byte[] array = memoryStream.ToArray();
			memoryStream.Close();
			result = array;
		}
		catch (Exception expr_2E)
		{
			ProjectData.SetProjectError(expr_2E);
			result = null;
			ProjectData.ClearProjectError();
		}
		return result;
	}
	public static DataSet smethod_19(byte[] byte_0)
	{
		DataSet result;
		try
		{
			MemoryStream memoryStream = new MemoryStream(byte_0);
			GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(gZipStream, XmlReadMode.ReadSchema);
			gZipStream.Close();
			memoryStream.Close();
			result = dataSet;
		}
		catch (Exception expr_2F)
		{
			ProjectData.SetProjectError(expr_2F);
			result = null;
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
