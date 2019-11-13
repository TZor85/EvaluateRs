using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvaluateRs.Data.Residentes
{
    interface IResidentesService
    {
        List<Residente> GetResidentes();
        Residente GetResidenteById(int residenteId);
        DateTime GetCreateDate();
        string GetVersion();
        void SaveResidente(Residente residente);
    }
}
