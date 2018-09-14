using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;

namespace ConsultaRNC
{
	internal class Helper
	{
		[DebuggerNonUserCode]
		public Helper()
		{
		}

		public static string GetJSONValue(string JsonRecord, string Field)
		{
			JsonRecord = JsonRecord.Replace("\",\"", "|").Replace("{", "").Replace("}", "");
			string text = "";
			string[] array = JsonRecord.Split(new char[]
			{
				'|'
			});
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string text2 = array[i];
					string text3 = text2.Replace("\":\"", "|");
					bool flag = Operators.CompareString(text3.Split(new char[]
					{
						'|'
					})[0].Replace("\"", ""), Field, false) == 0 && text3.Split(new char[]
					{
						'|'
					}).Length > 1;
					if (flag)
					{
						text += text3.Split(new char[]
						{
							'|'
						})[1].Replace("\"", "");
					}
				}
				return text;
			}
		}
	}
}
