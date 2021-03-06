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
    [TestMethod]
    public void IsRepeatCounter_FoundFiveeAenean_False()
    {
      Assert.AreEqual(false, RepeatCounter.returnTest3("Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus."));
    }
    [TestMethod]
    public void IsRepeatCounter_FoundOneLorem_True()
    {
      Assert.AreEqual(true, RepeatCounter.returnTest4("Lorem ipsum dolor sit amet, consectetuer adipiscing elit."));
    }
    [TestMethod]
    public void IsRepeatCounter_FoundThreeYous_True()
    {
      Assert.AreEqual(true, RepeatCounter.returnTest5("Taking care of yourself? I hope to see you soon. I love you and miss you."));
    }
  }
}
