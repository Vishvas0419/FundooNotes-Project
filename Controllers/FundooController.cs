using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ModelLayer;
namespace Fundoo.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //localhost****/api/Fundoo
    public class FundooController : ControllerBase
    {
        private IUserBL _userBL; //instance varibale to use BL
        public FundooController(IUserBL _userBL) { //initiaise BL object in controller contrcutor
            this._userBL = _userBL;
        }

        [HttpPost]
        public ResponseModel<RegistrationModel> RegisterUser(RegistrationModel registrationModel) //this will take a object from user to give it to BL
        {
            //_userBL.RegisterUserBL(registrationModel);  //return string
            RegistrationModel result = _userBL.RegisterUserBL(registrationModel);
            ResponseModel<RegistrationModel> model = new ResponseModel<RegistrationModel>();
            model.success = true;
            model.Message = "User REgistered Successfully";
            model.data = registrationModel;
            return model;
        }
    }
}
