using AlmeidaSebastianExamenProgreso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmeidaSebastianExamenProgreso2.Interfaces
{
    public interface ISalmeidaRecarga
    {
        SalmeidaRecarga GetRecarga(string numero);
        bool CreateRecarga(SalmeidaRecarga recarga);
        bool UpdateRecarga(SalmeidaRecarga recarga);
        bool DeleteRecarga(string numero);
    }
}
