using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIGlobalUse
{
    public class PrimaryButton : BaseButton
    {
        public PrimaryButton()
        {
            ConfigureColors(
                Color.FromArgb(52, 152, 219),
                Color.FromArgb(41, 128, 185),
                Color.FromArgb(31, 97, 141));
        }
    }
}
