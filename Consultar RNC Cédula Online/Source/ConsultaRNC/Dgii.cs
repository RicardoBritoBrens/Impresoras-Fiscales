
using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Text;
using HtmlAgilityPack;

namespace ConsultaRNC
{
	internal class Dgii
	{
		[DebuggerNonUserCode]
		public Dgii()
		{
		}

		public static Contribuyente GetContribuyente(string RNC)
		{
			WebClient webClient = new WebClient();
			Contribuyente result;
			try
			{
				byte[] bytes = webClient.UploadValues("http://www.dgii.gov.do/app/WebApps/Consultas/rnc/RncWeb.aspx", "POST", new NameValueCollection
				{
					{
						"__VIEWSTATE",
						"/wEPDwUKMTY4ODczNzk2OA9kFgICAQ9kFgQCAQ8QZGQWAWZkAg0PZBYCAgMPPCsACwBkZHTpAYYQQIXs/JET7TFTjBqu3SYU"
					},
					{
						"__VIEWSTATEGENERATOR",
						"D169D0DF"
					},
					{
						"__EVENTVALIDATION",
						"/wEWBgKl57TuAgKT04WJBAKM04WJBAKDvK/nCAKjwtmSBALGtP74CtBj1Z9nVylTy4C9Okzc2CBMDFcB"
					},
					{
						"__EVENTTARGET",
						""
					},
					{
						"__EVENTARGUMENT",
						""
					},
					{
						"__LASTFOCUS",
						""
					},
					{
						"btnBuscaRncCed",
						"Buscar"
					},
					{
						"rbtnlTipoBusqueda",
						"0"
					},
					{
						"txtRncCed",
						RNC
					}
				});
				string @string = new UTF8Encoding().GetString(bytes);
				HtmlDocument htmlDocument = new HtmlDocument();
				htmlDocument.LoadHtml(@string);
				HtmlNodeCollection htmlNodeCollection = htmlDocument.get_DocumentNode().SelectNodes("//tr[@class='GridItemStyle']");
				bool flag = htmlNodeCollection != null && htmlNodeCollection.get_Count() == 1;
				if (flag)
				{
					Contribuyente contribuyente = new Contribuyente();
					Contribuyente contribuyente2 = contribuyente;
					contribuyente2.RNC = RNC;
					contribuyente2.Nombre = htmlNodeCollection.get_Item(0).SelectNodes(".//td").get_Item(1).get_InnerText().Trim();
					contribuyente2.NombreComercial = htmlNodeCollection.get_Item(0).SelectNodes(".//td").get_Item(2).get_InnerText().Trim();
					contribuyente2.Categoria = htmlNodeCollection.get_Item(0).SelectNodes(".//td").get_Item(3).get_InnerText().Trim();
					contribuyente2.Nivel = htmlNodeCollection.get_Item(0).SelectNodes(".//td").get_Item(4).get_InnerText().Trim();
					contribuyente2.Estatus = htmlNodeCollection.get_Item(0).SelectNodes(".//td").get_Item(5).get_InnerText().Trim();
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
			return result;
		}
	}
}
