using Core.Interfaces;
using Core.Models;
using Mathematics.CalculateArea;
using Mathematics.Shapes;

namespace Core.Infrastructure
{
  public class CalcModel<C, I> : IModel
      where C : ICalculate, new()
      where I : IShapeInformation, new()
  {
    Shape panel;
    C calc;
    I info;
    public CalcModel()
    {
      panel = new Canvas();
      calc = new C();
      info = new I();
    }

    public Shape AppendCircle()
    {
      Circle figure = Circle.Create(radius: Generator.Number);
      panel.Shapes.Add(figure);
      return figure;
    }

    public Shape AppendTriangle()
    {
      Triangle figure =
        Triangle.Create()
                .SetA(Generator.Number)
                .SetB(Generator.Number)
                .SetC(Generator.Number)
                .Build();

      panel.Shapes.Add(figure);
      return figure;
    }

    public FigureAreaInfo TotalAreaInfo()
    {
      return new FigureAreaInfo
      {
        FigureName = "Total",
        FigureArea = calc.Visit(panel)
      };
    }

    public RightTriangleInfo IsRightTriangle(double[] sides)
    {
      var result =
      Triangle.Create()
              .SetA(sides[0])
              .SetB(sides[1])
              .SetC(sides[2])
              .Build()
              .IsRightTriangle;
      return new RightTriangleInfo
      {
        Sides = sides,
        IsRightTriangle = result
      };
    }

    public List<FigureAreaInfo> ShowShapes()
    {
      return info.Visit(panel);
    }
  }
}