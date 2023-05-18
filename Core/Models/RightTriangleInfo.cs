namespace Core.Models
{
  public class RightTriangleInfo
  {
    public double[] Sides { get; set; }
    public bool IsRightTriangle { get; set; }
    public string TextException { get; set; } = String.Empty;
  }
}