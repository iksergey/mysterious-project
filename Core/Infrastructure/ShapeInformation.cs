using Core.Interfaces;
using Core.Models;
using Mathematics.Shapes;

namespace Core.Infrastructure
{
  public class ShapeInformation : IShapeInformation
  {
    private void GitInfo(List<Shape> shapes, List<FigureAreaInfo> result)
    {
      foreach (var item in shapes)
      {
        result.Add(new FigureAreaInfo
        {
          FigureName = item.Name,
          FigureArea = item.Area
        });
        GitInfo(item.Shapes, result);
      }
    }

    public List<FigureAreaInfo> Visit(Shape shape)
    {
      List<FigureAreaInfo> list = new();
      GitInfo(shape.Shapes, list);
      return list;
    }
  }
}