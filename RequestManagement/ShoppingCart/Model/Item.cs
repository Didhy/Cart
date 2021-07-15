using System.ComponentModel.DataAnnotations;


namespace ShoppingCart.Model
{
    class Item
    {
            [Key]
            public string ItemId { get; set; }

            public string CartId { get; set; }

            public int Quantity { get; set; }

            public System.DateTime DateCreated { get; set; }

            public int ProductId { get; set; }


    }
}
