using DTOs.AccountDtos;
using FluentValidation;

namespace DTOs.Validators
{
    public  class UserForUpdateValidator :AbstractValidator<UserForUpdateDto>
    {
        public UserForUpdateValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("Lütfen Adınızı giriniz");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("Lütfen Soyadınız giriniz")
                                    .When(u => !String.IsNullOrWhiteSpace(u.FirstName));
            RuleFor(u => u.Email).NotEmpty().WithMessage("Lütfen mailiniz giriniz")
                                 .EmailAddress().WithMessage("Email Format yanlıştır")
                                 .When(u => !String.IsNullOrWhiteSpace(u.LastName));                         
            RuleFor(u => u.PhoneNumber).NotEmpty().WithMessage("Lütfen Telefon Numaranız giriniz")
                                 .Length(11).WithMessage("Telefon Numara 11 karakter olmalıdır")
                                 .When(u => !String.IsNullOrWhiteSpace(u.Email));
          
            RuleFor(u => u.ImageUrl).NotEmpty().WithMessage("Lütfen resim yükleyin");

            RuleFor(u => u.Password).NotEmpty().WithMessage("Lütfen şifre giriniz");
             


                                 

        }
    }
}
