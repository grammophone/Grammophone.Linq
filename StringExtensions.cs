using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gramma.Linq
{
	/// <summary>
	/// Extension methods for strings.
	/// </summary>
	public static class StringExtensions
	{
		/// <summary>
		/// Computes a string hash code which is guaranteed to be stable 
		/// accross AppDomain's, .NET framework versions and 32 or 64 bits flavors.
		/// </summary>
		/// <remarks>
		/// It ises bernstein's djb2 algorithm.
		/// </remarks>
		/// <param name="text">The text to compute the hash value from.</param>
		/// <returns>Returns the hash value.</returns>
		public static int ComputePortableHashCode(this string text)
		{
			if (text == null) throw new ArgumentNullException("text");

			int hash = 5381;

			for (int i = 0; i < text.Length; i++)
			{
				hash = ((hash << 5) + hash) + text[i]; /* = hash * 33 + c */
			}

			return hash;
		}
	}
}
