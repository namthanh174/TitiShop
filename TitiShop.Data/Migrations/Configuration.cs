namespace TitiShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TitiShop.Data.TitiShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TitiShop.Data.TitiShopDbContext context)
        {

            CreateProductCategorySample(context);

            //  This method will be called after migrating to the latest version.

            

            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TitiShopDbContext()));
            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TitiShopDbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "thanh",
            //    Email = "vovanthanh@live.com",
            //    EmailConfirmed = true,
            //    BirthDay = DateTime.Now,
            //    FullName = "Vo Van Thanh"
            //};

            //manager.Create(user, "1741989$");

            //if (!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}

            //var adminUser = manager.FindByEmail("vovanthanh@live.com");

            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }

        private void CreateProductCategorySample(TitiShop.Data.TitiShopDbContext context)
        {
            if(context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>() {
                new ProductCategory() {Name="Điện lạnh",Alias="dien-lanh",Status=true },
                new ProductCategory() {Name="Viễn thông",Alias="vien-thong",Status=true },
                new ProductCategory() {Name="Đồ gia dụng",Alias="do-gia-dung",Status=true },
                new ProductCategory() {Name="Mỹ phẫm",Alias="my-pham",Status=true }
            };

                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }
           

        }
    }
}