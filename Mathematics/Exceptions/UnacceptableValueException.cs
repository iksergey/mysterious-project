namespace Mathematics.Exceptions
{
  public class UnacceptableValueException : MathematicsException
  {
    public UnacceptableValueException(string message)
        : base(message) { }
  }
}