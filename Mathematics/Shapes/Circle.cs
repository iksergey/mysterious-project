namespace Mathematics.Shapes
{
  public class Circle : Shape
  {
    public static Circle Create(double radius, string name = "Circle")
    {
      if (radius < 0) throw new Exception("radius < 0");
      return new Circle() { Radius = radius, Name = name };
    }
    public double Radius { get; set; }
    public override double Area
    {
      get
      {
        return Math.Pow(Radius, 2) * Math.PI;
      }
    }

    private Circle() { }

    public override string Name { get; set; }
  }
}
