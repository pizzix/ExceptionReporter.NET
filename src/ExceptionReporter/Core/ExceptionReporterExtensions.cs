using System.Text;

namespace System.Runtime.CompilerServices
{
	// ReSharper disable UnusedMember.Global
	/// <summary>
	/// a hack (?) to ensure that we can use Extension Methods and still target .NET2
	/// see http://www.danielmoth.com/Blog/2007/05/using-extension-methods-in-fx-20.html
	/// </summary>
	public class ExtensionAttribute : Attribute { }
}
// ReSharper restore UnusedMember.Global

namespace ExceptionReporting.Extensions
{
	/// <summary>
	/// All extension methods for ExceptionReporter
	/// </summary>
	public static class ExceptionReporterExtensions
	{
		/// <summary>
		/// Append a dotted line to the given string
		/// </summary>
		public static StringBuilder AppendDottedLine(this StringBuilder stringBuilder)
		{
			return stringBuilder.AppendLine("-----------------------------");
		}

		/// <summary>
		/// Return a string if not null, else the current value
		/// </summary>
		public static string GetString(this string newString, string currentString)
		{
			return string.IsNullOrEmpty(newString) ? currentString : newString.Trim();
		}

		/// <summary>
		/// Returns the boolean value of configString; where configString is null or empty, the current value is returned
		/// <remarks>all of (case insensitive) 'y' 'n' 'true' or 'false' are accepted as boolean indicators</remarks>
		/// </summary>
		public static bool GetBool(this string configString, bool currentValue)
		{
			if (string.IsNullOrEmpty(configString)) return currentValue;

			switch (configString.ToLower())
			{
				case "y" : 
				case "true": 
					return true;

				case "n" :
				case "false" : 
					return false;
			}

			return currentValue;
		}
	}
}