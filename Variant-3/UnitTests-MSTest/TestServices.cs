using MainApplication.Database.Models;
using MainApplication.Database;
using MainApplication.MyFunctions;
using MainApplication.Services.Interface;

namespace UnitTests
{
	[TestClass]
	public sealed class TestServices
	{
		private readonly IDbWorker _service;

		public TestServices() 
		{
			_service = new DbWorker(new AppDbContext());
		}

		[TestMethod]
		public void TestMethod_DbWorkerInitialization()
		{
			Assert.IsNotNull(_service);
		}

		[TestMethod]
		public void TestMethod_DbWorkerTables()
		{
			Assert.IsNotNull(_service.Animals);
			Assert.IsNotNull(_service.Clients);
			Assert.IsNotNull(_service.Orders);
			Assert.IsNotNull(_service.Favorites);
			Assert.IsNotNull(_service.Brands);
			Assert.IsNotNull(_service.Categories);
			Assert.IsNotNull(_service.Compounds);
			Assert.IsNotNull(_service.Products);
		}
	}
}
