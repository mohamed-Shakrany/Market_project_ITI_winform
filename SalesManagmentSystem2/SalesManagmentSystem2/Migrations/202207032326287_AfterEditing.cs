namespace SalesManagmentSystem2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AfterEditing : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BuyProcesses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        NationalID = c.String(nullable: false, maxLength: 14, fixedLength: true),
                        TotalPrice = c.Decimal(nullable: false, storeType: "money"),
                        DataProcess = c.DateTime(nullable: false, storeType: "date"),
                        SupplierId = c.Int(),
                        UserId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.SupplierId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.BuyProcessProducts",
                c => new
                    {
                        Id_p = c.Int(nullable: false),
                        Id_bp = c.Int(nullable: false),
                        Total_quantity = c.Int(nullable: false),
                        ProductDate = c.DateTime(nullable: false, storeType: "date"),
                        ExpireDate = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => new { t.Id_p, t.Id_bp })
                .ForeignKey("dbo.BuyProcesses", t => t.Id_bp, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Id_p, cascadeDelete: true)
                .Index(t => t.Id_p)
                .Index(t => t.Id_bp);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        ProductPrice = c.Decimal(nullable: false, storeType: "money"),
                        Quantity = c.Int(nullable: false),
                        categoryId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Categories", t => t.categoryId, cascadeDelete: true)
                .Index(t => t.categoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CatID = c.Int(nullable: false, identity: true),
                        CatName = c.String(nullable: false, maxLength: 255),
                        CatImg = c.String(),
                    })
                .PrimaryKey(t => t.CatID)
                .Index(t => t.CatName, unique: true, name: "index_category_name");
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id_o = c.Int(nullable: false),
                        Id_pp = c.Int(nullable: false),
                        QuantityProduct = c.Int(nullable: false),
                        PriceProduct = c.Decimal(nullable: false, storeType: "money"),
                        TotalPrice = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => new { t.Id_o, t.Id_pp })
                .ForeignKey("dbo.Orders", t => t.Id_o, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Id_pp, cascadeDelete: true)
                .Index(t => t.Id_o)
                .Index(t => t.Id_pp);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, storeType: "money"),
                        userId = c.Int(),
                        customerId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.customerId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.userId, cascadeDelete: true)
                .Index(t => t.userId)
                .Index(t => t.customerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustID = c.Int(nullable: false, identity: true),
                        CustName = c.String(nullable: false),
                        CustAddress = c.String(),
                        CustPhone = c.String(nullable: false, maxLength: 11),
                        CustMail = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.CustID)
                .Index(t => t.CustPhone, unique: true, name: "index_customer_phone")
                .Index(t => t.CustMail, unique: true, name: "index_customer_mail");
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        UserAddress = c.String(),
                        UserPhone = c.String(nullable: false, maxLength: 11),
                        UserEmail = c.String(maxLength: 255),
                        UserLevel = c.Byte(nullable: false),
                        userPassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .Index(t => t.UserPhone, unique: true, name: "index_user_phone")
                .Index(t => t.UserEmail, unique: true, name: "index_user_mail");
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SuppName = c.String(nullable: false),
                        SuppAddress = c.String(),
                        SuppPhone = c.String(nullable: false, maxLength: 11),
                        SuppMail = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.SuppPhone, unique: true, name: "index_supplier_phone")
                .Index(t => t.SuppMail, unique: true, name: "index_supplier_mail");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BuyProcesses", "UserId", "dbo.Users");
            DropForeignKey("dbo.BuyProcesses", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.BuyProcessProducts", "Id_p", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "Id_pp", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "Id_o", "dbo.Orders");
            DropForeignKey("dbo.Orders", "userId", "dbo.Users");
            DropForeignKey("dbo.Orders", "customerId", "dbo.Customers");
            DropForeignKey("dbo.Products", "categoryId", "dbo.Categories");
            DropForeignKey("dbo.BuyProcessProducts", "Id_bp", "dbo.BuyProcesses");
            DropIndex("dbo.Suppliers", "index_supplier_mail");
            DropIndex("dbo.Suppliers", "index_supplier_phone");
            DropIndex("dbo.Users", "index_user_mail");
            DropIndex("dbo.Users", "index_user_phone");
            DropIndex("dbo.Customers", "index_customer_mail");
            DropIndex("dbo.Customers", "index_customer_phone");
            DropIndex("dbo.Orders", new[] { "customerId" });
            DropIndex("dbo.Orders", new[] { "userId" });
            DropIndex("dbo.OrderDetails", new[] { "Id_pp" });
            DropIndex("dbo.OrderDetails", new[] { "Id_o" });
            DropIndex("dbo.Categories", "index_category_name");
            DropIndex("dbo.Products", new[] { "categoryId" });
            DropIndex("dbo.BuyProcessProducts", new[] { "Id_bp" });
            DropIndex("dbo.BuyProcessProducts", new[] { "Id_p" });
            DropIndex("dbo.BuyProcesses", new[] { "UserId" });
            DropIndex("dbo.BuyProcesses", new[] { "SupplierId" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Users");
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.BuyProcessProducts");
            DropTable("dbo.BuyProcesses");
        }
    }
}
