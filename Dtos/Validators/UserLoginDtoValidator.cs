using DTOs.AccountDtos;
using FluentValidation;

namespace DTOs.Validators
{
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
