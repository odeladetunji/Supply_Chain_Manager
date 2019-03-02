using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Supply_Manager.Controllers
{
    public class AddProductController : Controller
    {
        [HttpPost]
        public ActionResult Index()
        {
            IdentityGenerator identity = new IdentityGenerator();
            ThreadStart aChildThread = new ThreadStart(identity.GetIdentity);
            Thread myThread = new Thread(aChildThread);
            myThread.Start();
            Thread.Sleep(100);
            // identity will be unique since the thread slept for some microseconds!
            var uniqueIdentity = identity.GetTheIdentity();
            return View ();
        }

        [HttpPost()]
        public async Task<IActionResult> Post(List<IFormFile> files)
        {
            //long size = files.Sum(f => f.Length);

            // full path to file in temp location
            var filePath = Path.GetTempFileName();

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok(new { count = files.Count, size, filePath });
        }


        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
    }
}