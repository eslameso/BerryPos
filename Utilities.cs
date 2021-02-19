using System.ComponentModel.DataAnnotations;

namespace Pos
{
    public class ValideEmailDomain :ValidationAttribute
    {
        public string AllowedDomain { get; }

        public ValideEmailDomain(string AllowedDomain)
        {
            this.AllowedDomain = AllowedDomain;
            
        }
        public override bool IsValid(object value)
        {
          string [] EmailSplit=value.ToString().Split('@');  
          string DomainPart=  EmailSplit[1];

           return DomainPart.ToUpper() == AllowedDomain.ToUpper();

        }


     

    }
    
}