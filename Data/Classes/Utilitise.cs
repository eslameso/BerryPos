using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Pos.Data.Classes
{
    public class Utilitise
    {
         private readonly IWebHostEnvironment _hosting;

         public Utilitise(IWebHostEnvironment hosting)
         {
           _hosting=hosting;
         }
        //ToDo Function To Check If The File Is Image Or Not
           public bool IsImageUpload(string FileName)
        {
             var supportedTypes = new[] { "JPEG ", "JPG", "PNG","jpeg","jpg","png"};
              var fileExt = Path.GetExtension(FileName).Substring(1);  
                if (supportedTypes.Contains(fileExt))  
                {  
                            return true;
                 }
                 else
                 {
                             return false;
                 }
        }

         public void UploadImage(string FileName,IFormFile Photo)
          {         
                 string Uploads=Path.Combine(_hosting.WebRootPath,"Uploads");
                 string FullPath=Path.Combine(Uploads,FileName);
                 using (var fileStream = new FileStream(FullPath, FileMode.Create))  
                {  
                    Photo.CopyTo(fileStream);  
                } 
          }

       public void EditImage(string FileName,IFormFile Photo,string OldFileName)
       {
           string Uploads=Path.Combine(_hosting.WebRootPath,"Uploads");
                 string FullPath=Path.Combine(Uploads,FileName);
                
                 string FullOldPath=Path.Combine(Uploads,(OldFileName == null ? "" : OldFileName));
                 if (!string.IsNullOrEmpty(OldFileName) && FullPath != FullOldPath)
                 {
                     File.Delete(FullOldPath);
                     
                 }
                
                 using (var fileStream = new FileStream(FullPath, FileMode.Create))  
                {  
                    Photo.CopyTo(fileStream);  
                } 
                 
                

       }

        public enum MeasurmentType
         {
             [Display(Name="Grams")]
             Grams=1,
             [Display(Name="Piece")]
             Piece=2,
             [Display(Name="Centimeter")]
             Centimeter=3,
             [Display(Name="Milliliter")]
             Milliliter=4
         }
        public enum TransformationType
         {
             StoreToStore=1,
             StoreToBranch=2,
             BranchToBranch=3
         }


    }
}