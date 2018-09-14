using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Net;

namespace ConsultaRNC
{
	public class Client
	{
		private string m_App_Key;

		private string ServiceUrl;

		public Client(string APP_KEY)
		{
			this.m_App_Key = "";
			this.ServiceUrl = "http://public-apis.sacsoftware.net/rnc";
			this.m_App_Key = APP_KEY;
		}

		public Contribuyente GetContribuyente(string RNC)
		{
			Contribuyente result;
			try
			{
				WebClient webClient = new WebClient();
				try
				{
					string text = webClient.DownloadString(string.Format("{0}?q={1}&APP_KEY={2}", this.ServiceUrl, RNC, this.m_App_Key));
					Debug.WriteLine(text);
					bool flag = Operators.CompareString(text, "", false) != 0;
					if (flag)
					{
						Contribuyente contribuyente = new Contribuyente();
						Contribuyente contribuyente2 = contribuyente;
						contribuyente2.RNC = RNC;
						contribuyente2.Nombre = Helper.GetJSONValue(text, "Nombre");
						contribuyente2.NombreComercial = Helper.GetJSONValue(text, "NombreComercial");
						contribuyente2.Fecha = Helper.GetJSONValue(text, "Fecha");
						contribuyente2.Estatus = Helper.GetJSONValue(text, "Estatus");
						contribuyente2.Categoria = Helper.GetJSONValue(text, "Categoria");
						contribuyente2.Direccion = Helper.GetJSONValue(text, "Direccion");
						contribuyente2.Sector = Helper.GetJSONValue(text, "Sector");
						contribuyente2.CasaNo = Helper.GetJSONValue(text, "CasaNo");
						contribuyente2.Celular = Helper.GetJSONValue(text, "Celular");
						contribuyente2.Nivel = Helper.GetJSONValue(text, "Nivel");
						result = contribuyente;
					}
				}
				finally
				{
					bool flag = webClient != null;
					if (flag)
					{
						((IDisposable)webClient).Dispose();
					}
				}
			}
			catch (Exception expr_132)
			{
				ProjectData.SetProjectError(expr_132);
				Exception ex = expr_132;
				Debug.WriteLine(ex.Message);
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}
}
