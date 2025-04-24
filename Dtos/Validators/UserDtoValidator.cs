using DTOs.AccountDtos;
using FluentValidation;

namespace DTOs.Validators
{
    public class UserDtoValidator: AbstractValidator<UserRegistrationDto>
    {
        public UserDtoValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("Lütfen Adınızı giriniz");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("Lütfen Soyadınız giriniz")
                                    .When(u=>!String.IsNullOrWhiteSpace(u.FirstName));
            RuleFor(u => u.UserName).NotEmpty().WithMessage("Lütfen Kullanıcı adınızı giriniz")
                                        .MinimumLength(4).WithMessage("Kullanıcı adı en az 4 karakter olmalıdır")
                                        .When(u => !String.IsNullOrWhiteSpace(u.LastName));
            RuleFor(u => u.Email).NotEmpty().WithMessage("Lütfen mailiniz giriniz")
                                 .EmailAddress().WithMessage("Email Format yanlıştır")
                                 .When(u => !String.IsNullOrWhiteSpace(u.UserName));
            RuleFor(u => u.Password).NotEmpty().WithMessage("Lütfen şifre belirleyin")
                                    .Matches("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[\\W_]).{6,}$")
                                    .WithMessage("Şifre en az 6 karakter, büyük harf, küçük harf, rakam ve özel karakter içermelidir.")
                                    .When(u => !String.IsNullOrWhiteSpace(u.Email));
            RuleFor(u => u.ConfirmPassword).Custom((confirmPassword, context) =>
                                            {
                                                var password = context.InstanceToValidate.Password;

                                                // Ne valide que si le password est déjà valide
                                                var passwordValidator = new InlineValidator<string>();
                                                passwordValidator.RuleFor(u => u)
                                                    .NotEmpty()
                                                    .Matches("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[\\W_]).{6,}$");

                                                if (password == null)
                                                    return;
                                                var result = passwordValidator.Validate(password);

                                                if (!result.IsValid)
                                                {
                                                    // Password non valide → ne pas valider ConfirmPassword
                                                    return;
                                                }

                                                if (string.IsNullOrWhiteSpace(confirmPassword))
                                                {
                                                    context.AddFailure("ConfirmPassword", "Lütfen şifreyi tekrar giriniz");
                                                }
                                                else if (confirmPassword != password)
                                                {
                                                    context.AddFailure("ConfirmPassword", "Şifreler uyumlu değiller");
                                                }
            });






        }
    }
    public class UserLoginDtoValidator : AbstractValidator<UserLoginDto>
    {
        public UserLoginDtoValidator()
        {
            RuleFor(u => u.UserName).NotEmpty()
                .WithMessage("Lütfen Kullanıcı Adınız giriniz");
            RuleFor(u => u.Password).NotEmpty()
                .WithMessage("Lütfen Şifreninz giriniz")
                .When(u=>!String.IsNullOrWhiteSpace(u.UserName));

        }
    }

}
