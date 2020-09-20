namespace Mimir.Shared.Validator
{
    public static class ErrorMessages
    {
        public const string StringNotEmpty = "You must enter a {PropertyName}";
        public const string StringLength = "Length({TotalLength}) of {PropertyName} is Invalid.  Must be between {MinLength} - {MaxLength}";
    }
}