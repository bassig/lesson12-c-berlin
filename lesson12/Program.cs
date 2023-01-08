// See https://aka.ms/new-console-template for more information
using lesson12;
using lesson12.Types;
using System.Xml.Serialization;

var readFun = new Dictionary<string, Func<Manager>>()
{
    {".xml",()=> new Xml() },
    {".json",()=> new Json() },
    {".excel",()=> new Excel() },
    {".csv",()=> new Csv() }
};
var writeFun = new Dictionary<string, Func<Manager>>()
{
    {"xml",()=> new Xml() },
    {"json",()=> new Json() },
    {"excel",()=> new Excel() },
    {"csv",()=> new Csv() }
};
Console.WriteLine("enter path");
string path = Console.ReadLine();
string ex = Path.GetExtension(path);
if (!readFun.ContainsKey(ex))
{
    Console.WriteLine("incorrect path");
    throw new Exception(message: "incorrect path");
}
Console.WriteLine("convert to?");
var des=Console.ReadLine();

if (!writeFun.ContainsKey(des))
{
    Console.WriteLine("incorrect type");
    throw new Exception(message: "incorrect type");
}
var m = readFun[ex].Invoke();
List<Person> lst = m.read(path);
var r=writeFun[des].Invoke();
r.write(lst);



