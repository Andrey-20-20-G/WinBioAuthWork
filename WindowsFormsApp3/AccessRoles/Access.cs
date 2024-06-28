using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.AccessRoles
{
    public class Access
    {
        public bool Write { get; set; }
        public bool Delete { get; set; }
        public bool Read { get; set; }

        /*public void setAccessWrite(string role)
        {
            if(role == "Admin_Conf" || role == "Admin")
            {
                Write = !Write;
            }
        }*/

        /*public void setAccessDelete(string role)
        {
            if (role == "Admin_Conf")
            {
                Delete = !Delete;
            }
        }*/
    }
}
