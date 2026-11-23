// Pedido 1

Address address1 = new Address(
    "Rua Central",
    "Caçapava",
    "SP",
    "Brasil");

Customer customer1 =
    new Customer(
        "Julio Oliveira",
        address1);

List<Product> products1 =
    new List<Product>();

products1.Add(
    new Product(
        "Notebook",
        "1001",
        3500,
        1));

products1.Add(
    new Product(
        "Mouse",
        "1002",
        100,
        2));

Order order1 =
    new Order(
        products1,
        customer1);

// Pedido 2

Address address2 = new Address(
    "123 Main Street",
    "New York",
    "NY",
    "USA");

Customer customer2 =
    new Customer(
        "John Smith",
        address2);

List<Product> products2 =
    new List<Product>();

products2.Add(
    new Product(
        "Keyboard",
        "2001",
        150,
        1));

products2.Add(
    new Product(
        "Monitor",
        "2002",
        1200,
        1));

Order order2 =
    new Order(
        products2,
        customer2);

// Exibir Pedido 1

Console.WriteLine("=== PEDIDO 1 ===");

order1.DisplayPackingLabel();
order1.DisplayShippingLabel();

Console.WriteLine(
    $"Total: R$ {order1.CalculateTotalCost()}");

Console.WriteLine();

Console.WriteLine("--------------------------------");


// Exibir Pedido 2

Console.WriteLine("=== PEDIDO 2 ===");

order2.DisplayPackingLabel();
order2.DisplayShippingLabel();

Console.WriteLine(
    $"Total: R$ {order2.CalculateTotalCost()}");