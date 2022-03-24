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
using Microsoft.Xrm.Sdk.Messages;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace ConsoleApp3
{
    class Program
    {
        private Guid _userId;
        private String _givenRole = "salesperson";

        // IOrganizationService _service;


        static void Main(string[] args)
        {
           IOrganizationService _service;
            List<Contact> contacts = new List<Contact>();
  
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11|SecurityProtocolType.Ssl3;        

            Console.WriteLine("waiting ...");
            
            ServicePointManager.ServerCertificateValidationCallback =
       delegate (
           object s,
           X509Certificate certificate,
           X509Chain chain,
           SslPolicyErrors sslPolicyErrors
       ) {
         
           return true;
       };
            ClientCredentials credentials = new ClientCredentials();
            credentials.UserName.UserName = "o.ayarii";
            credentials.UserName.Password = "Azerty@123+";
            Uri serviceUri = new Uri("https://xrm-stagiaire.crm-hlitn.com/crmstagiere/XRMServices/2011/Organization.svc");
            OrganizationServiceProxy proxy = new OrganizationServiceProxy(serviceUri, null, credentials, null);
            proxy.EnableProxyTypes();
            _service = (IOrganizationService)proxy;
            // var t = _service.RetrieveMultiple(new QueryExpression() { EntityName = "contact" });
            // 
            var result = new List<Contact>();
            EntityCollection resp;        


            do
            {
                var query = new QueryExpression("contact") { ColumnSet = new ColumnSet("contactid", "fullname", "new_password", "emailaddress1", "new_contact_role") };
                //resp = _service.RetrieveMultiple(query);
                Guid targetedId = new Guid("82ba41b0-43a2-ec11-ac46-000c299f48b4");

                var query2 = new QueryExpression("role") { ColumnSet = new ColumnSet("roleid", "businessunitid","name") };
                resp = _service.RetrieveMultiple(query);

                for (int i = 1; i < resp.Entities.Count; i++)
                  {
                      Contact contact = new Contact();
                      if (resp.Entities[i].Contains("contactid"))
                      {
                          Console.WriteLine((string)resp.Entities[i].Attributes["contactid"].ToString());



                      } 
                    if (resp.Entities[i].Contains("fullname"))
                      {
                          Console.WriteLine((string)resp.Entities[i].Attributes["fullname"]);


                      }
                    if (resp.Entities[i].Contains("new_contact_role"))
                      {
                        
                      var test= resp.Entities[i].GetAttributeValue<EntityReference>("new_contact_role");
                          Console.WriteLine(test.Name);

                      }
             /*       QueryExpression query3 = new QueryExpression
                    {
                        EntityName = "role",
                        ColumnSet = new ColumnSet("roleid"),
                        Criteria = new FilterExpression
                        {
                            Conditions =
                                {

                                    new ConditionExpression
                                    {
                                        AttributeName = "name",
                                        Operator = ConditionOperator.Equal,
                                        Values = { "salesperson" }
                                    }
                                }
                        }
                    };*/

                  /*  EntityCollection roles = _service.RetrieveMultiple(query2);
                    if (roles.Entities.Count > 0)
                    {
                        Entity Role = _service.RetrieveMultiple(query2).Entities[0];

                        Console.WriteLine("Role {0} is retrieved for the role assignment.", Role.Attributes["roleid"]);

                      Guid  _roleId = new Guid(Role.Attributes["roleid"].ToString());

                        // Associate the user with the role.
                        if (_roleId != Guid.Empty && targetedId != Guid.Empty)
                        {
                            _service.Associate(
                                        "contact",
                                        targetedId,
                                        new Relationship("new_contact_role"),
                                        new EntityReferenceCollection() { new EntityReference("role", _roleId) });

                            Console.WriteLine("Role is associated with the user.");
                        }
                    }*/




                    //if (resp.Entities[i].Contains("new_password"))
                    //{
                    //    contact.password = (string)resp.Entities[i].Attributes["new_password"];
                    //}
                    //if (resp.Entities[i].Contains("emailaddress1"))
                    //{
                    //    contact.emailadress1= (string)resp.Entities[i].Attributes["emailaddress1"];
                    //}
                    //if (resp.Entities[i].Contains("telephone1"))
                    //{
                    //    contact.telephone1 = (string)resp.Entities[i].Attributes["telephone1"];
                    //}
                    contacts.Add(contact);
                  }

            } while (resp.MoreRecords);


           

    

            // Find the role.
          


            Console.ReadLine();



        }

        private static string getRoleName()
        {


            return "";
        }

        public IOrganizationService GetOrganizationService()
        {

            ServicePointManager.SecurityProtocol = SecurityProtocolType.SystemDefault;
            //string IpCrm = WebConfigurationManager.AppSettings["IpCrm"];
            //string organizationserviceendpoint = WebConfigurationManager.AppSettings["OrganizationUri"];
            //string crmusername = WebConfigurationManager.AppSettings["username"];
            //string crmpassword = WebConfigurationManager.AppSettings["password"];

            ClientCredentials credentials = new ClientCredentials();
            credentials.UserName.UserName = "se.hazemi";
            credentials.UserName.Password = "Azerty@123+";
            Uri serviceUri = new Uri("https://xrm-stagiaire.crm-hlitn.com/crmstagiere/XRMServices/2011/Organization.svc");
            OrganizationServiceProxy proxy = new OrganizationServiceProxy(serviceUri, null, credentials, null);
            proxy.EnableProxyTypes();
            var _service = (IOrganizationService)proxy;
            var t = _service.RetrieveMultiple(new QueryExpression() { EntityName = "contact" });

            return _service;




        }


    }
}
