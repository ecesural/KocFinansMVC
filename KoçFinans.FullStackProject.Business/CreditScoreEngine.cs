using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.ModelBinding;
using KoçFinans.FullStackProject.Business.Contracts;
using KoçFinans.FullStackProject.Business.DTO;
using KoçFinans.FullStackProject.Contracts.Repository;
using KoçFinans.FullStackProject.Data.Entity;
using KoçFinans.FullStackProject.Data.Repository;
using KoçFinans.FullStackProject.Utils.Enum;
using KoçFinans.FullStackProject.Utils.Validation;

namespace KoçFinans.FullStackProject.Business
{
    public class CreditScoreEngine : ICreditScoreEngine
    {
        private readonly ICreditScoreRepository _creditScoreRepository;
        private readonly IUserInformationRepository _userInformationRepository;
        private readonly ISMSEngine _smsEngine;

        public CreditScoreEngine()
        {

        }

        public CreditScoreEngine(ICreditScoreRepository creditScoreRepository, IUserInformationRepository userInformationRepository, ISMSEngine smsEngine)
        {
            _creditScoreRepository = creditScoreRepository;
            _userInformationRepository = userInformationRepository;
            _smsEngine = smsEngine;
        }

        public long GetCreditSkor(long TCNo)
        {
            return _creditScoreRepository.GetCreditSkor(TCNo);
        }

        public CreditLimit ReturnCreditLimit(UserInformation userInformation)
        {
            CreditLimit creditLimit = new CreditLimit()
            {
                Limit = 0,
                Result = "Onay"
            };

            long score = GetCreditSkor(userInformation.TCNo);

            //Kurallardaki ilk eksik . Eğer kullanıcının hiç skoru yoksa ilk defa kredi çekecekse nasıl bir işlem yapılmalı belirtilmemiştir.

            if (score < 500)
            {
                creditLimit.Limit = 0;
                creditLimit.Result = "Red";
            }

            if ((500 <= score) && (score < 1000))
            {
                if (userInformation.MonthlyGain < 5000)
                {

                    creditLimit.Limit = 10000;
                    creditLimit.Result = "Onay";

                    //_userInformationRepository.AddUser(userInformation);
                    //_smsEngine.SendSms(userInformation.TelNo);

                }

                //Kurallardan ikinci eksik eğer aylık gelir 5000 den fazla ise nasıl bir işlem sağlanılacak onun bilgisi de verilmemiş.

            }

            if (1000 <= score)
            {
                creditLimit.Limit = Convert.ToInt64(userInformation.MonthlyGain * 4);
                creditLimit.Result = "Onay";

                //_userInformationRepository.AddUser(userInformation);
                //_smsEngine.SendSms(userInformation.TelNo);

            }
            if (creditLimit.Result == "Onay")
            {
                _userInformationRepository.AddUser(userInformation);
                _smsEngine.SendSms(userInformation.TelNo);
            }

            return creditLimit;

        }
    }
}
