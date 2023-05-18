namespace Mathematics.Shapes
{
  public abstract class Shape
  {
    public virtual double Area { get; }
    public List<Shape> Shapes => shapes.Value;
    private Lazy<List<Shape>> shapes = new(() => new List<Shape>());
    public virtual string Name { get; set; } = "Shapes";
  }
}