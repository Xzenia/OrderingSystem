using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Admin.Global
{
    class GlobalClass
    {
        public static void CheckMdiChildren(Form form)
        {
            foreach (Form frm in AdminMain.ActiveForm.MdiChildren)
            {
                if (frm.GetType() == form.GetType())
                {
                    frm.Focus();
                    return;
                }
            }
            form.MdiParent = AdminMain.ActiveForm;
            form.Location = new Point(198, 0);
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
        }
    }
}

