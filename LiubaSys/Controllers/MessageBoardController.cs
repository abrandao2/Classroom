using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LiubaSys.Models;
using LiubaSys.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LiubaSys.Controllers
{
    [Authorize]
    public class MessageBoardController : Controller
    {
        private AppDbContext database;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IHostingEnvironment hostingEnvironment;

        public MessageBoardController(AppDbContext context, 
                                      UserManager<ApplicationUser> userManager,
                                      IHostingEnvironment hostingEnvironment)
        {
            database = context;
            this.userManager = userManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() =>
            userManager.GetUserAsync(HttpContext.User);

        public IActionResult Index()
        {
            return View(database.MessagesPublished);
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(SendMessageModel model)
        {
            var currentUser = await GetCurrentUserAsync();

            if (ModelState.IsValid)
            {
                MessageSent message = new MessageSent()
                {
                    Subject = model.Subject,
                    Content = model.Content,
                    DateSent = DateTime.Now,
                    Student = currentUser
                };

                database.Add(message);
                database.SaveChanges();

                return View("SendMessageResult", model);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "It wasn't possible to send your message.");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult PublishMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PublishMessage(PublishMessageViewModel model)
        {
            var currentUser = await GetCurrentUserAsync();

            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                if (model.File1 != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Files");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.File1.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    model.File1.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                MessagePublished message = new MessagePublished
                {
                    Content = model.Content,
                    DatePublished = DateTime.Now,
                    YoutubeLink1 = model.YoutubeLink1,
                    File1 = uniqueFileName,
                    User = currentUser
                };

                database.Add(message);
                database.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "It wasn't possible to send your message.");
            }

            return View(model);
        }
    }
}