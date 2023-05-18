using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCustomSystem.Models
{
    public class CstaffManager
    {
        List<Cstaff> _list = new List<Cstaff>();
        int _position = -1;

        public CstaffManager()
        {
            loadData();
        }
        public Cstaff queryByEmail(string email)
        {
            foreach (Cstaff c in _list)
            {
                if (c.email == email)
                    return c;
            }
            return null;
        }
        private void loadData()
        {
            Cstaff x = new Cstaff();
            x.id = "001";
            x.name = "Wndy";
            x.phone = "0911222333";
            x.email = "Wendy@gmail.com";
            x.address = "Taipei";
            x.password = "55688";
            _list.Add(x);

            x = new Cstaff();
            x.id = "002";
            x.name = "Lily";
            x.phone = "0922555888";
            x.email = "Lily@gmail.com";
            x.address = "Taipei";
            x.password = "77899";
            _list.Add(x);

            x = new Cstaff();
            x.id = "009";
            x.name = "Tom";
            x.phone = "0966888222";
            x.email = "Tom@gmail.com";
            x.address = "Taipei";
            x.password = "98765";
            _list.Add(x);
        }
    }
}
