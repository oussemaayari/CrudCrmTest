using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class1
    {
        static void Main2(string[] args)
        {
            //try
            //{
            //    var connectionString2 = @" 
            //                Url=https://xrm-stagiaire.crm-hlitn.com/crmstagiere/; Domain=hliconsulting; Username=o.ayarii; Password=Azerty@123+;";

            //    var connectionString = @"
            //                Url = https://xrm-stagiaire.crm-hlitn.com;
            //                Username=o.ayarii;
            //                Password=Azerty@123+";
            //    CrmServiceClient conn = new CrmServiceClient(connectionString2);

            //    if (conn != null && conn.IsReady)
            //    {
            //        Console.WriteLine("CRM CONNECTED");

            //    }
            //    else
            //    {
            //        Console.WriteLine("CRM NOT CONNECTED");
            //    }
            //    IOrganizationService service;
            //    service = (IOrganizationService)conn.
            //        OrganizationWebProxyClient != null ? (IOrganizationService)conn.OrganizationWebProxyClient : (IOrganizationService)conn.OrganizationServiceProxy;

            //    //  Create a new record
            //    /* Entity contact = new Entity("contact");
            //     contact["firstname"] = "Bob";
            //     contact["lastname"] = "Smith";
            //     Guid contactId = service.Create(contact);
            //     Console.WriteLine("New contact id: {0}.", contactId.ToString());*/
            //    // create another reecord


            //    //try
            //    //{
            //    //    Entity oussema = new Entity("contact");
            //    //    oussema["firstname"] = "saif";
            //    //    oussema["lastname"] = "hzami";
            //    //    oussema["emailaddress1"] = "oussema.ayari@gmail.com";

            //    //    oussema["telephone1"] = "24075932";
            //    //    oussema["new_password"] = "password";
            //    //    oussema["new_user_name"] = "userNametest";

            //    //    Guid oussemaID = service.Create(oussema);
            //    //    Console.WriteLine("new contact id : {0} ", oussemaID.ToString());

            //    //    ColumnSet attributess = new ColumnSet(new string[] { "new_password", "new_user_name" });



            //    //    //Guid id = new Guid("075de5a8-56d0-ea11-a812-000d3a1bbd52");
            //    //    // Entity retrievedContacts = service.Retrieve(oussema.LogicalName, oussemaID, attributess);

            //    //    List<Entity> contacts = new List<Entity>();
            //    //    contacts = GetAllContacts(service);

            //    //    /*foreach (var a in retrievedContacts.Attributes)
            //    //    {
            //    //        Console.WriteLine("Retrieved contact field {0} - {1}  ", a.Key, a.Value);
            //    //    }*/
            //    //    foreach (var cntct in contacts)
            //    //    {
            //    //        foreach (var a in cntct.Attributes)
            //    //        {
            //    //            Console.WriteLine("Retrieved contact field {0}  ", a.Value);
            //    //        }
            //    //    }




            //    //}
            //    //catch (Exception e)
            //    //{
            //    //    Console.WriteLine(e.ToString());
            //    //    throw;
            //    //};





            //    // Retrieve a record using Id

            //    /* Entity retrievedContact = service.Retrieve(contact.LogicalName, contactId, new ColumnSet(true));
            //     Console.WriteLine("Record retrieved {0}", retrievedContact.Id.ToString());*/

            //    //    Update record using Id, retrieve all attributes

            //    /* Entity updatedContact = new Entity("contact");
            //     updatedContact = service.Retrieve(oussema.LogicalName, oussemaID, new ColumnSet("lastname"));
            //     updatedContact["firstname"] = "saif";
            //     updatedContact["emailaddress1"] = "test@test.com";
            //     service.Update(updatedContact);
            //     Console.WriteLine("Updated contact");
            //     */

            //    //  Retrieve specific fields using ColumnSet


            //    /* ColumnSet attributes = new ColumnSet(new string[] { "new_password", "new_user_name" });



            //    //Guid id = new Guid("075de5a8-56d0-ea11-a812-000d3a1bbd52");
            //    Entity retrievedContact = service.Retrieve(oussema.LogicalName, oussemaID, attributes);
            //     foreach (var a in retrievedContact.Attributes)
            //     {
            //         Console.WriteLine("Retrieved contact field {0} - {1}  ", a.Key, a.Value);
            //     }
            //   */

            //    // Delete a record using Id

            //    //Guid id = new Guid("902d0f3f-558b-ec11-8d20-6045bd94b4a4");
            //    // service.Delete(oussema.LogicalName,id );
            //    //  Console.WriteLine("Deleted");
            //    //  Console.ReadLine();
            //    //Console.ReadLine();

            //    List<Entity> GetAllContacts(IOrganizationService servicess)
            //    {
            //        var pageNumber = 1;
            //        var pagingCookie = string.Empty;
            //        var result = new List<Entity>();
            //        EntityCollection resp;
            //        do
            //        {
            //            var query = new QueryExpression("contact") { ColumnSet = new ColumnSet("new_password", "new_user_name") };
            //            #region Add conditions to query
            //            query.Criteria.AddCondition(new ConditionExpression("statecode", ConditionOperator.Equal, 0));
            //            query.Criteria.AddCondition(new ConditionExpression("emailaddress1", ConditionOperator.NotNull));
            //            query.Criteria.FilterOperator = LogicalOperator.And;
            //            #endregion


            //            resp = service.RetrieveMultiple(query);

            //            result.AddRange(resp.Entities.ToList());
            //        } while (resp.MoreRecords);
            //        return result.ToList();
            //    }
            //    Console.ReadLine();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.ReadLine();
            //}



            Console.WriteLine("test");
            Console.ReadLine();
        }
    }
}
