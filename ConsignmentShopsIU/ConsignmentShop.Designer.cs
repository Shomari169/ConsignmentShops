namespace ConsignmentShopsIU
{
    partial class ConsignmentShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.itemslistboxlabel = new System.Windows.Forms.Label();
            this.addtoBasket = new System.Windows.Forms.Button();
            this.shoppingListboxLabel = new System.Windows.Forms.Label();
            this.shoppingBasketListbox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListboxlabe = new System.Windows.Forms.Label();
            this.vendorListbox = new System.Windows.Forms.ListBox();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consignment Shop App";
            // 
            // itemsListbox
            // 
            this.itemsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.ItemHeight = 24;
            this.itemsListbox.Location = new System.Drawing.Point(23, 105);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(385, 196);
            this.itemsListbox.TabIndex = 1;
            // 
            // itemslistboxlabel
            // 
            this.itemslistboxlabel.AutoSize = true;
            this.itemslistboxlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemslistboxlabel.Location = new System.Drawing.Point(18, 73);
            this.itemslistboxlabel.Name = "itemslistboxlabel";
            this.itemslistboxlabel.Size = new System.Drawing.Size(146, 29);
            this.itemslistboxlabel.TabIndex = 2;
            this.itemslistboxlabel.Text = "Store items";
            // 
            // addtoBasket
            // 
            this.addtoBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtoBasket.Location = new System.Drawing.Point(489, 189);
            this.addtoBasket.Name = "addtoBasket";
            this.addtoBasket.Size = new System.Drawing.Size(179, 31);
            this.addtoBasket.TabIndex = 3;
            this.addtoBasket.Text = "Add To Basket->>";
            this.addtoBasket.UseVisualStyleBackColor = true;
            this.addtoBasket.Click += new System.EventHandler(this.addtoBasket_Click);
            // 
            // shoppingListboxLabel
            // 
            this.shoppingListboxLabel.AutoSize = true;
            this.shoppingListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingListboxLabel.Location = new System.Drawing.Point(720, 73);
            this.shoppingListboxLabel.Name = "shoppingListboxLabel";
            this.shoppingListboxLabel.Size = new System.Drawing.Size(211, 29);
            this.shoppingListboxLabel.TabIndex = 5;
            this.shoppingListboxLabel.Text = "Shopping Basket";
            // 
            // shoppingBasketListbox
            // 
            this.shoppingBasketListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingBasketListbox.FormattingEnabled = true;
            this.shoppingBasketListbox.ItemHeight = 24;
            this.shoppingBasketListbox.Location = new System.Drawing.Point(725, 105);
            this.shoppingBasketListbox.Name = "shoppingBasketListbox";
            this.shoppingBasketListbox.Size = new System.Drawing.Size(385, 196);
            this.shoppingBasketListbox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makePurchase.Location = new System.Drawing.Point(1006, 307);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(104, 31);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // vendorListboxlabe
            // 
            this.vendorListboxlabe.AutoSize = true;
            this.vendorListboxlabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListboxlabe.Location = new System.Drawing.Point(18, 349);
            this.vendorListboxlabe.Name = "vendorListboxlabe";
            this.vendorListboxlabe.Size = new System.Drawing.Size(110, 29);
            this.vendorListboxlabe.TabIndex = 8;
            this.vendorListboxlabe.Text = "Vendors";
            this.vendorListboxlabe.Click += new System.EventHandler(this.vendorListboxlabe_Click);
            // 
            // vendorListbox
            // 
            this.vendorListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListbox.FormattingEnabled = true;
            this.vendorListbox.ItemHeight = 24;
            this.vendorListbox.Location = new System.Drawing.Point(23, 381);
            this.vendorListbox.Name = "vendorListbox";
            this.vendorListbox.Size = new System.Drawing.Size(385, 196);
            this.vendorListbox.TabIndex = 7;
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitLabel.Location = new System.Drawing.Point(720, 349);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(152, 29);
            this.storeProfitLabel.TabIndex = 9;
            this.storeProfitLabel.Text = "Store Profit:";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.Location = new System.Drawing.Point(918, 349);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(76, 29);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "£0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.vendorListboxlabe);
            this.Controls.Add(this.vendorListbox);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingListboxLabel);
            this.Controls.Add(this.shoppingBasketListbox);
            this.Controls.Add(this.addtoBasket);
            this.Controls.Add(this.itemslistboxlabel);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox itemsListbox;
        private System.Windows.Forms.Label itemslistboxlabel;
        private System.Windows.Forms.Button addtoBasket;
        private System.Windows.Forms.Label shoppingListboxLabel;
        private System.Windows.Forms.ListBox shoppingBasketListbox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Label vendorListboxlabe;
        private System.Windows.Forms.ListBox vendorListbox;
        private System.Windows.Forms.Label storeProfitLabel;
        private System.Windows.Forms.Label storeProfitValue;
    }
}

