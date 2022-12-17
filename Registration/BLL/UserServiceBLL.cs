using Registration.FormService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registration.BLL
{
    public class UserServiceBLL
    {
        public FormData SendRegistrationData(FormData formData)
        {
            FormServiceClient client = new FormServiceClient();
            
            return client.RegistrationFormData(formData);
        }
    }
}