using Microsoft.VisualStudio.TestTools.UnitTesting;
using wordSearch;

namespace wordSearch.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void IsRepeatCounter_FoundFourYous_True()
    {
      Assert.AreEqual(true, RepeatCounter.returnTest("How are you? I hope to see you soon. I love you and miss you."));
    }
  }
}
