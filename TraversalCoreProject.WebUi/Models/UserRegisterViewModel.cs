using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.WebUi.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Lütfen Adınızı Giriniz")]
        public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Lütfen Görsel urlinizi Giriniz")]
		public string ImageUrl { get; set; }

		[Required(ErrorMessage = "Lütfen Kulanıcı Giriniz")]
		public string Username { get; set; }
		[Required(ErrorMessage = "Lütfen Mail Giriniz")]
		public string Mail { get; set; }
		[Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
		public string Password { get; set; }
		[Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Giriniz")]
		[Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor") ]
		public string ConfirmPassword { get; set; }
	}
}
