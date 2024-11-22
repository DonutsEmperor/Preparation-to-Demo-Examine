using MainApplication.Database.Models;
using System.Net;
using System.Xml.Linq;

namespace UnitTests
{
	[TestClass]
	public sealed class TestClass_StaticFictive_Functions
	{
		[TestMethod]
		public void TestMethod_Multiply()
		{
			var result = MainApplication.MyFunctions.MyFictionFunctions.Multiply(3, 5);
			Assert.AreEqual(15, result);
		}

		[TestMethod]
		public void TestMethod_Divide()
		{
			var result = MainApplication.MyFunctions.MyFictionFunctions.Divide(30, 5);
			Assert.AreEqual(6, result);
		}

		[TestMethod]
		public void TestMethod_Distance()
		{
			var result = MainApplication.MyFunctions.MyFictionFunctions.Distance(new double[] { 1, 1 }, new double[] { 1, 1 });
			Assert.AreEqual(10, result); // fail (correct - 0)
		}

		[TestMethod]
		public void TestMethod_SolveQuadratic()
		{
			var result = MainApplication.MyFunctions.MyFictionFunctions.SolveQuadratic(1, -3, 2);
			Assert.AreEqual(-2, result.root1); // fail (correct - 2)
			Assert.AreEqual(1, result.root2);
		}

		[TestMethod]
		public void TestMethod_GeometricSum()
		{
			double a = 1;
			double r = 0.5;
			int n = 5;
			var expected = a * (1 - Math.Pow(r, n)) / (1 - r);

			var result = MainApplication.MyFunctions.MyFictionFunctions.GeometricSum(a, r, n);
			Assert.AreEqual(expected, result, 0.0001, "The geometric sum calculation is incorrect.");
		}
	}

	[TestClass]
	public sealed class TestClass_StaticReal_Functions
	{
		[TestMethod]
		[DataRow("SophiaM", "zfl-caBp9r94th-")]
		[DataRow("Anybody", "password")]
		public void TestMethod_Authorization(string login, string password)
		{
			bool result = MainApplication.MyFunctions.
				MyRealFunctions.Authorization(login, password);

			Assert.AreEqual(result, true);
		}

		[TestMethod]
		[DataRow("PolovyhNB", "zfl-caBp9r93424th-2", "Nikita Polovykh", "890", "anythere")]
		[DataRow("PolovyhNB", "zfl-caBp9r93424th-2", "Nikita Polovykh", "891", "anythere")] // should be failure bacause second same client
		[DataRow("PolovyhNC", "zfl-caBp9r93424th-2", "Nikita Polovykh", "890", "anythere")] // should be failure bacause second same client
		public void TestMethod_AddClient(string login, string password,
				string fullname, string phone, string address)
		{
			Client clientInfo = new Client
			{
				Login = login,
				Name = fullname,
				Address = address,
				Phone = phone,
				Password = password
			};

			bool result = MainApplication.MyFunctions.
				MyRealFunctions.AddClient(clientInfo);

			Assert.AreEqual(result, true);
		}

		[TestMethod]
		[DataRow("PolovyhNA")]
		[DataRow("891")] // false
		[DataRow("890")]
		public void TestMethod_FindClient(string field)
		{
			Client? client = MainApplication.MyFunctions.
				MyRealFunctions.FindClient(field);

			Assert.IsNotNull(client);
		}
	}
}

