using FluentValidation;
using FluentValidation.Internal;
using System.Linq;

namespace ERP.WebApi.Validation
{
    public abstract class BaseValidator<T> : AbstractValidator<T>
    {
        protected string NOT_EMPTY_ERROR_MESSAGE = "{PropertyName} zorunlu alandır";
        protected string MIN_LENGTH_ERROR_MESSAGE = "{PropertyName} alanı en az {MinLength} karakter olmalıdır";
        protected string MAX_LENGTH_ERROR_MESSAGE = "{PropertyName} alanı en fazla {MaxLength} karakter olabilir";
        protected string NOT_IN_ENUM_ERROR_MESSAGE = "{PropertyName} için girilen değer geçersizdir";
        protected string NOT_VALID_EMAIL_ERROR_MESSAGE = "{PropertyName} için girilen değer, geçerli bir Email adresi değildir";

        private string LENGTH_ERROR_MESSAGE = "{PropertyName} alanı {Length} karakter olmalıdır";
        private string GREATHERTHAN_ERROR_MESSAGE = "{PropertyName} alanı {GreatherThan} değerinden büyük olmalıdır";

        protected const string PLACEHOLDER_LENGTH = "Length";
        protected const string PLACEHOLDER_GREATHERTHAN = "GreatherThan";

        private string FormatMessage(string message, string placeholder, object value)
        {
            var formatter = new MessageFormatter();
            formatter.AppendArgument(placeholder, value);
            return formatter.BuildMessage(message);
        }

        protected string LengthErrorMessage(object value)
        {
            return FormatMessage(LENGTH_ERROR_MESSAGE, PLACEHOLDER_LENGTH, value);
        }

        protected string GreatherThanErrorMessage(object value)
        {
            return FormatMessage(GREATHERTHAN_ERROR_MESSAGE, PLACEHOLDER_GREATHERTHAN, value);
        }

        public string[] ValidateModel(T model)
        {
            var result = Validate(model);
            return result.Errors.Select(x => x.ErrorMessage).ToArray();
        }
    }
}
