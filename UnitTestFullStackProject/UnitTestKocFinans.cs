using System;
using System.Web.Mvc;
using KoçFinans.FullStackProject.Business;
using KoçFinans.FullStackProject.Business.Contracts;
using KoçFinans.FullStackProject.Business.DTO;
using KoçFinans.FullStackProject.Contracts.Repository;
using KoçFinans.FullStackProject.Controllers;
using KoçFinans.FullStackProject.Data.Entity;
using KoçFinans.FullStackProject.Data.Repository;

//using Microsoft.AspNet.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFullStackProject
{
    [TestClass]
    public class UnitTestKocFinans
    {
        //    ICreditScoreEngine creditScoreEngine = new CreditScoreEngine();

        //    ICreditScoreRepository _creditScoreRepository = new CreditScoreRepository();

        //    IUserInformationRepository _userInformationRepository = new UserInformationRepository();
        //    ISMSEngine _smsEngine = new SMSEngine();
        //    [TestMethod]

        //    public void CreditResult()
        //    {
        //        UserInformation userInformation = new UserInformation();
        //        userInformation.MonthlyGain = 3500;
        //        userInformation.Name = "ece";
        //        userInformation.Surname = "sural";
        //        userInformation.TCNo = 11009992543;
        //        userInformation.TelNo = "5367778833";
        //        CreditController creditController = new CreditController();
        //        ViewResult viewResult = creditController.CreditResult(userInformation) as ViewResult;

        //        Assert.IsNotNull(viewResult);
        //    }
        //    public void CreditResult(UserInformation userInformation)
        //    {
        //        userInformation.MonthlyGain = 3500;
        //        userInformation.Name = "ece";
        //        userInformation.Surname = "sural";
        //        userInformation.TCNo = 11009992543;
        //        userInformation.TelNo = "5367778833";

        //        CreditLimit result = creditScoreEngine.ReturnCreditLimit(userInformation);

        //        Assert.AreEqual(1400, result.Limit);
        //        Assert.AreEqual("Onay", result.Result);
        //    }
        //    [TestMethod]
        //    public void ReturnCreditLimit(UserInformation userInformation)
        //    {


        //        CreditLimit creditLimit = new CreditLimit();
        //        creditLimit.Limit = 0;
        //        creditLimit.Result = "Red";

        //        long score = 1700;

        //        if (score < 500)
        //        {

        //            creditLimit.Limit = 0;
        //            creditLimit.Result = "Red";

        //        }

        //        if ((500 <= score) && (score < 1000))
        //        {
        //            if (userInformation.MonthlyGain < 5000)
        //            {

        //                creditLimit.Limit = 10000;
        //                creditLimit.Result = "Onay";



        //            }

        //        }

        //        if (1000 <= score)
        //        {

        //            creditLimit.Limit = Convert.ToInt64(userInformation.MonthlyGain * 4);
        //            creditLimit.Result = "Onay";

        //        }
        //        Assert.AreEqual(1400, creditLimit.Limit);
        //        Assert.AreEqual("Onay", creditLimit.Result);


        //    }
        //    [TestMethod]
        //    public void GetCreditSkor()
        //    {
        //        long tcno = 11009992543;

        //        long skor = _creditScoreRepository.GetCreditSkor(tcno);
        //        Assert.AreEqual(1700, skor);


        //    }

    }
}
