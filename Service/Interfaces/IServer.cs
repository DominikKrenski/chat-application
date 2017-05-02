using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service.Interfaces
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IServer” w kodzie i pliku konfiguracji.
    [ServiceContract]
    public interface IServer
    {
        [OperationContract]
        void DoWork();
    }
}
