using Core.Models;
using Mathematics.Shapes;

namespace Core.Interfaces
{
  public interface IModel
  {
    Shape AppendCircle();
    Shape AppendTriangle();
    FigureAreaInfo TotalAreaInfo();
    List<FigureAreaInfo> ShowShapes();
    RightTriangleInfo IsRightTriangle(double[] sides);
  }
}