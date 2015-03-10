using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Server_TS_Online;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
[StandardModule, HideModuleName, GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class Class1
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms"), EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class2
	{
		public FormServer formServer_0;
		[ThreadStatic]
		private static Hashtable hashtable_0;
		public FormServer method_0()
		{
			this.formServer_0 = Class1.Class2.smethod_0<FormServer>(this.formServer_0);
			return this.formServer_0;
		}
		public void method_1(FormServer formServer_1)
		{
			if (formServer_1 == this.formServer_0)
			{
				return;
			}
			if (formServer_1 != null)
			{
				throw new ArgumentException("Property can only be set to Nothing");
			}
			this.method_2<FormServer>(ref this.formServer_0);
		}
		[DebuggerHidden]
		private static T smethod_0<T>(T Instance) where T : Form, new()
		{
			if (Instance != null && !Instance.IsDisposed)
			{
				return Instance;
			}
			if (Class1.Class2.hashtable_0 != null)
			{
				if (Class1.Class2.hashtable_0.ContainsKey(typeof(T)))
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
				}
			}
			else
			{
				Class1.Class2.hashtable_0 = new Hashtable();
			}
			Class1.Class2.hashtable_0.Add(typeof(T), null);
			T result;
			try
			{
				try
				{
					result = Activator.CreateInstance<T>();
					return result;
				}
                finally { }
				object arg_73_0;
				TargetInvocationException expr_78 = arg_73_0 as TargetInvocationException;
				int arg_95_0;
				if (expr_78 == null)
				{
					arg_95_0 = 0;
				}
				else
				{
					TargetInvocationException ex = expr_78;
					ProjectData.SetProjectError(expr_78);
					//arg_95_0 = (((ex.InnerException != null) > false) ? 1 : 0);
				}
				//endfilter(arg_95_0);
			}
			finally
			{
				Class1.Class2.hashtable_0.Remove(typeof(T));
			}
			return result;
		}
		[DebuggerHidden]
		private void method_2<T>(ref T gparam_0) where T : Form
		{
			gparam_0.Dispose();
			gparam_0 = default(T);
		}
		[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
		public Class2()
		{
		}
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_3()
		{
			return typeof(Class1.Class2);
		}
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", ""), EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class3
	{
		[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}
		[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
		internal Type method_0()
		{
			return typeof(Class1.Class3);
		}
		[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}
		[DebuggerHidden]
		private static T smethod_0<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return Activator.CreateInstance<T>();
			}
			return instance;
		}
		[DebuggerHidden]
		private void method_1<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}
		[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
		public Class3()
		{
		}
	}
	[EditorBrowsable(EditorBrowsableState.Never), ComVisible(false)]
	internal sealed class Class4<T> where T : new()
	{
		[CompilerGenerated, ThreadStatic]
		private static T gparam_0;
		[DebuggerHidden]
		internal T method_0()
		{
			if (Class1.Class4<T>.gparam_0 == null)
			{
				Class1.Class4<T>.gparam_0 = Activator.CreateInstance<T>();
			}
			return Class1.Class4<T>.gparam_0;
		}
		[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
		public Class4()
		{
		}
	}
	private static readonly Class1.Class4<Class0> class4_0;
	private static readonly Class1.Class4<Form0> byMsRyggR;
	private static readonly Class1.Class4<User> class4_1;
	private static Class1.Class4<Class1.Class2> class4_2;
	private static readonly Class1.Class4<Class1.Class3> class4_3;
	[HelpKeyword("My.Computer")]
	internal static Class0 Class0_0
	{
		[DebuggerHidden]
		get
		{
			return Class1.class4_0.method_0();
		}
	}
	[HelpKeyword("My.Application")]
	internal static Form0 Form0_0
	{
		[DebuggerHidden]
		get
		{
			return Class1.byMsRyggR.method_0();
		}
	}
	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return Class1.class4_1.method_0();
		}
	}
	[HelpKeyword("My.Forms")]
	internal static Class1.Class2 Class2_0
	{
		[DebuggerHidden]
		get
		{
			return Class1.class4_2.method_0();
		}
	}
	[HelpKeyword("My.WebServices")]
	internal static Class1.Class3 Class3_0
	{
		[DebuggerHidden]
		get
		{
			return Class1.class4_3.method_0();
		}
	}
	static Class1()
	{
		Class1.class4_0 = new Class1.Class4<Class0>();
		Class1.byMsRyggR = new Class1.Class4<Form0>();
		Class1.class4_1 = new Class1.Class4<User>();
		Class1.class4_2 = new Class1.Class4<Class1.Class2>();
		Class1.class4_3 = new Class1.Class4<Class1.Class3>();
	}
}
