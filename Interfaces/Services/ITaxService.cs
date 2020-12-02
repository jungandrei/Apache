using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Services
{
    interface ITaxService
    {
        //A interface define apenas o contrato
        double Tax(double amount);
    }
}
