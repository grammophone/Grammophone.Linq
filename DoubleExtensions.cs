using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grammophone.Linq
{
	/// <summary>
	/// Extensions to primitive type Double in order to ease
	/// expressivity and compactness of formulas.
	/// </summary>
	public static class DoubleExtensions
	{
		/// <summary>
		/// Square a number.
		/// </summary>
		public static double Squared(this double number)
		{
			return number * number;
		}

		/// <summary>
		/// Raise a number to a power.
		/// </summary>
		public static double Powered(this double number, double exponent)
		{
			return Math.Pow(number, exponent);
		}
	}
}
