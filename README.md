# Gramma.Linq
This .NET library offers useful extension methods to collections and specific types.

###Extension methods for collections
* `ArgMaxValue` and `ArgMinValue`: Implementations of the known mathematics functions. They extend a collection of indices of value type `I` and take a function `Func<I, V>` mapping indices to values `V`, which must be comparable, i.e. implementing `IComparable<V>`. They return `I?` which is null if the collection is empty or the index where the value becomes maximum or minimum respectively.
* `ArgMax` and `ArgMin`: Same as above, except that type `I` is a reference type, thus the methods no longer need to return `I?`, they return `I` instead.
* `RandomPickSequence`: These overloads create an infinite collection from an array by picking elements randomly.
* `CycleSequence`: Creates an infinite collection by looping an array.

###Extension methods for Double
* `Squared`: It squares the number.
* `Powered`: It raises the number to a power.

###Extension methods for strings
* `ComputePortableHashCode`: Computes a string hash code which is guaranteed to be stable across AppDomain's, .NET framework versions and 32 or 64 bits flavors.
