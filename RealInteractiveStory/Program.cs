string choice = "";

Console.WriteLine("Du befinner dig i ett stort hus som har brädor på fönstret och dörren framför dig");
Console.WriteLine("Du hör hur dem håller på att förstöra brädorna och hur det kommer fler och fler");
Console.WriteLine("Du måste springa till ett annat rum eftersom att du inte har något vapen");
Console.WriteLine("Det finns 2 rum du kan gå och låsa in dig, badrummet och köket");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "badrummet")
{
    Console.WriteLine("Du låser in dig i badrummet");
    Console.WriteLine("Du känner dig säker i en minut tills märker att det inte finns någon väg ut förutom dörren du kom in i");
    Console.WriteLine("Du hör hur dörren i hallen går ner och fotstegen komma närmare till badrummsdörren");
    Console.WriteLine("Dem börjar att slå på toa dörren och du är säker på att du kommer att dö i det här rummet, vilket du gör gg");
}
else if (choice == "köket")
{
    Console.WriteLine("Du springer in i köket och låser dörren bakom dig");
    Console.WriteLine("Köket är stort och har många lådor och verktyg");
    Console.WriteLine("Du kan höra hur hall dörren kommer ner och hur dem kommer närmare köket");
    Console.WriteLine("Du måste välja, ta en kökskniv som vapen eller göm dig i en av köksbänkarna");
    Console.WriteLine("vapen eller gömma");
}
  choice = Console.ReadLine();
  choice = choice.ToLower();

if (choice == "vapen")
{
    Console.WriteLine("Du tar en av de stora köksknivarna");
    Console.WriteLine("Köksdörren bryts och faller ner och dem kommer en efter en in i köket");
    Console.WriteLine("Du svingar kniven på den första och du lyckas hugga av armen på den, men den stannar inte");
    Console.WriteLine("Du blir snabbt överridande och dör");
}
else if (choice == "gömma")
{
    Console.WriteLine("Du öpnnar en av borsbänkarna och hoppar in i den och stänger den");
    Console.WriteLine("Du kan inte se men du hör hur köks dörren faller ner på marken och du hör flera fotsteg");
    Console.WriteLine("Du sitter kvar i köksbänken för vad som känns som flera timmar tills du är säker på att du inte kan höra några fotsteg");
    Console.WriteLine("Du kliver ut ur köksbänken och du ser inga av dem");
    Console.WriteLine("Du kan välja att gå tillbaka till hallen eller fortsätta gå in i huset");
    Console.WriteLine("hallen eller huset");
}
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "hallen")
{
    Console.WriteLine("Du går tillbaka till hallen");
    Console.WriteLine("Du märker hus dörren är på golvet och hur det är öppet utomhus");
    Console.WriteLine("Du lämnar huset och kollar aldrig tillbaka");
    Console.WriteLine("The End");
}
else if (choice == "huset")
{
    Console.WriteLine("Du går längre in i huset och hittar källaren");
    Console.WriteLine("Du tänker om du ska gå in eller inte men din nyfikenhet tar över och du går ner i källaren");
    Console.WriteLine("Du är nere i den mörka och fuktiga källaren med väldigt lite ljus");
    Console.WriteLine("Du letar runt efter något men du vet inte vad");
    Console.WriteLine("Du hittar en bomb i ett skåp och undrar varför den är där");
    Console.WriteLine("Du hör hur något är bakom dig och du är säker på att du kommer dö");
    Console.WriteLine("Välj, c4 eller bakom");
}
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "c4")
{
    Console.WriteLine("Du vågar inte att vända dig om och väljer att klicka på C4 knappen");
    Console.WriteLine("Hela huset sprängs och du ultra dör inkluderar det som var bakom dig");
    Console.WriteLine("gg du dog");
}
else if (choice == "bakom")
{
    Console.WriteLine("Du bestämmer dig själv för att vända dig om");
    Console.WriteLine("Bakom dig står Morgan Freeman");
    Console.WriteLine("Han visar dig vägen till säkerhet");
    Console.WriteLine("Du lever lyckligt i alla dina dagar");
    Console.WriteLine("Du Överlevde GG :D");
}
choice = Console.ReadLine();
choice = choice.ToLower();