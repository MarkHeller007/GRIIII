using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GRIDevelopment.DAL.DBContexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GRIDevelopment.DAL.DBInitializer
{
    public class DbInitializer : IDbInitializer
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly GRIContext _db;

        public DbInitializer(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, GRIContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }
        public void Initialize()
        {
            //migrations
            try
            {
                if (_db.Database.GetPendingMigrations().Count()>0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
