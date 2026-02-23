using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIGlobalUse
{
    public class DangerButton: BaseButton
    {
        public DangerButton()
        {
            ConfigureColors(
                Color.FromArgb(231, 76, 60),
                Color.FromArgb(192, 57, 43),
                Color.FromArgb(146, 43, 33));
        }
    }
}
