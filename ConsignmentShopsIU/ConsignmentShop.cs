using ConsignemntShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopsIU
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingBasketData = new List<Item>();

        BindingSource itemsBinding = new BindingSource();
        BindingSource basketBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;


        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            itemsListbox.DataSource = itemsBinding;

            itemsListbox.DisplayMember = "Display";
            itemsListbox.ValueMember = "Display";


            basketBinding.DataSource = shoppingBasketData;
            shoppingBasketListbox.DataSource = basketBinding;

            shoppingBasketListbox.DisplayMember = "Display";
            shoppingBasketListbox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            vendorListbox.DataSource = vendorsBinding;

            vendorListbox.DisplayMember = "Display";
            vendorListbox.ValueMember = "Display";




        }


        private void SetupData()
        {
            /*
            Vendor appVendor = new Vendor();
            appVendor.FirstName = "Cassie";
            appVendor.LastName = "Esdelle";
            appVendor.Commission = .5;

            store.Vendors.Add(appVendor);


            appVendor = new Vendor();
            appVendor.FirstName = "Eleora";
            appVendor.LastName = "Menssah";
            appVendor.Commission = .5;

            store.Vendors.Add(appVendor);
            */

            store.Vendors.Add(new Vendor { FirstName = "Shomar", LastName = "Mensah" });
            store.Vendors.Add(new Vendor { FirstName = "Cassie", LastName = "Mensah", });
            store.Vendors.Add(new Vendor { FirstName = "Eleora", LastName = "Mensah" });
            store.Vendors.Add(new Vendor { FirstName = "Tom", LastName = "Jake" });

            store.Items.Add(new Item
            {
                Title = "The Apocrypher",
                Description = "The Hidden Book",
                Price = 120.50M,
                Owner = store.Vendors[0],
            });


            store.Items.Add(new Item
            {
                Title = "Jashua",
                Description = "A book of Uprightness",
                Price = 80.40M,
                Owner = store.Vendors[1],
            });


            store.Items.Add(new Item
            {
                Title = "What Do You Say After You say Hello",
                Description = "A book about mind Games",
                Price = 12.12M,
                Owner = store.Vendors[2],
            });


            store.Items.Add(new Item
            {
                Title = "The Art Of War",
                Description = "A book of Governance",
                Price = 81.23M,
                Owner = store.Vendors[3],
            });


            store.Name = "House of Arts";
        }

        private void addtoBasket_Click(object sender, EventArgs e)
        {
            // figured is what is selected from the item list
            // Copy that item to the shopping basket
            // Do i remove the item from the item list > no/yes

            Item selectedItem = (Item)itemsListbox.SelectedItem;

            shoppingBasketData.Add(selectedItem);

            basketBinding.ResetBindings(false);

        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            // Mark each item in the basket as sold
            // clear basket
            foreach ( Item item in shoppingBasketData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1- (decimal)item.Owner.Commission) * item.Price;

            }

            shoppingBasketData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            storeProfitValue.Text = string.Format("{0:C}", storeProfit);

            basketBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
        }

        private void vendorListboxlabe_Click(object sender, EventArgs e)
        {

        }
    }

}
