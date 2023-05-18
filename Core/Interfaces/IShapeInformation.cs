using Core.Models;
using Mathematics.Shapes;

namespace Core.Interfaces
{
  public interface IShapeInformation
  {
    List<FigureAreaInfo> Visit(Shape shape);
  }
}