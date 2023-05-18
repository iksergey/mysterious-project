using Mathematics.Exceptions;
using Mathematics.Shapes;
using NUnit.Framework;

namespace MathematicsTest
{
  public class CircleTest
  {
    Circle c;

    [SetUp]
    public void InTest()
    {
      c = Circle.Create(0);
    }

    [TestCase(1)]
    [TestCase(10)]
    public void AreaTest(double r)
    {
      c.Radius = r;
      Assert.That(c.Area, Is.EqualTo(Math.Pow(r, 2) * Math.PI));
    }

    [TestCase(0)]
    public void AreaFailTest(double r)
    {
      c.Radius = r;
      Assert.That(c.Area <= 0, Is.True);
    }

    [TestCase(-1)]
    [TestCase(-100)]
    public void CircleCreateTest(double r)
    {
      Assert.Throws<UnacceptableValueException>(() => c = Circle.Create(r));
    }

    [TearDown]
    public void OutTest()
    {
      c = null;
    }
  }
}