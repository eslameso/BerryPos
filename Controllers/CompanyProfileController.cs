using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Pos.Data.Classes;
using Pos.Data.Intefaces;
using Pos.Models;
using Pos.ViewModels;

namespace Pos.Controllers
{
    public class CompanyProfileController : Controller
    {
        public IUnitOfWork _uow { get; }
        private readonly IWebHostEnvironment _hosting;
        Utilitise utilitise;
        public CompanyProfileController(IUnitOfWork uow,IWebHostEnvironment hosting)
        {
            _uow = uow;
            _hosting=hosting;
            utilitise =new Utilitise(_hosting);
        }
        public ActionResult Index()
        {
            var Data= _uow.CompanyProfile.GetComapnyData();
            if (Data !=null)
            {         
                if (string.IsNullOrEmpty(Data.CompanyLogo))
            {
                Data.CompanyLogo="DefaultLogo.jpg";
            }
            }
            return View(Data);
        }

        [HttpGet]
        public ActionResult Create()
        {
             return View();
        }
        [HttpPost]
        public ActionResult Create(CreateCompanyProfileMv model)
        {
            if (ModelState.IsValid)
            {
                string FileName=string.Empty;
                 if (model.CompanyLogo !=null)
                {
                    
                    if (utilitise.IsImageUpload(model.CompanyLogo.FileName))
                    {
                        FileName=model.CompanyLogo.FileName;
                        utilitise.UploadImage(FileName,model.CompanyLogo);
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty,"You Can Choose Images Only.");
                        return View(model);
                    }
                   
                 }
                CompanyProfile companyProfile=new CompanyProfile()
                {
                     CompanyName=model.CompanyName,
                    OwnerName=model.OwnerName,
                    ComapanyType=model.ComapanyType,
                    CompanyDescription=model.CompanyDescription,
                    Notes=model.Notes,
                    CompanyLogo=FileName
                    
                };
                
                _uow.CompanyProfile.CreateCompanyProfile(companyProfile);
                _uow.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("","Invalid Create Attempt !");
            }
            return View();
            

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var CP= _uow.CompanyProfile.FindCompanyProfile(id);
            ViewBag.Logo=CP.CompanyLogo;
            EditCompanyProfileMv model =new EditCompanyProfileMv()
            {
                CompanyName=CP.CompanyName,
                OwnerName=CP.OwnerName,
                ComapanyType=CP.ComapanyType,
                CompanyDescription=CP.CompanyDescription,
                Notes=CP.Notes
                 };
            return View(model);

        }
        [HttpPost]
        public IActionResult Edit(EditCompanyProfileMv model)
        {
            if (ModelState.IsValid)
            {
                string FileName=string.Empty;
                string OldFileName=string.Empty;
                if (model.CompanyLogo !=null)
                {
                    
                    if (utilitise.IsImageUpload(model.CompanyLogo.FileName))
                    {
                        FileName=model.CompanyLogo.FileName;
                        OldFileName=_uow.CompanyProfile.FindCompanyProfile(model.Id).CompanyLogo;
                        utilitise.EditImage(FileName,model.CompanyLogo,OldFileName);
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty,"You Can Choose Images Only.");
                        return View(model);
                    }
                   
                 }
                 var companyProfile = _uow.CompanyProfile.FindCompanyProfile(model.Id);
                
                    
                    companyProfile.CompanyName=model.CompanyName;
                    companyProfile.OwnerName=model.OwnerName;
                    companyProfile.ComapanyType=model.ComapanyType;
                    companyProfile.CompanyDescription=model.CompanyDescription;
                    companyProfile.Notes=model.Notes;
                    companyProfile.CompanyLogo=FileName;
                    
                
                _uow.CompanyProfile.EditCompanyProfile(companyProfile);
                _uow.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError(string.Empty,"Ivalid Edit Company rofile Attempt !");
            }
            return View(model);
        }



    }
}