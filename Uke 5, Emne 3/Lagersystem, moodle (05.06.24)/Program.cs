
using Lagersystem__moodle__05._06._24_;

var TheWarehouse = new Warehouse();

new Electronics("iphone", 3845, 12);
new Electronics("ipad", 1099.90, 15);

new Groceries("eggs", 40.50, 200424);
new Groceries("milk", 20, 300524);

new Clothes("top", 400, "s");
new Clothes("jeans", 1000, "l");

TheWarehouse.DisplayProducts();

var ProductToRemove = TheWarehouse.FindProduct("eggs");
if (ProductToRemove != null)
{
    TheWarehouse.RemoveProduct(ProductToRemove);
}

TheWarehouse.DisplayProducts();






