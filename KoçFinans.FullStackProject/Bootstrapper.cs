using System.Web.Mvc;
using KoçFinans.FullStackProject.Business;
using KoçFinans.FullStackProject.Business.Contracts;
using KoçFinans.FullStackProject.Contracts.Repository;
using KoçFinans.FullStackProject.Data.Repository;
using KoçFinans.FullStackProject.Utils.Validation;
using Microsoft.Practices.Unity;
using Unity.Mvc4;

namespace KoçFinans.FullStackProject
{
  public static class Bootstrapper
  {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<ICreditScoreEngine, CreditScoreEngine>();
            container.RegisterType<ISMSEngine, SMSEngine>();

            container.RegisterType<IValidationService, ValidationEngine>();

            container.RegisterType<ICreditScoreRepository, CreditScoreRepository>();

            container.RegisterType<IUserInformationRepository, UserInformationRepository>();

            RegisterTypes(container);

            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {

        }
    }
}