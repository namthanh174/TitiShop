namespace TitiShop.Data.Migrations
{
    using Common;
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
            //CreateProductSample(context);
            //CreateProductCategorySample(context);

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

        //private void CreateProductCategorySample(TitiShop.Data.TitiShopDbContext context)
        //{
        //    if(context.ProductCategories.Count() == 0)
        //    {
        //        List<ProductCategory> listProductCategory = new List<ProductCategory>() {
        //        new ProductCategory() {Name="Điện lạnh",Alias="dien-lanh",Status=true },
        //        new ProductCategory() {Name="Viễn thông",Alias="vien-thong",Status=true },
        //        new ProductCategory() {Name="Đồ gia dụng",Alias="do-gia-dung",Status=true },
        //        new ProductCategory() {Name="Mỹ phẫm",Alias="my-pham",Status=true }
        //    };

        //        context.ProductCategories.AddRange(listProductCategory);
        //        context.SaveChanges();
        //    }
           

        //}


        //private void CreateProductSample(TitiShop.Data.TitiShopDbContext context)
        //{
        //    if (context.Products.Count() == 0)
        //    {
        //        List<Product> listProduct = new List<Product>() {
        //        new Product() {Name="Iphone 7",Alias="iphone-7",CategoryID=2,Price=500000,Status=true },
        //        new Product() {Name="Samsung s6",Alias="samsung-s6",CategoryID=2,Price=700000,Status=true },
        //        new Product() {Name="Iphone 5",Alias="iphone-5",CategoryID=2,Price=800000,Status=true },
        //        new Product() {Name="Nokia x7",Alias="nokia-x7",CategoryID=2,Price=1200000,Status=true }
        //    };

        //        context.Products.AddRange(listProduct);
        //        context.SaveChanges();
        //    }

        //}



        private void CreateFooter(TitiShopDbContext context)
        {
            if (context.Footers.Count(x => x.ID == CommonConstants.DefaultFooterId) == 0)
            {
                string content = "";
            }
        }



    }
}