using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace TestApp.My
{
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), CompilerGenerated]
	internal sealed class MySettings : ApplicationSettingsBase
	{
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		public static MySettings Default
		{
			get
			{
				return MySettings.defaultInstance;
			}
		}

		[DebuggerNonUserCode]
		public MySettings()
		{
		}
	}
}
