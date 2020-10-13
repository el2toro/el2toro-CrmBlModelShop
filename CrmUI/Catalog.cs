using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUI
{
   public partial class Catalog : Form
   {

        public Catalog()
        {
            DataGridView.DataSource = db.Local.ToBindingList();
        }

    }
}
