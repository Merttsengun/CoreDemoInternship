using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using FluentValidation.Results;
using CoreDemo.Models;
using System.IO;
using System;
using DataAccessLayer.Concrete;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{

	public class WriterController : Controller
    {
        UserManager userManager = new UserManager(new EfUserRepository());

        WriterManager wm = new WriterManager(new EfWriterRepository());

		private readonly UserManager<AppUser> _userManager;

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [Authorize]
		public IActionResult Index()
		{
			var usermail =User.Identity.Name;
			ViewBag.v=usermail;
			Context c = new Context();
			var writerName = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterName).FirstOrDefault();
			ViewBag.v2= writerName;	
			
			return View();
		}
		public IActionResult WriterProfile()
		{
			return View();
		}

		public IActionResult WriterMail()
		{
			return View();
		}
		public IActionResult Test()
		{
			return View();
		}
		public PartialViewResult WriterNavbarPartial()
		{
			return PartialView();
		}
		public PartialViewResult WriterFooterPartial()
		{
			return PartialView();
		}
		[HttpGet]
		public async Task<IActionResult>  WriterEditProfile()
		{
			//Context context = new Context();
			//var username=User.Identity.Name;
			//var usermail = context.Users.Where(x=>x.UserName==username).Select(y => y.Email ).FirstOrDefault();
			//var id = context.Users.Where(x=>x.Email==usermail).Select(y => y.Id).FirstOrDefault();
			//var values = userManager.TGetById(id);
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			UserUpdateViewModel model = new UserUpdateViewModel();
			model.mail=values.Email;
			model.namesurname=values.NameSurname;
			model.imageurl=values.ImageUrl;
			model.username=values.UserName;
            var username = User.Identity.Name;
            ViewBag.Name = username;
            return View(model);
		}
		[HttpPost]
		public async Task<IActionResult> WriterEditProfile(UserUpdateViewModel model)
		{
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            // Kullanıcı adı varsa güncelle
            if (!string.IsNullOrEmpty(model.username))
            {
                values.UserName = model.username;
            }

            // Diğer kullanıcı bilgilerini güncelle
            values.NameSurname = model.namesurname;
            values.Email = model.mail;
            values.ImageUrl = model.imageurl;

            // Şifre varsa güncelle
            if (!string.IsNullOrEmpty(model.password))
            {
                // Şifre hash'ini oluştur ve güncelle
                values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, model.password);
            }

            // Kullanıcıyı güncelle
            var result = await _userManager.UpdateAsync(values);

            // Güncelleme başarılıysa yönlendir
            if (result.Succeeded)
            {
				
                return RedirectToAction("Index", "Login");
            }

            // Hata mesajları varsa ekle
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            // Modeli view'a geri döndür
            return View(model);



            //var values = await _userManager.FindByNameAsync(User.Identity.Name);
            //values.NameSurname = model.namesurname;
            //         values.ImageUrl = model.imageurl;
            //         values.Email = model.mail;
            //values.PasswordHash= _userManager.PasswordHasher.HashPassword(values ,model.password);
            //var result = await _userManager.UpdateAsync(values);
            //         return RedirectToAction("Index", "Dashboard");
        }
	

		
		[HttpGet]
        public IActionResult WriterAdd()
		{

		return View(); 
		}
		[HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
		{
			Writer w = new Writer();
			if (p.WriterImage != null) 
			{ 
				var extension = Path.GetExtension(p.WriterImage.FileName);
				var newimagename=Guid.NewGuid()+extension;
				var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newimagename);
				var stream = new FileStream(location, FileMode.Create);
				p.WriterImage.CopyTo(stream);
				w.WriterImage=newimagename;

			}
			w.WriterMail=p.WriterMail;
			w.WriterName=p.WriterName;
			w.WriterPassword=p.WriterPassword;
			w.WriterStatus = true;
			w.WriterAbout=p.WriterAbout;
			wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard"); ;
		}
	}
}