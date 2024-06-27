using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.AccessRoles
{
    public class Access
    {
        public bool Write { get; private set; } = false;
        public bool Delete { get; private set; } = false;
        public bool Read { get; private set; } = true;

        public void setAccessWrite()
        {
            Write = !Write;
        }

        public void setAccessDelete(string role)
        {
            if (role == "Admin_Conf")
            {
                Delete = !Delete;
            }
        }
    }
}
