using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Unity.Mvc4;

namespace GuDong.Unity
{
    public static class Ioc
    {
       public static IUnityContainer container;

       public static IUnityContainer Initialise(string FilePath, string Container = "default")
       {
           container = new UnityContainer();
           var configMap = new ExeConfigurationFileMap { ExeConfigFilename = FilePath };
           var configuration = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);
           var section = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);
           container.LoadConfiguration(section, Container);
           DependencyResolver.SetResolver(new UnityDependencyResolver(container));
           return container;
       }
    }
}
