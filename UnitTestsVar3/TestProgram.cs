namespace UnitTestsVar3
{
	[TestClass]
	public sealed class TestProgram
	{
		[TestMethod]
		public void TestMethodMultiply()
		{
			var result = DemoExam.FictionFunctions.MyFunctions.Multiply(3, 5);
			Assert.AreEqual(15, result);
		}

		[TestMethod]
		public void TestMethodDivide()
		{
			var result = DemoExam.FictionFunctions.MyFunctions.Divide(30, 5);
			Assert.AreEqual(6, result);
		}

		[TestMethod]
		public void TestMethodDistance()
		{
			var result = DemoExam.FictionFunctions.MyFunctions.Distance(new double[] { 1, 1 }, new double[] { 1, 1 });
			Assert.AreEqual(10, result); //fail (correct - 0)
		}

		[TestMethod]
		public void TestMethodSolveQuadratic()
		{
			var result = DemoExam.FictionFunctions.MyFunctions.SolveQuadratic(1, -3, 2);
			Assert.AreEqual(-2, result.root1); //fail (correct - 2)
			Assert.AreEqual(1, result.root2);
		}

		[TestMethod]
		public void TestMethodGeometricSum()
		{
			double a = 1;
			double r = 0.5;
			int n = 5;
			var expected = a * (1 - Math.Pow(r, n)) / (1 - r);

			var result = DemoExam.FictionFunctions.MyFunctions.GeometricSum(a, r, n);
			Assert.AreEqual(expected, result, 0.0001, "The geometric sum calculation is incorrect.");
		}
	}
}
