using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using KoçFinans.FullStackProject.Business.Contracts;
using KoçFinans.FullStackProject.Business.DTO;
using KoçFinans.FullStackProject.Utils.Validation;

namespace KoçFinans.FullStackProject.Business
{
    public class SMSEngine : ISMSEngine
    {

      private readonly  IValidationService _validationService;
       

        public SMSEngine()
        {
          
        }
        public SMSEngine(IValidationService validationService)
        {
            _validationService = validationService;
        }
        public bool SendSms(string phoneNumber)
        {
            bool result = _validationService._IsPhoneNumber(phoneNumber);
            if (result == false)
            {
                return false;
            }

            //Bu kısımda sadece deneme amaçlı telefon numarası doğru yazılmışsa , sms gonderilmiş varsayılarak true gonderiyoruz.

            return true;
        }
    }
}
