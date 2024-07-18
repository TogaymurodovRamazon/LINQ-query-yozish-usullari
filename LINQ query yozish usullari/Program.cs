
List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
// Query syntax
var querysyntax = from all in list
                  where all>8
                  select all;
Console.WriteLine(" To'plamdagi 8 dan katta element ");
foreach (var query in querysyntax)
{
    Console.Write( query +" ");
}
Console.WriteLine();

// Method syntax
var methodsyntax = list.Where(x => x < 8);
Console.WriteLine(" To'plamdagi 8 dan kichik element ");
foreach (var method in methodsyntax)
{
    Console.Write( method + " ");
}
Console.WriteLine();

// Mixed syntax
var mixedsyntax = (from all in list
                   select all).Max();
Console.Write(" To'plamdagi maxsimal element = " + mixedsyntax);