using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName)
                .NotEmpty().WithMessage("Yazar adı soyadı boş geçilemez")
                .MinimumLength(2).WithMessage("Lütfen en az iki karakter giriş yapınız.")
                .MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter giriş yapınız.");

            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");

            RuleFor(x => x.WriterPassword)
                .NotEmpty().WithMessage("Şifre boş geçilemez")
                .Matches("[0-9]").WithMessage("Şifre en az bir sayı içermelidir.")
                .Matches("[A-Z]").WithMessage("Şifre en az bir büyük harf içermelidir.")
                .Matches("[a-z]").WithMessage("Şifre en az bir küçük harf içermelidir.");
        }
    }
}
