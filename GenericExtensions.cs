using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grammophone.Linq
{
	/// <summary>
	/// Generic Extension methods.
	/// </summary>
	public static class GenericExtensions
	{
		/// <summary>
		/// Implements the argmax mathematics operator, which finds the reference-type element whose function
		/// evaluation attains its maximum.
		/// </summary>
		/// <typeparam name="I">The type of elements. Must be a reference type.</typeparam>
		/// <typeparam name="V">The type of values being compared.</typeparam>
		/// <param name="collection">A non-empty collection of indices.</param>
		/// <param name="valueFunction">A function mapping an element to a value.</param>
		/// <returns>
		/// Returns the element where the function becomes maximum or null if the <paramref name="collection"/>
		/// is empty.
		/// </returns>
		public static I ArgMax<I, V>(this IEnumerable<I> collection, Func<I, V> valueFunction)
			where I : class
			where V : IComparable<V>
		{
			V maxValue = default(V);
			I maxValueItem = null;

			bool hasEncounteredAtLeastOneElement = false;

			foreach (var item in collection)
			{
				if (!hasEncounteredAtLeastOneElement)
				{
					maxValue = valueFunction(item);
					maxValueItem = item;
					hasEncounteredAtLeastOneElement = true;
				}
				else
				{
					V value = valueFunction(item);

					if (value.CompareTo(maxValue) > 0)
					{
						maxValue = value;
						maxValueItem = item;
					}
				}
			}

			return maxValueItem;
		}

		/// <summary>
		/// Implements the argmax mathematics operator, which finds the value-type element whose function
		/// evaluation attains its maximum.
		/// </summary>
		/// <typeparam name="I">The type of elements. Must be a value type.</typeparam>
		/// <typeparam name="V">The type of values being compared.</typeparam>
		/// <param name="collection">A non-empty collection of indices.</param>
		/// <param name="valueFunction">A function mapping an element to a value.</param>
		/// <returns>
		/// Returns the element where the function becomes maximum or null if the <paramref name="collection"/>
		/// is empty.
		/// </returns>
		public static I? ArgMaxValue<I, V>(this IEnumerable<I> collection, Func<I, V> valueFunction)
			where I : struct
			where V : IComparable<V>
		{
			V maxValue = default(V);
			I maxValueItem = default(I);

			bool hasEncounteredAtLeastOneElement = false;

			foreach (var item in collection)
			{
				if (!hasEncounteredAtLeastOneElement)
				{
					maxValue = valueFunction(item);
					maxValueItem = item;
					hasEncounteredAtLeastOneElement = true;
				}
				else
				{
					V value = valueFunction(item);

					if (value.CompareTo(maxValue) > 0)
					{
						maxValue = value;
						maxValueItem = item;
					}
				}
			}

			if (!hasEncounteredAtLeastOneElement) return null;

			return maxValueItem;
		}

		/// <summary>
		/// Implements the argmin mathematics operator, which finds the reference-type element whose function
		/// evaluation attains its minimum.
		/// </summary>
		/// <typeparam name="I">The type of elements. Must be a reference type.</typeparam>
		/// <typeparam name="V">The type of values being compared.</typeparam>
		/// <param name="collection">A non-empty collection of indices.</param>
		/// <param name="valueFunction">A function mapping an element to a value.</param>
		/// <returns>
		/// Returns the element where the function becomes minimum or null if the <paramref name="collection"/>
		/// is empty.
		/// </returns>
		public static I ArgMin<I, V>(this IEnumerable<I> collection, Func<I, V> valueFunction)
			where I : class
			where V : IComparable<V>
		{
			V minValue = default(V);
			I minValueItem = null;

			bool hasEncounteredAtLeastOneElement = false;

			foreach (var item in collection)
			{
				if (!hasEncounteredAtLeastOneElement)
				{
					minValue = valueFunction(item);
					minValueItem = item;
					hasEncounteredAtLeastOneElement = true;
				}
				else
				{
					V value = valueFunction(item);

					if (value.CompareTo(minValue) < 0)
					{
						minValue = value;
						minValueItem = item;
					}
				}
			}

			return minValueItem;
		}

		/// <summary>
		/// Implements the argmax mathematics operator, which finds the value-type element whose function
		/// evaluation attains its maximum.
		/// </summary>
		/// <typeparam name="I">The type of elements. Must be a value type.</typeparam>
		/// <typeparam name="V">The type of values being compared.</typeparam>
		/// <param name="collection">A non-empty collection of indices.</param>
		/// <param name="valueFunction">A function mapping an element to a value.</param>
		/// <returns>
		/// Returns the element where the function becomes maximum or null if the <paramref name="collection"/>
		/// is empty.
		/// </returns>
		public static I? ArgMinValue<I, V>(this IEnumerable<I> collection, Func<I, V> valueFunction)
			where I : struct
			where V : IComparable<V>
		{
			V minValue = default(V);
			I minValueItem = default(I);

			bool hasEncounteredAtLeastOneElement = false;

			foreach (var item in collection)
			{
				if (!hasEncounteredAtLeastOneElement)
				{
					minValue = valueFunction(item);
					minValueItem = item;
					hasEncounteredAtLeastOneElement = true;
				}
				else
				{
					V value = valueFunction(item);

					if (value.CompareTo(minValue) < 0)
					{
						minValue = value;
						minValueItem = item;
					}
				}
			}

			if (!hasEncounteredAtLeastOneElement) return null;

			return minValueItem;
		}

	}
}
