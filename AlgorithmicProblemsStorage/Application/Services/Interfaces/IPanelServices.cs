using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicProblemsStorage.Application.Services.Interfaces
{
    public interface IPanelServices
    {
        void Initialize(Panel hostPanel);
        void ShowScreen(Control screen);
    }
}
