using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using GalleryGram.Models;
using System.Security.Claims;

namespace GalleryGram.Controllers
{
  public class GalleryController : Controller
  {
    private readonly GalleryGramContext _db;
    private IWebHostEnvironment _hostingEnvironment;
    private readonly UserManager<ApplicationUser> _userManager;
    public GalleryController(GalleryGramContext db, IWebHostEnvironment environment, UserManager<ApplicationUser> userManager)
    {
      _db = db;
      _hostingEnvironment = environment;
      _userManager = userManager;
    }

    public List<Picture> Swap(List<Picture> list, int i, int j)
    {
        var temp = list[i];
        list[i] = list[j];
        list[j] = temp;
        return list;
    }

    public List<Picture> Shuffle(List<Picture> list, Random rnd)
    {
        List<Picture> result = list;
        for(var i=result.Count; i > 0; i--)
        {
          result = Swap(result, 0, rnd.Next(0, i));
        }
        return result;
    }
    
    [HttpGet("/gallery")]
    public ActionResult Index() {
      Random rand = new Random();
      List<Picture> allPictures = _db.Pictures.ToList();
      return View(Shuffle(allPictures, rand));
    }

    [HttpGet("/gallery/upload")]
    public ActionResult Upload() {
      return View();
    }

    [HttpPost("/gallery/upload")]
    public async Task<IActionResult> GalleryUpload(IFormFile formFile)
    {
          string uploads = Path.Combine(_hostingEnvironment.WebRootPath, "pictures");
          Guid fileNameID = Guid.NewGuid();
          string fileExt =  System.IO.Path.GetExtension(formFile.FileName);
          List<string> validExts = new List<string>{".png", ".jpg"};
          if (validExts.Contains(fileExt))
          {
            string fileName = fileNameID.ToString() + fileExt;
            string filePath = Path.Combine(uploads, fileName);
            using (Stream fileStream = new FileStream(filePath, FileMode.Create)) {
                await formFile.CopyToAsync(fileStream);
            }
            Picture newPicture = new Picture();
            newPicture.fileName = "/pictures/" + fileName;
            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            newPicture.user_id = userId;
            _db.Pictures.Add(newPicture);
            _db.SaveChanges();
          }

        return Redirect("/Account/Index");
    }
  }
}