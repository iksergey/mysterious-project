using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class MathController : BaseController
{
  private readonly IModel model;

  public MathController(IModel model) => this.model = model;

  [HttpGet("AppendCircle")]
  public ActionResult AppendCircle() => Ok(model.AppendCircle());

  [HttpGet("AppendTriangle")]
  public ActionResult AppendTriangle() => Ok(model.AppendTriangle());

  [HttpPost("IsRightTriangle")]
  public ActionResult IsRightTriangle(double[] sides) =>
    sides.Length != 3
    ? BadRequest("Неверное количество сторон")
    : Ok(model.IsRightTriangle(sides));
}