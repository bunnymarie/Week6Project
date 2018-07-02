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
      Assert.AreEqual(true, RepeatCounter.returnTest1("How are you? I hope to see you soon. I love you and miss you."));
    }
    [TestMethod]
    public void IsRepeatCounter_FoundFourYous_False()
    {
      Assert.AreEqual(false, RepeatCounter.returnTest2("I hope they have a great day."));
    }
  }
}
