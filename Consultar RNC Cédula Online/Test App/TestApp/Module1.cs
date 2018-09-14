using ConsultaRNC;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace TestApp
{
	[StandardModule]
	internal sealed class Module1
	{
		[STAThread]
		public static void Main()
		{
			while (true)
			{
				Console.WriteLine("Introduzca el RNC o presione Enter para salir:");
				string text = Console.ReadLine();
				bool flag = Operators.CompareString(text, "", false) == 0;
				if (flag)
				{
					break;
				}
				Client client = new Client("E64A5CF5E9B44844A4F842AB7EC7F164");
				Contribuyente contribuyente = client.GetContribuyente(text);
				flag = (contribuyente == null);
				if (flag)
				{
					Console.WriteLine("No Encontrado");
				}
				else
				{
					Console.WriteLine(contribuyente.Nombre);
				}
			}
		}
	}
}
