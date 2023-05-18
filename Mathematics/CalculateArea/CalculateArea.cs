using Mathematics.Shapes;

namespace Mathematics.CalculateArea
{
  public class CalculateArea : ICalculate
  {
    private void Calculate(Shape shape, ref double area)
    {
      area += shape.Area;
      foreach (var item in shape.Shapes)
      {
        Calculate(item, ref area);
      }
    }

    public double Visit(Shape shape)
    {
      double area = 0;
      Calculate(shape, ref area);
      return area;
    }
  }
}