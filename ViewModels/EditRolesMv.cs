using System.Collections.Generic;

namespace Pos.ViewModels
{
    public class EditRolesMv
    {
        public EditRolesMv()
        {
            User=new List<string>();

        }
        public string Id { get; set; }
        public string Name { get; set; }
        public List<string> User{ get; set; }

    }
}