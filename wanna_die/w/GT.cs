using System;
using System.IO;
using System.Net;

namespace w
{
	// Token: 0x02000002 RID: 2
	internal class GT
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static string get(string url)
		{
			string result;
			try
			{
				WebResponse response = WebRequest.Create(url).GetResponse();
				StreamReader streamReader = new StreamReader(response.GetResponseStream());
				string text = streamReader.ReadToEnd();
				Console.WriteLine(text);
				streamReader.Close();
				response.Close();
				result = text;
			}
			catch (Exception ex)
			{
				result = "Error: " + ex.Message;
			}
			return result;
		}
	}
}
