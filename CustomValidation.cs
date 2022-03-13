using System.ComponentModel.DataAnnotations;

namespace Pos
{
    //Here We Do Classes For Custom Validation

    //ToDo Validate That Domain Name Is (--- Come From The Register DataAnnotation Of Email Property)
    public class ValideEmailDomain :ValidationAttribute
    {
        public string AllowedDomain { get; }

        public ValideEmailDomain(string AllowedDomain)
        {
            this.AllowedDomain = AllowedDomain;
            
        } 
        public override bool IsValid(object value)
        {
            //ToDo Split The Email To Two Part
          string [] EmailSplit=value.ToString().Split('@');  
          //ToDo Get The Domain Part
          string DomainPart=  EmailSplit[1];

           //ToDo Return True If Equal And False If Not
           return DomainPart.ToUpper() == AllowedDomain.ToUpper();

        }


     

    }
    
}