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

namespace ConsoleApp3
{
    class Program
    {


        IOrganizationService _service2;

        static void Main(string[] args)
        {

                //IOrganizationService _service;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;
                //string IpCrm = WebConfigurationManager.AppSettings["IpCrm"];
                //string organizationserviceendpoint = WebConfigurationManager.AppSettings["OrganizationUri"];
                //string crmusername = WebConfigurationManager.AppSettings["username"];
                //string crmpassword = WebConfigurationManager.AppSettings["password"];



                //ClientCredentials credentials = new ClientCredentials();
                //credentials.UserName.UserName = "o.ayarii";
                //credentials.UserName.Password = "Azerty@123+";
                //Uri serviceUri = new Uri("https://xrm-stagiaire.crm-hlitn.com/crmstagiere/XRMServices/2011/Organization.svc");
                //OrganizationServiceProxy proxy = new OrganizationServiceProxy(serviceUri, null, credentials, null);

                //proxy.EnableProxyTypes();
                //_service = (IOrganizationService)proxy;


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

           








            //var connectionString = @" AuthType = Office365;              
            //    Url = https://orgcde5f393.crm4.dynamics.com;
            //        Username=Saif.Hazemi@isamm.u-manouba.tn;
            //        Password=g'lmaram9782536A";
            //CrmServiceClient conn = new CrmServiceClient(connectionString);
            //IOrganizationService service;
            //service = (IOrganizationService)conn.
            //    OrganizationWebProxyClient != null ? (IOrganizationService)conn.OrganizationWebProxyClient : (IOrganizationService)conn.OrganizationServiceProxy;

            //if (conn != null && conn.IsReady)
            //{
            //    Console.WriteLine("CRM CONNECTED");

            //}
            //else
            //{
            //    Console.WriteLine("CRM NOT CONNECTED");
            //}
            ////create the query expression object
            //QueryExpression query = new QueryExpression();

            ////Query on reated entity records
            //query.EntityName = "incident";

            ////Retrieve the all attributes of the related record
            //query.ColumnSet = new ColumnSet(true);

            ////create the relationship object
            //Relationship relationship = new Relationship();

            ////add the condition where you can retrieve only the account related active contacts
            //query.Criteria = new FilterExpression();
            //query.Criteria.AddCondition(new ConditionExpression("statecode", ConditionOperator.Equal, "Active"));

            //// name of relationship between account & contact
            //relationship.SchemaName = "incident_customer_accounts";

            ////create relationshipQueryCollection Object
            //RelationshipQueryCollection relatedEntity = new RelationshipQueryCollection();

            ////Add the your relation and query to the RelationshipQueryCollection
            //relatedEntity.Add(relationship, query);

            ////create the retrieve request object
            //RetrieveRequest request = new RetrieveRequest();

            ////add the relatedentities query
            //request.RelatedEntitiesQuery = relatedEntity;

            ////set column to  and the condition for the account 
            //request.ColumnSet = new ColumnSet("accountid");
            //var id = Guid.Parse("dbdd0b93-4a1b-4848-b83a-39352f6b2e7a");
            //request.Target = new EntityReference { Id = id, LogicalName = "account" };

            ////execute the request
            //RetrieveResponse response = (RetrieveResponse)service.Execute(request);
            //for(int i = 0; i< ((DataCollection<Relationship, EntityCollection>)(((RelatedEntityCollection)(response.Entity.RelatedEntities))))[new Relationship("incident_customer_accounts")].Entities.Count; i++)
            //{
            //    Console.WriteLine(((DataCollection<Relationship, EntityCollection>)(((RelatedEntityCollection)(response.Entity.RelatedEntities))))[new Relationship("incident_customer_accounts")].Entities[i].Attributes["incidentid"]);
            //    Console.WriteLine(((DataCollection<Relationship, EntityCollection>)(((RelatedEntityCollection)(response.Entity.RelatedEntities))))[new Relationship("incident_customer_accounts")].Entities[i].Attributes["title"]);
            //}
            //Console.WriteLine(((DataCollection<Relationship, EntityCollection>)(((RelatedEntityCollection)(response.Entity.RelatedEntities))))[new Relationship("incident_customer_accounts")].Entities.Count);
            //// here you can check collection count
            ////if (((DataCollection<Relationship, EntityCollection>)(((RelatedEntityCollection)(response.Entity.RelatedEntities)))).Contains(new Relationship("contact_customer_accounts")) && ((DataCollection<Relationship, EntityCollection>)(((RelatedEntityCollection)(response.Entity.RelatedEntities))))[new Relationship("contact_customer_accounts")].Entities.Count > 0)
            ////{ Console.WriteLine();}
            ////else
            ////   

            //Program instance = new Program();


            //Console.WriteLine(instance.GetOrganizationServicess());
            Console.ReadLine();



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
