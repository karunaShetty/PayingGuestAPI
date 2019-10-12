using PGBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PGBusiness.Service.Models
{
    public interface IRegisterModel
    {
        bool Save();
        bool Update();
        bool UnRegister();
    }
    class RegisterModel : IRegisterModel
    {
        public RegisterModel(PayingGuestHouse payingGuest,IPGFactory factory)
        {

        }
        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UnRegister()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
