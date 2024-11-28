using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProject.DtoLayer.Dtos.ContactDtos;

namespace TraversalCoreProject.BusinessLayer.ValidationRules
{
    public class SendContactUsValidator :AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez!");
            RuleFor(x => x.Mail).EmailAddress();
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Alanı Boş Geçilemez!");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez!");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Konu Alanı Boş Geçilemez!");
            RuleFor(x => x.MessageBody).MaximumLength(250).WithMessage("Konu Alanına En Fazla 250 Karakter Veri Girişi Yapabilirsiniz!");
            RuleFor(x => x.MessageBody).MinimumLength(50).WithMessage("Konu Alanına En Az 50 Karakter Veri Girişi Yapabilirsiniz!");
        }
    }
}
