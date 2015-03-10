using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
namespace Server_TS_Online.My
{
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), CompilerGenerated]
	internal sealed class MySettings : ApplicationSettingsBase
	{
		private static MySettings mySettings_0;
		private static bool bool_0;
		private static object object_0;
		public static MySettings Default
		{
			get
			{
				if (!MySettings.bool_0)
				{
					object obj = MySettings.object_0;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					Monitor.Enter(obj);
					try
					{
						if (!MySettings.bool_0)
						{
							Class1.Form0_0.Shutdown += new ShutdownEventHandler(MySettings.smethod_0);
							MySettings.bool_0 = true;
						}
					}
					finally
					{
						Monitor.Exit(obj);
					}
				}
				return MySettings.mySettings_0;
			}
		}
		[ApplicationScopedSetting, DefaultSettingValue("Data Source=|DataDirectory|\\CSDL\\Player.sdf"), SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode]
		public string PlayerConnectionString
		{
			get
			{
				return Conversions.ToString(this["PlayerConnectionString"]);
			}
		}
		[ApplicationScopedSetting, DefaultSettingValue("Data Source=|DataDirectory|\\CSDL\\Data.sdf"), SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode]
		public string DataConnectionString
		{
			get
			{
				return Conversions.ToString(this["DataConnectionString"]);
			}
		}
		[ApplicationScopedSetting, DefaultSettingValue("Data Source=|DataDirectory|\\CSDL\\Formula.sdf"), SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode]
		public string FormulaConnectionString
		{
			get
			{
				return Conversions.ToString(this["FormulaConnectionString"]);
			}
		}
		[ApplicationScopedSetting, DefaultSettingValue("Data Source=|DataDirectory|\\1000.sdf"), SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode]
		public string NewCharConnectionString
		{
			get
			{
				return Conversions.ToString(this["NewCharConnectionString"]);
			}
		}
		[ApplicationScopedSetting, DefaultSettingValue("Data Source=|DataDirectory|\\1.sdf"), SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode]
		public string _1ConnectionString
		{
			get
			{
				return Conversions.ToString(this["_1ConnectionString"]);
			}
		}
		[ApplicationScopedSetting, DefaultSettingValue("Data Source=|DataDirectory|\\CSDL\\Account.sdf"), SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode]
		public string AccountConnectionString
		{
			get
			{
				return Conversions.ToString(this["AccountConnectionString"]);
			}
		}
		[ApplicationScopedSetting, DefaultSettingValue("Data Source=|DataDirectory|\\CSDL\\NewChar.sdf"), SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode]
		public string NewCharConnectionString1
		{
			get
			{
				return Conversions.ToString(this["NewCharConnectionString1"]);
			}
		}
		[ApplicationScopedSetting, DefaultSettingValue("Data Source=|DataDirectory|\\PlayerOnline.sdf"), SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode]
		public string PlayerOnlineConnectionString
		{
			get
			{
				return Conversions.ToString(this["PlayerOnlineConnectionString"]);
			}
		}
		[ApplicationScopedSetting, DefaultSettingValue("Data Source=|DataDirectory|\\ItemOnMap.sdf"), SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode]
		public string ItemOnMapConnectionString
		{
			get
			{
				return Conversions.ToString(this["ItemOnMapConnectionString"]);
			}
		}
		[ApplicationScopedSetting, DefaultSettingValue("Data Source=|DataDirectory|\\CSDL\\Talk.sdf"), SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode]
		public string TalkConnectionString
		{
			get
			{
				return Conversions.ToString(this["TalkConnectionString"]);
			}
		}
		[ApplicationScopedSetting, DefaultSettingValue("Data Source=|DataDirectory|\\CSDL\\WarpQuest.sdf"), SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode]
		public string WarpConnectionString
		{
			get
			{
				return Conversions.ToString(this["WarpConnectionString"]);
			}
		}
		[ApplicationScopedSetting, DefaultSettingValue("Data Source=|DataDirectory|\\CSDL\\TalkQuest.sdf"), SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode]
		public string TalkQuestConnectionString
		{
			get
			{
				return Conversions.ToString(this["TalkQuestConnectionString"]);
			}
		}
		[ApplicationScopedSetting, DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\CSDL\\Database.accdb;Persist Security Info=True"), SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode]
		public string DatabaseConnectionString
		{
			get
			{
				return Conversions.ToString(this["DatabaseConnectionString"]);
			}
		}
		[ApplicationScopedSetting, DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\CSDL\\DataTSVN.accdb;Persist Security Info=True"), SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode]
		public string DataTSVNConnectionString
		{
			get
			{
				return Conversions.ToString(this["DataTSVNConnectionString"]);
			}
		}
		[ApplicationScopedSetting, DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\CSDL\\Member.accdb"), SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode]
		public string MemberConnectionString
		{
			get
			{
				return Conversions.ToString(this["MemberConnectionString"]);
			}
		}
		[ApplicationScopedSetting, DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\CSDL\\Account.accdb;Persist Security Info=True"), SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode]
		public string AccountConnectionString1
		{
			get
			{
				return Conversions.ToString(this["AccountConnectionString1"]);
			}
		}
		static MySettings()
		{
			MySettings.mySettings_0 = (MySettings)SettingsBase.Synchronized(new MySettings());
			MySettings.object_0 = RuntimeHelpers.GetObjectValue(new object());
		}
		[EditorBrowsable(EditorBrowsableState.Advanced), DebuggerNonUserCode]
		private static void smethod_0(object sender, EventArgs e)
		{
			if (Class1.Form0_0.SaveMySettingsOnExit)
			{
				Class8.MySettings_0.Save();
			}
		}
	}
}
