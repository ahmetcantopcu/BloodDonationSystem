using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class DonorValidator:AbstractValidator<Donor>
    {
        public DonorValidator()
        {
            RuleFor(x => x.DonorName).NotEmpty().WithMessage("Yazar Adı Soyadı boş geçilemez.");
            RuleFor(x => x.DonorMail).NotEmpty().WithMessage("Mail Adresi boş geçilemez.");
            RuleFor(x => x.DonorPassword).NotEmpty().WithMessage("Şifre boş geçilemez.");
            RuleFor(x => x.DonorPassword).MinimumLength(5).WithMessage("Şifreniz en az 5 karakter olmalıdır.");
            RuleFor(x => x.DonorName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız.");
            RuleFor(x => x.DonorName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız.");

        }
    }
}
