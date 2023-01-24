using System;
using System.Collections.Generic;

namespace CSharpColletionsParte2.SortedSets
{
	internal class ComparadorMinusculo : IComparer<string>
	{
		public int Compare(string x, string y)
		{
			return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
		}
	}
}