using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nk = new Nokia("12345678", "Modelo 1", "@3#456", 64);

nk.Ligar();
nk.ReceberLigacao();
nk.InstalarAplicativo("Subway Surfers");

Iphone ip = new Iphone("56789432", "Modelo 2", "%#@789", 128);

ip.Ligar();
ip.ReceberLigacao();
ip.InstalarAplicativo("Facebook");