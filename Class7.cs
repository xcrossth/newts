using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
[StandardModule, HideModuleName, GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
internal sealed class Class7
{
	private static ResourceManager resourceManager_0;
	private static CultureInfo cultureInfo_0;
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (object.ReferenceEquals(Class7.resourceManager_0, null))
			{
				ResourceManager resourceManager = new ResourceManager("Server_TS_Online.Resources", typeof(Class7).Assembly);
				Class7.resourceManager_0 = resourceManager;
			}
			return Class7.resourceManager_0;
		}
	}
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		set
		{
			Class7.cultureInfo_0 = value;
		}
	}
	internal static string smethod_0()
	{
		return Class7.ResourceManager_0.GetString("BattleGate", Class7.cultureInfo_0);
	}
	internal static string smethod_1()
	{
		return Class7.ResourceManager_0.GetString("HP", Class7.cultureInfo_0);
	}
	internal static string smethod_2()
	{
		return Class7.ResourceManager_0.GetString("HPCS", Class7.cultureInfo_0);
	}
	internal static string smethod_3()
	{
		return Class7.ResourceManager_0.GetString("ItemOnMap", Class7.cultureInfo_0);
	}
	internal static string smethod_4()
	{
		return Class7.ResourceManager_0.GetString("Items", Class7.cultureInfo_0);
	}
	internal static string smethod_5()
	{
		return Class7.ResourceManager_0.GetString("NpcOnMap", Class7.cultureInfo_0);
	}
	internal static string PvxUcloLc()
	{
		return Class7.ResourceManager_0.GetString("Npcs", Class7.cultureInfo_0);
	}
	internal static string smethod_6()
	{
		return Class7.ResourceManager_0.GetString("Skills", Class7.cultureInfo_0);
	}
	internal static string smethod_7()
	{
		return Class7.ResourceManager_0.GetString("SP", Class7.cultureInfo_0);
	}
	internal static string smethod_8()
	{
		return Class7.ResourceManager_0.GetString("SPCS", Class7.cultureInfo_0);
	}
	internal static string smethod_9()
	{
		return Class7.ResourceManager_0.GetString("Talks", Class7.cultureInfo_0);
	}
	internal static string smethod_10()
	{
		return Class7.ResourceManager_0.GetString("Texps", Class7.cultureInfo_0);
	}
	internal static string smethod_11()
	{
		return Class7.ResourceManager_0.GetString("warps", Class7.cultureInfo_0);
	}
}
