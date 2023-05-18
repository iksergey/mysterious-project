using Mathematics.Exceptions;

namespace Mathematics.Shapes
{
  public interface ITriangleBuilder
  {
    Triangle Build();
    TriangleBuilder SetA(double side);
    TriangleBuilder SetB(double side);
    TriangleBuilder SetC(double side);
  }

  public class TriangleBuilder : ITriangleBuilder
  {
    Triangle triangle;
    public TriangleBuilder(string name) => triangle = new Triangle() { Name = name };
    private double CheckValue(double side)
    {
      if (side <= 0) throw new UnacceptableValueException("Сторона меньше нуля");
      return side;
    }

    public TriangleBuilder SetA(double side)
    {
      triangle.A = CheckValue(side);
      return this;
    }

    public TriangleBuilder SetB(double side)
    {
      triangle.B = CheckValue(side);
      return this;
    }

    public TriangleBuilder SetC(double side)
    {
      triangle.C = CheckValue(side);
      return this;
    }

    public Triangle Build()
    {
      var a = triangle.A;
      var b = triangle.B;
      var c = triangle.C;
      if (!(a + b > c && b + c > a && c + a > b))
        throw new BuildFigureException("С фигурой что-то не так");
      return triangle;
    }
  }
}