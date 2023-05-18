namespace Mathematics.Shapes
{
  public class Triangle : Shape
  {
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public override double Area
    {
      get
      {
        double p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
      }
    }

    public static ITriangleBuilder Create(string name = "Triangle")
    {
      return new TriangleBuilder("Triangle");
    }

    public bool IsRightTriangle
    {
      get
      {
        var sides = new List<double>() { A, B, C };
        sides.Sort();
        return Math.Pow(sides[0], 2)
             + Math.Pow(sides[1], 2)
             == Math.Pow(sides[2], 2);
      }
    }

    public override string Name { get; set; }
  }
}