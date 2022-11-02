using week3_hw;

internal class Program
{
    private static void Main(string[] args)
    {
        Product product = new Product(3000,0,"Klavye");
        Product product2 = new Product(1500, 1, "Yazıcı");

        var card1 = new CartItem(0,product,5);
        var card2 = new CartItem(1, product2, 7);

        ShoppingCart cart = new ShoppingCart();

        cart.Add(card1);
        cart.Add(card2);
        cart.Remove(1);
        cart.GetList();
        Console.WriteLine(cart.GetBalance());
    }
}