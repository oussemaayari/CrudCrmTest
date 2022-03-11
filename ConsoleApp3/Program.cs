using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.Xrm.Tooling.Connector;
using Microsoft.Xrm.Sdk;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using System.Net.Http;
using System.Net;
using System.Configuration;
using System.Web.Configuration;
using Microsoft.Xrm.Sdk.Client;
using System.ServiceModel.Description;

namespace ConsoleApp3
{
    class Program
    {
        IOrganizationService _service;

        IOrganizationService _service2;

        static void Main(string[] args)
        {
            IOrganizationService _service2;
            var instance = new Program();

            //  _service2 =   instance.GetOrganizationServicess();

            //    if (_service2 == null)
            //{
            //    Console.WriteLine(_service2.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("CRM CONNECTED");
            //}
            Console.WriteLine(instance.GetOrganizationServicess());

            Console.ReadLine();



        }


      string GetOrganizationServicess()
        {
            try
            {
                
                    //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;
                    //string IpCrm = WebConfigurationManager.AppSettings["IpCrm"];
                    //string organizationserviceendpoint = WebConfigurationManager.AppSettings["OrganizationUri"];
                    //string crmusername = WebConfigurationManager.AppSettings["username"];
                    //string crmpassword = WebConfigurationManager.AppSettings["password"];



                    ClientCredentials credentials = new ClientCredentials();
                    credentials.UserName.UserName = "o.ayarii";
                    credentials.UserName.Password = "Azerty@123+";
                 Uri serviceUri = new Uri( "https://xrm-stagiaire.crm-hlitn.com/crmstagiere");
                // OrganizationServiceProxy proxy = new OrganizationServiceProxy(serviceUri, null, credentials, null);

                //  proxy.EnableProxyTypes();







                //  _service = (IOrganizationService)proxy;
                return "connected";



               
              
            }
            catch (Exception ex)
            {
                return "non bb";
            }
        }


    }
}
