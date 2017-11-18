using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OrderingSystem.Global
{
    class GlobalClass
    {
        public static void CheckMdiChildren(Form form)
        {
            foreach (Form frm in Form1.ActiveForm.MdiChildren)
            {
                if (frm.GetType() == form.GetType())
                {
                    frm.Focus();
                    return;
                }
            }
            form.MdiParent = Form1.ActiveForm;
            form.Location = new Point(198, 0);
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
        }
    }
}

