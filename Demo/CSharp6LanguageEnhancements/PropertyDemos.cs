using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using static System.Math;

namespace CSharp6LanguageEnhancements
{
	public class CSharp6CodeDemos
	{
		#region Properties

		//OLD
		public int X { get; set; }
		public int Y { get; set; }

		//NEW - Get Only Auto Properties
		public int X1 { get; }
		public int Y1 { get; }

		//NEW - Initialize Auto Properties
		public int X2 { get; set; } = 5;
		public int Y2 { get; set; } = 7;

		#endregion

		#region String.Format

		//OLD - String.Format
		public string StringFormatOld()
		{
			return String.Format("{0}, {1}", X2, Y2);
		}

		//NEW - String.Format
		public string StringFormatNew()
		{
			return String.Format($"{X2}, {Y2}");
		}

		#endregion

		#region ToString()

		public string ToStringOld()
		{
			return $"{X2}, {Y2}";
		}

		public string ToStringNew() => $"{X2}, {Y2}";

		#endregion

		#region Static Class using Statements

		public double DistOld
		{
			get { return Math.Sqrt(X2*X2 + Y2*Y2); }
		}

		public double DistNew => Sqrt(X2*X2 + Y2*Y2);

		#endregion

		#region Object Initalizers including indices

		public JObject ToJsonOld()
		{
			var result = new JObject();
			result["x"] = X2;
			result["y"] = Y2;
			return result;
		}

		public JObject ToJsonNew() => new JObject() {["x"] = X2, ["y"] = Y2};

		#endregion

		#region Null Check Enhancements

		public Point FromJsonOld(JObject json)
		{
			if (json != null &&
			    json["x"] != null &&
			    json["x"].Type == JTokenType.Integer &&
			    json["y"] != null &&
			    json["y"].Type == JTokenType.Integer)
			{
				return new Point((int) json["x"], (int) json["y"]);
			}

			throw new ArgumentNullException("json");
		}

		public Point FromJsonNew(JObject json)
		{
			// ? does null check
			// 2nd ? for json is not needed
			if (json?["x"]?.Type == JTokenType.Integer &&
			    json?["y"]?.Type == JTokenType.Integer)
			{
				return new Point((int) json["x"], (int) json["y"]);
			}

			//No Longer do you need to hard code the string
			throw new ArgumentNullException(nameof(json));
		}

		#endregion

		public async Task<string> CallWebSiteOld(string webSite)
		{
			string success = "false";

			try
			{
				var client = new HttpClient { BaseAddress = new Uri(webSite) };
				HttpResponseMessage response = await client.GetAsync("api/products/1");
				success = "true";
			}
			catch (HttpRequestException e)
			{
				if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
				{
					Log(e);
				}
			}
			finally
			{
				LogGenericError();
			}
			return success;
		}

		public async Task<string> CallWebSiteNewWithAsyncExceptions(string webSite)
		{
			string success = "false";

			try
			{
				var client = new HttpClient();
				client.BaseAddress = new Uri(webSite);
				HttpResponseMessage response = await client.GetAsync("api/products/1");
				success = "true";
			}
			// can put filter expressions in the catch clause
			catch (HttpRequestException e) when (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
			{
				//Can do async now in catch and finally blocks
				await LogAsync(e);
			}
			finally
			{
				await LogGenericErrorAsync();
			}
			return success;
		}
		private void Log(HttpRequestException e)
		{
			throw new HttpRequestException();
		}

		private void LogGenericError()
		{
			throw new Exception();
		}

		private Task LogAsync(HttpRequestException e)
		{
			throw new HttpRequestException();
		}

		private Task LogGenericErrorAsync()
		{
			throw new Exception();
		}

	}
}