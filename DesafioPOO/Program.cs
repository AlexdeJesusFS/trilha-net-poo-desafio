using DesafioPOO.Models;

Nokia nokiaPhone = new("124578", "Unbreakable", "123456789012347", 4);
Iphone iphonePhone = new("326598", "SEM", "123471234567890", 8);

Console.WriteLine("Com Nokia: ");
nokiaPhone.Ligar();
nokiaPhone.ReceberLigacao();
nokiaPhone.InstalarAplicativo("Block Buster");

Console.WriteLine("\nCom Iphone: ");
iphonePhone.Ligar();
iphonePhone.ReceberLigacao();
iphonePhone.InstalarAplicativo("Levie Ruve");
