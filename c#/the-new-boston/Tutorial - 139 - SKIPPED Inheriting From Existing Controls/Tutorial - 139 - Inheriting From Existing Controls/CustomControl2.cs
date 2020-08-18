using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// make sure to add custom control then click view code blue text which is impossible to see well done microsoft
namespace Tutorial___139___Inheriting_From_Existing_Controls
{
    public partial class CustomControl2 : Control
    {
        public CustomControl2()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
