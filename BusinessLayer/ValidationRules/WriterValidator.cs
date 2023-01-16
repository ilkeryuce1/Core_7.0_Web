using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer> //Hata durumunda bir entity bekler 
    {
        //FluentValidation validition kullanımı
        public WriterValidator()
        {
            //Bunu controller kısmında yerleştirmek için index içinde geçerlilik kontrolü yyapmak gereklidir.       
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Adresi Boş Geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez");
            RuleFor(p => p.WriterMail).Matches(@"[@,.]+").WithMessage("Mail adresi @ ve . icermelidir");//Diyerekmetnin içerisine  aranacak kelieleri kontrol ettik
            RuleFor(p => p.WriterPassword).Matches(@"[A-Z]+").WithMessage("Sifrede en az bir büyük harfden olmalıdır.");
            RuleFor(p => p.WriterPassword).Matches(@"[a-z]+").WithMessage("Sifrede en az bir kicik harfden olmalıdır.");
            RuleFor(p => p.WriterPassword).Matches(@"[0-9]+").WithMessage("Sifrede en az bir rakamdan olmalıdır.");
            RuleFor(p => p.WriterName).MinimumLength(2).WithMessage("En Az 2 Karakter giriniz");
            RuleFor(p => p.WriterName).MaximumLength(50).WithMessage("En Fazla 50 Karakter giriniz");
        }
    }
}
