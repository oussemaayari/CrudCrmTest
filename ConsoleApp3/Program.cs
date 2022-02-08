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


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var connectionString = @"AuthType = Office365; 
                            Url =https://orgcacc7db5.crm4.dynamics.com;
                            Username=ayari@isamm.u-manouba.tn;
                            Password=XgtS?%RTNj";
                CrmServiceClient conn = new CrmServiceClient(connectionString);

                IOrganizationService service;
                service = (IOrganizationService)conn.
                    OrganizationWebProxyClient != null ? (IOrganizationService)conn.OrganizationWebProxyClient : (IOrganizationService)conn.OrganizationServiceProxy;

                // Create a new record
               /* Entity contact = new Entity("contact");
                contact["firstname"] = "Bob";
                contact["lastname"] = "Smith";
                Guid contactId = service.Create(contact);
                Console.WriteLine("New contact id: {0}.", contactId.ToString());*/
                //create another reecord 
                Entity oussema = new Entity("contact");
                oussema["firstname"] = "oussema";
                oussema["lastname"] = "ayari";
                oussema["emailaddress1"] = "oussema.ayari@gmail.com";
                oussema["company"] = "HLI";
                oussema["telephone1"] = "24075932";

                Guid oussemaID = service.Create(oussema);
                Console.WriteLine("new contact id : {0} ", oussemaID.ToString());

                // Retrieve a record using Id

               /* Entity retrievedContact = service.Retrieve(contact.LogicalName, contactId, new ColumnSet(true));
                Console.WriteLine("Record retrieved {0}", retrievedContact.Id.ToString());*/

                // Update record using Id, retrieve all attributes

                Entity updatedContact = new Entity("contact");
                updatedContact = service.Retrieve(oussema.LogicalName, oussemaID, new ColumnSet("lastname"));
                updatedContact["firstname"] = "saif";
                updatedContact["emailaddress1"] = "test@test.com";
                service.Update(updatedContact);
                Console.WriteLine("Updated contact");

                // Retrieve specific fields using ColumnSet
                Entity retrievedContact = service.Retrieve(oussema.LogicalName, oussemaID, new ColumnSet(true));
                ColumnSet attributes = new ColumnSet(new string[] { "firstname", "emailaddress1" });
                retrievedContact = service.Retrieve(oussema.LogicalName, oussemaID, attributes);
                foreach (var a in retrievedContact.Attributes)
                {
                    Console.WriteLine("Retrieved contact field {0} - {1}", a.Key, a.Value);
                }


                // Delete a record using Id

                /*  service.Delete(contact.LogicalName, contactId);
                  Console.WriteLine("Deleted");
                  Console.ReadLine();*/
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
    }
}
