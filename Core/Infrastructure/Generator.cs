namespace Core.Infrastructure
{
  public class Generator
  {
    public static int Number => Random.Shared.Next(10, 15);
  }
}