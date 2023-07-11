using DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(u => u.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(u => u.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter girişi yapın");
            RuleFor(u => u.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın");

            RuleFor(u => u.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");

            RuleFor(u => u.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            RuleFor(u => u.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz.");

            RuleFor(u => u.UserName).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");

            RuleFor(u => u.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");

            RuleFor(u => u.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez");
            RuleFor(c => c.ConfirmPassword).Equal(p=>p.Password).WithMessage("Parolalarınız eşleşmiyor.");


        }
    }
}
