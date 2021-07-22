using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public class ClsUtilities
    {
        public static void Change_ItemColor(ListView lst)
        {
            for(int i =0;i<lst.Items.Count; i++)
            {
                if (i % 2 == 0)
                    lst.Items[i].BackColor = System.Drawing.Color.AliceBlue;
                else
                    lst.Items[i].BackColor = System.Drawing.Color.White;
            }
        }
    }
}
