using mvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc.Models
{
    public class SeedData
    {
		public static void Initialize(ApplicationDbContext context)
		{
			context.Database.EnsureCreated();

			// Look for any data
			if (context.Product.Any())
			{
				return;   // DB has been seeded
			}

			var products = new Product[]
			{
				new Product{Name="Galaxy S22 Plus ",Manufacturer="Samsung",Price=19900000,Quantity=10,Desciption="Chip Snapdragon 8 gen 1 , 8GB 128GB, Pin 4500mAh ,45W  .",Image="Galaxy-S22-Plus-White-19990.jpg"},
				new Product{Name="Iphone 11 ",Manufacturer="Iphone",Price=11690000,Quantity=20,Desciption="Chip Apple A13 Bionic , 4GB 64GB, Pin 3100mAh ,18W .",Image="iphone-11-11690.jpg"},
				new Product{Name="Iphone 13 mini ",Manufacturer="Iphone",Price=17490000,Quantity=15,Desciption="Chip Apple A15 ,	 6GB 512GB, Pin 4000mAh ,20W.",Image="iphone-13-mini-pink-1-17490.jpg"},
				new Product{Name="Iphone 13 Promax ",Manufacturer="Iphone",Price=28490000,Quantity=30,Desciption="Chip Apple A16 , 16GB 256GB, Pin 7500mAh ,60W.",Image="iphone-13-pro-max-xanh-la-thumb-28490.jpg"},
				new Product{Name="Iphone 14 Plus ",Manufacturer="Iphone",Price=25790000,Quantity=40,Desciption="Chip Apple A15 , 8GB 1TB, Pin 4500mAh ,25W.",Image="iPhone-14-plus-thumb-den-25790.jpg"},
				new Product{Name="Iphone 14 Promax ",Manufacturer="Iphone",Price=39590000,Quantity=5,Desciption="Chip Apple A15 , 8GB 1TB, Pin 8000mAh ,20W.",Image="iphone-14-pro-max-vang-39550.jpg"},
				new Product{Name="Oppo Reno8 5G",Manufacturer="Oppo",Price=13490000,Quantity=42,Desciption="Chip Snapdragon 8 gen 1 , 4GB 256GB, Pin 4500mAh ,35W.",Image="oppo-reno8-5g-den-thumb-13490.jpg"},
				new Product{Name="Samsung Galaxy A73 ",Manufacturer="Samsung",Price=12290000,Quantity=50,Desciption="Chip Snapdragon 8 gen 1 , 8GB 128GB, Pin 3600mAh ,45W.",Image="Samsung-Galaxy-A73-PUBG-Thumb-12290.jpg"},
				
				new Product{Name="Samsung Galaxy Z Fold4 5G 256gb ",Manufacturer="Samsung",Price=37990000,Quantity=108,Desciption="Chip Snapdragon 8 gen 1 , 16GB 256GB, Pin 6500mAh ,25W.",Image="samsung-galaxy-z-fold4-kem-256gb-37990.jpg"},
				new Product{Name="Samsung Galaxy Z Flip4 5G 512gb",Manufacturer="Samsung",Price=41490000,Quantity=32,Desciption="Chip Snapdragon 8 gen 1 , 16GB 512GB, Pin 6500mAh ,45W.",Image="samsung-galaxy-z-fold4-kem-512gb-41490.jpg"},
				new Product{Name="Vivo V23e  ",Manufacturer="Vivo",Price=27190000,Quantity=38,Desciption="Chip Snapdragon 8 gen 1 , 8GB 256GB, Pin 7500mAh ,25W.",Image="Vivo-V23e-1-2-7190.jpg"},
				new Product{Name="Vivo V25 Pro 5G ",Manufacturer="Vivo",Price=13990000,Quantity=65,Desciption="Chip Snapdragon 8 gen 1 , 8GB 128GB, Pin 4500mAh ,45W.",Image="vivo-v25-pro-5g-xanh-thumb-1-13990.jpg"},
				new Product{Name="Xiaomi 11T ",Manufacturer="Xiaomi",Price=13990000,Quantity=75,Desciption="Chip Snapdragon 8 gen 1 , 16GB 128GB, Pin 8500mAh ,25W.",Image="Xiaomi-11T-White-1-2-3-13900.jpg"},
				new Product{Name="Realme 9 ",Manufacturer="Realme",Price=5690000,Quantity=51,Desciption="Chip Snapdragon 8 gen 1 , 8GB 1TB, Pin 8500mAh ,20W.",Image="realme-9-4g-vang-thumb-1-5690.jpg"},
				new Product{Name="Realme 8 Series ",Manufacturer="Realme",Price=8690000,Quantity=99,Desciption="Chip Snapdragon 8 gen 1 , 6GB 128GB, Pin 4500mAh ,45W.",Image="realme-8-pro-vang-8690.jpg"},
				new Product{Name="Realme C11 Series  ",Manufacturer="Realme",Price=2390000,Quantity=32,Desciption="Chip Snapdragon 8 gen 1 , 8GB 512GB, Pin 4500mAh ,45W.",Image="realme-c11-2021-blue-1-2390.jpg"},
			};

			context.Product.AddRange(products);
			context.SaveChanges();
		}
	}
}
