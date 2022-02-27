namespace CoreLayer.CrossCuttingConcerns.Validation
{
  using FluentValidation;
  public static class ValidationTool
  {
    public static void Validate(IValidator validator, object entity)
    {
      var context = new ValidationContext<object>(entity);
      var result = validator.Validate(context);
      if (!result.IsValid)
      {
        throw new ValidationException(result.Errors);
      }
    }
  }
}
