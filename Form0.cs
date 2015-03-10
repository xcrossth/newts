using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
[GeneratedCode("MyTemplate", "8.0.0.0"), EditorBrowsable(EditorBrowsableState.Never)]
internal class Form0 : WindowsFormsApplicationBase
{
	[EditorBrowsable(EditorBrowsableState.Advanced), DebuggerHidden, STAThread]
	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
		}
		finally
		{
		}
		Class1.Form0_0.Run(args);
	}
	[DebuggerStepThrough]
	public Form0() : base(AuthenticationMode.Windows)
	{
		this.IsSingleInstance = true;
		this.EnableVisualStyles = true;
		this.SaveMySettingsOnExit = true;
		this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
	}
	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		this.MainForm = Class1.Class2_0.method_0();
	}
}
