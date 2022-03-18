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
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Bırakamazsınız!");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar Soyadını Boş Bırakamazsınız!");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda alanı Boş Bırakamazsınız!");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Ünvan alanını Boş Bırakamazsınız!");
            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Girişi Yapınız!");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen En Fazla 50 Karakter Girişi Yapınız!");
        }
    }
}
