using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class UserValidator: AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x=>x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Boş Bırakılamaz!");
            RuleFor(x => x.UserName).MinimumLength(2).WithMessage("Kullanıcı Adı En Az 2 Harften Oluşmalıdır!");
            RuleFor(x => x.UserName).MaximumLength(10).WithMessage("Kullanıcı Adı En Fazla 10 Harften Oluşmalıdır!");
            RuleFor(x => x.UserSurname).NotEmpty().WithMessage("Kullanıcı Soyadı Boş Bırakılamaz!");
            RuleFor(x => x.UserSurname).MinimumLength(2).WithMessage("Kullanıcı Soyadı En Az 2 Harften Oluşmalıdır!");
            RuleFor(x => x.UserSurname).MaximumLength(15).WithMessage("Kullanıcı Soyadı En Fazla 15 Harften Oluşmalıdır!");
            RuleFor(x => x.UserTitle).NotEmpty().WithMessage("Kullanıcı Unvanı Boş Bırakılamaz!");
        }
    }
}
