using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReportsForOZHIdev.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ReportsForOZHIdev.Logic
{
    internal class RoleActions
    {
        internal void AddUserAndRole()
        {
            // Access application context and create result variables
            Models.ApplicationDbContext context = new ApplicationDbContext();
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;

            // Create a RoleStore object by using the ApplicationDbContext object
            // The RoleStore is only allowed to contain IdentityRole objects
            var roleStore = new RoleStore<IdentityRole>(context);

            // Create a RoleManager object that is only allowed to contain IdentityRole objects
            // When creating the RoleManager object, you pass in (as a parameter) a new RoleStore object
            var roleMgr = new RoleManager<IdentityRole>(roleStore);

            // Then, you create the "canEdit" role if it doesn't already exist
            if (!roleMgr.RoleExists("canEdit"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "canEdit" });
            }

            // Create UserManager object based on the UserStore object and the ApplicationDbContext
            // object.  Note that you can create new objects and use them as parameters in
            // a single line of code, rather than using multiple lines of code, as you did
            // for the RoleManager object
            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appUser = new ApplicationUser
            {
                UserName = "derekzoccole@hotmail.com",
                Email = "derekzoccole@hotmail.com"
            };
            IdUserResult = userMgr.Create(appUser, "Pa$$word1");

            // If the new "canEdit" user was successfully created,
            // add the "canEdit" user to the "canEdit" role
            if (!userMgr.IsInRole(userMgr.FindByEmail("derekzoccole@hotmail.com").Id, "canEdit"))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail("derekzoccole@hotmail.com").Id, "canEdit");
            }

            using (var _db = new ReportsForOZHIdev.Models.ClientsContext())
            {
                var myUser = new User();
                var user = userMgr.FindByEmail("derekzoccole@hotmail.com");
                myUser.UserId = user.Id;
                myUser.Username = user.UserName;
                myUser.Email = user.Email;
                myUser.PasswordHash = user.PasswordHash;
                myUser.FirstName = "Derek";
                myUser.LastName = "Zoccole";
                myUser.Company = "OZHI";

                //if (_db.Users.Local.Any(e => e.UserId == user.Id))
                //{
                    _db.Users.Add(myUser);
                    _db.SaveChanges();
                //}
            }
        }

        internal void AddUser(string role, string username, string password, string firstname, string lastname, string company)
        {
            // Access application context and create result variables
            Models.ApplicationDbContext context = new ApplicationDbContext();
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;

            // Create a RoleStore object by using the ApplicationDbContext object
            // The RoleStore is only allowed to contain IdentityRole objects
            var roleStore = new RoleStore<IdentityRole>(context);

            // Create a RoleManager object that is only allowed to contain IdentityRole objects
            // When creating the RoleManager object, you pass in (as a parameter) a new RoleStore object
            var roleMgr = new RoleManager<IdentityRole>(roleStore);

            // Then, you create the "canEdit" role if it doesn't already exist
            if (!roleMgr.RoleExists(role))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = role });
            }

            // Create UserManager object based on the UserStore object and the ApplicationDbContext
            // object.  Note that you can create new objects and use them as parameters in
            // a single line of code, rather than using multiple lines of code, as you did
            // for the RoleManager object
            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appUser = new ApplicationUser
            {
                UserName = username,
                Email = username
            };
            IdUserResult = userMgr.Create(appUser, password);

            // If the new "canEdit" user was successfully created,
            // add the "canEdit" user to the "canEdit" role
            if (!userMgr.IsInRole(userMgr.FindByEmail(username).Id, role))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail(username).Id, role);
            }

            using (var _db = new ReportsForOZHIdev.Models.ClientsContext())
            {
                var myUser = new User();
                var user = userMgr.FindByEmail(username);
                myUser.UserId = user.Id;
                myUser.Username = user.UserName;
                myUser.Email = user.Email;
                myUser.PasswordHash = user.PasswordHash;
                myUser.FirstName = firstname;
                myUser.LastName = lastname;
                myUser.Company = company;
                
                _db.Users.Add(myUser);
                _db.SaveChanges();
            }
        }
    }
}