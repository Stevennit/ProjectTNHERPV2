using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiver.ViewModels.System.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Tài khoản không được để trống");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Mật khẩu không được để trống")
                .MinimumLength(6).WithMessage("Độ dài mật khẩu phải lơn hơn hoặc bằng 6 ký tự");
        }
    }
}