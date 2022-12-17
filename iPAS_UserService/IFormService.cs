using iPAS_UserService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace iPAS_UserService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFormService" in both code and config file together.
    [ServiceContract]
    public interface IFormService
    {
        [OperationContract]
        String Welcome(string name);

        [OperationContract]
        FormData RegistrationFormData(FormData data);

        [OperationContract]
        int CalculateDays(int day, int Month, int year);
    }

    
}

