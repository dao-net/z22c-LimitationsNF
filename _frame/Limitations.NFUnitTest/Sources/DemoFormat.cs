namespace Limitations.NFUnitTest.Sources
{
	using nanoFramework.TestFramework;

	[TestClass]
	public class DemoFormat
	{
		[TestMethod]
		public void Leading0s()
		{
			int i = 2;
			Assert.Equal("000", $"{i:000}"); // desired would be "002"
			Assert.Equal("002", $"{i.ToString().PadLeft(3, '0')}"); // workaround

			double d = 3.14;
			Assert.Equal("00", $"{d:00}"); // desired would be "003"
			Assert.Equal("03", $"{((int)d).ToString().PadLeft(2, '0')}"); // workaround
		}
	}
}
