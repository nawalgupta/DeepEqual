﻿namespace DeepEqual.Test.Syntax
{
	using DeepEqual.Test.Helper;

	using Xunit;

	public class ResultTests
	{
		private object a = new object();
		private object b = new object();

		[Fact]
		public void PassResult()
		{
			var comparison = new EchoComparison(ComparisonResult.Pass);

			DeepAssert.AreEqual(a, b, comparison);
		}

		[Fact]
		public void FailResult()
		{
			var comparison = new EchoComparison(ComparisonResult.Fail);

			DeepAssert.AreNotEqual(a, b, comparison);
		}

		[Fact]
		public void InconclusiveResult()
		{
			var comparison = new EchoComparison(ComparisonResult.Inconclusive);

			DeepAssert.AreEqual(a, b, comparison);
		}
	}
}