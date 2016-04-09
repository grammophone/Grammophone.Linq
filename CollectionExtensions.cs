using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grammophone.Linq
{
	/// <summary>
	/// Extension methods for arrays and collections in general.
	/// </summary>
	public static class CollectionExtensions
	{
		/// <summary>
		/// Create an infinite sequence of random items picked from 
		/// an array.
		/// </summary>
		/// <typeparam name="T">The type of the items in the array from which items are picked.</typeparam>
		/// <param name="array">The array from which items are picked.</param>
		/// <returns>Returns an infinite sequence with random items picked from the <paramref name="array"/>.</returns>
		public static IEnumerable<T> RandomPickSequence<T>(this T[] array)
		{
			if (array == null) throw new ArgumentNullException("array");

			if (array.Length == 0) yield break;

			var randomGenerator = new Random();

			while (true)
			{
				int index = randomGenerator.Next(array.Length);

				yield return array[index];
			}
		}

		/// <summary>
		/// Create an infinite sequence of random items picked from 
		/// an array.
		/// </summary>
		/// <typeparam name="T">The type of the items in the array from which items are picked.</typeparam>
		/// <param name="array">The array from which items are picked.</param>
		/// <param name="randomSeed">The random generator seed value.</param>
		/// <returns>Returns an infinite sequence with random items picked from the <paramref name="array"/>.</returns>
		public static IEnumerable<T> RandomPickSequence<T>(this T[] array, int randomSeed)
		{
			if (array == null) throw new ArgumentNullException("array");

			if (array.Length == 0) yield break;

			var randomGenerator = new Random(randomSeed);

			while (true)
			{
				int index = randomGenerator.Next(array.Length);

				yield return array[index];
			}
		}

		/// <summary>
		/// Create an infinite sequence by cycling the items of an array.
		/// </summary>
		/// <typeparam name="T">The type of the items in the array.</typeparam>
		/// <param name="array">The elements to be cycled.</param>
		/// <returns>
		/// If the <paramref name="array"/> is not empty, it returns an infinite cycling of its elements, else returns empty sequence.
		/// </returns>
		public static IEnumerable<T> CycleSequence<T>(this T[] array)
		{
			if (array == null) throw new ArgumentNullException("array");

			int length = array.Length;

			if (length == 0) yield break;

			for (int index = 0; ; index = (index + 1) % length)
			{
				yield return array[index];
			}
		}
	}
}
