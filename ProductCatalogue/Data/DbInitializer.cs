
using ProductCatalogue.Data;
using ProductCatalogue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Type = ProductCatalogue.Models.Type;

namespace ProductCatalogue.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ShopContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            var products = new Product[]
            {
                //Women
                new Product{Name="Kjole med pufærmer", Color="Grøn/Småblomstret", Descriptions="Midi-kjole i vævet kvalitet af LivaEco™-viskose med trykt mønster. Kjolen har dyb V-udskæring og beklædte knapper foran. Asymmetrisk skæring under brystet og lange pufærmer med smal elastik forneden. Uden for.", Price=249, Size=10, Image="https://lp2.hm.com/hmgoepprod?set=quality%5B79%5D%2Csource%5B%2Fb0%2Fe3%2Fb0e36182d5404dffa33de2b6f734dba108ffde25.jpg%5D%2Corigin%5Bdam%5D%2Ccategory%5B%5D%2Ctype%5BDESCRIPTIVESTILLLIFE%5D%2Cres%5Bm%5D%2Chmver%5B1%5D&call=url[file:/product/main]"},
                new Product{Name="Ribstrikket top", Color="Beige", Descriptions="Tætsiddende top i ribstrikket kvalitet med firkantet udskæring foran og lange ærmer.", Price=179, Size=20, Image="https://lp2.hm.com/hmgoepprod?set=quality%5B79%5D%2Csource%5B%2Fbb%2F0f%2Fbb0f196a9a14402f966fb2a5bed303f8fd529bce.jpg%5D%2Corigin%5Bdam%5D%2Ccategory%5B%5D%2Ctype%5BDESCRIPTIVESTILLLIFE%5D%2Cres%5Bm%5D%2Chmver%5B1%5D&call=url[file:/product/main]"},
                new Product{Name="Vide bukser", Color="Sort", Descriptions="Bukser i vævet kvalitet af genvundet polyester. Bukserne har høj talje og lige, vide ben med pressefolder. Gylp med lynlås og skjult hægte og malle.", Price=299, Size=30, Image="https://lp2.hm.com/hmgoepprod?set=quality%5B79%5D%2Csource%5B%2F4a%2Fcf%2F4acf95ad45d864ebe5a0f4a69802ddc881be23b5.jpg%5D%2Corigin%5Bdam%5D%2Ccategory%5Bladies_trousers_highwaisted%5D%2Ctype%5BDESCRIPTIVESTILLLIFE%5D%2Cres%5Bm%5D%2Chmver%5B1%5D&call=url[file:/product/main]"},
                new Product{Name="Stylede bukser i lyocellmix", Color="Creme", Descriptions="Bukser i vævet kvalitet af lyocell- og viskoseblanding. Har høj talje med beklædt elastik og lige, vide ben med pressefolder. Skrå sidelommer.", Price=199, Size=30, Image="https://lp2.hm.com/hmgoepprod?set=quality%5B79%5D%2Csource%5B%2F31%2Fd2%2F31d2a5ffbe6b8c3aafa94f35dd66758f354c702f.jpg%5D%2Corigin%5Bdam%5D%2Ccategory%5B%5D%2Ctype%5BDESCRIPTIVESTILLLIFE%5D%2Cres%5Bm%5D%2Chmver%5B2%5D&call=url[file:/product/main]"},
                new Product{Name="Slip-ins", Color="Beige", Descriptions="Slip-ins i imiteret læder med beklædt hæl. Har bred rem over foden og firkantet tå. For i jersey af genvundet polyester og indersål i imiteret læder. Hælhøjde 8 cm.", Price=249, Size=30, Image="https://lp2.hm.com/hmgoepprod?set=quality%5B79%5D%2Csource%5B%2Fc8%2F2c%2Fc82ce245fb2e480a7796e75fbb2416480de5d3a0.jpg%5D%2Corigin%5Bdam%5D%2Ccategory%5B%5D%2Ctype%5BDESCRIPTIVESTILLLIFE%5D%2Cres%5Bm%5D%2Chmver%5B1%5D&call=url[file:/product/main]"},
                new Product{Name="Sweatshirtkjole", Color="Lysegråmeleret", Descriptions="Kort kjole i let sweatshirtkvalitet i bomuldsblanding. Kjolen har lav skuldersøm og lange ærmer. Er skåret forneden med rynkning og vid underdel. Ribkant i halsen og forneden på ærmerne.", Price=129, Size=30, Image="https://lp2.hm.com/hmgoepprod?set=quality%5B79%5D%2Csource%5B%2F95%2Fbc%2F95bc1e0463e328517a4edb3383b460507e9098bb.jpg%5D%2Corigin%5Bdam%5D%2Ccategory%5B%5D%2Ctype%5BDESCRIPTIVESTILLLIFE%5D%2Cres%5Bm%5D%2Chmver%5B2%5D&call=url[file:/product/main]"},
                new Product{Name="Let kjole", Color="Pudderrosa", Descriptions="Kort kjole i luftig, vævet kvalitet af viskose- og bomuldsblanding med krave og V-formet åbning foran. Kjolen har meget lav skuldersøm og lange ballonærmer med manchet og knaplukning.", Price=179, Size=30, Image="https://lp2.hm.com/hmgoepprod?set=quality%5B79%5D%2Csource%5B%2F34%2Fd7%2F34d7023d21dc22c8542d3f9afa7ae9b9485ef681.jpg%5D%2Corigin%5Bdam%5D%2Ccategory%5Bladies_dresses_shortdresses%5D%2Ctype%5BDESCRIPTIVESTILLLIFE%5D%2Cres%5Bm%5D%2Chmver%5B1%5D&call=url[file:/product/main]"}

                //Men


                //Kids

            };

            context.Products.AddRange(products);
            context.SaveChanges();

            var types = new Type[]
            {
                new Type{ TypeID=100, Title="Dresses"},
                new Type{ TypeID=101, Title="Top"},
                new Type{ TypeID=102, Title="Short"},
                new Type{ TypeID=103, Title="Blouses"},
                new Type{ TypeID=104, Title="Blazers"},
                new Type{ TypeID=105, Title="Knitted Sweater"},
                new Type{ TypeID=106, Title="Pants"},
                new Type{ TypeID=107, Title="Shoe"}
            };

            context.Types.AddRange(types);
            context.SaveChanges();

            var womens = new Women[]
            {
                new Women{ ProductID=1, TypeID=100},
                new Women{ ProductID=2, TypeID=101},
                new Women{ ProductID=3, TypeID=106},
                new Women{ ProductID=4, TypeID=106},
                new Women{ ProductID=5, TypeID=107},
                new Women{ ProductID=6, TypeID=100},
                new Women{ ProductID=7, TypeID=100}
            };

            context.Womens.AddRange(womens);
            context.SaveChanges();

            var mens = new Men[]
            {
                new Men{ ProductID=8, TypeID=107},
                new Men{ ProductID=9, TypeID=107}
            };


            context.Mens.AddRange(mens);
            context.SaveChanges();

            var kids = new Kid[]
{
                new Kid{ ProductID=11, TypeID=102},
                new Kid{ ProductID=12, TypeID=102}
};


            context.Kids.AddRange(kids);
            context.SaveChanges();
        }
    }
}
