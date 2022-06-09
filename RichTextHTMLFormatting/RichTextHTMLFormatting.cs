using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NS
{
	public static class Formatting
	{
		/// <summary>
		/// Supports <color> <b> <i> <size>
		/// </summary>
		/// <param name="value">Parameter value to pass.</param>
		/// <returns>Returns a string correctly formatted to HTML.</returns>
		public static string RichTextToHTML(string value)
		{
			//Size
			value = value.Replace("</size>", "[/span]");
			value = value.Replace("<size=", "[span style=\"font-size:");

			//Bold
			value = value.Replace("</b>", "[/span]");
			value = value.Replace("<b>", "[span style=\"font-weight:bold;\"]");

			//Italic
			value = value.Replace("</i>", "[/span]");
			value = value.Replace("<i>", "[span style=\"font-style:italic;\"]");

			//Color
			value = value.Replace("</color>", "[/span]");
			value = value.Replace("<color=", "[span style=\"color:");
			//var regex = new Regex(Regex.Escape(">"));
			//value = regex.Replace(value, ";\">", 1);
			value = value.Replace(">", ";\"]");

			//Revert [] back to <>
			value = value.Replace("[", "<");
			value = value.Replace("]", ">");

			return value;
		}
	}
}