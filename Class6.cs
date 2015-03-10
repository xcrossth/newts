using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.InteropServices;
[StandardModule]
internal sealed class Class6
{
	[DllImport("kernel32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern int WritePrivateProfileStringW([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_3);
	[DllImport("kernel32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern int GetPrivateProfileStringW([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_3, int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_4);
	public static void smethod_0(string string_0, string string_1, string string_2, string string_3)
	{
		Class6.WritePrivateProfileStringW(ref string_1, ref string_2, ref string_3, ref string_0);
	}
	public static string smethod_1(string string_0, string string_1, string string_2, string string_3)
	{
		string text = Strings.Space(1024);
		long num = (long)Class6.GetPrivateProfileStringW(ref string_1, ref string_2, ref string_3, ref text, Strings.Len(text), ref string_0);
		string result;
		if (num > 0L)
		{
			result = Strings.Left(text, checked((int)num));
		}
		else
		{
			result = "nothing";
		}
		return result;
	}
	public static string smethod_2(string string_0, string string_1, string string_2, string string_3)
	{
		string text = Strings.Space(1024);
		long num = (long)Class6.GetPrivateProfileStringW(ref string_1, ref string_2, ref string_3, ref text, Strings.Len(text), ref string_0);
		string result;
		if (num > 0L)
		{
			result = Strings.Left(text, checked((int)num));
		}
		else
		{
			result = "";
		}
		return result;
	}
	public static string smethod_3(string string_0, string string_1, string string_2, string string_3)
	{
		string text = Strings.Space(1024);
		long num = (long)Class6.GetPrivateProfileStringW(ref string_1, ref string_2, ref string_3, ref text, Strings.Len(text), ref string_0);
		string result;
		if (num > 0L)
		{
			result = Strings.Left(text, checked((int)num));
		}
		else
		{
			result = "0";
		}
		return result;
	}
}
