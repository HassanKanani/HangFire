#region t








// See https://aka.ms/new-console-template for more information
// using palce;
// man hassan=new man ();
// hassan.NationalId=591;hassan.name="hk321";

// int? a=null;
// var b=a.GetType();
// var b=a.GetHashCode();
// var b=sizeof(a);
// var res=a<=13?"Les":"Larg";
// var res=a<9?100:0;
// while(a>=0){

// Console.WriteLine(a);
// a--;
// }
// for(int b=1;a>=b;b++){

// for (int i = 0; i < b; i++)
// {

//     System.Console.WriteLine("*");
// }
//     System.Console.WriteLine("#");
// }
// int  c=a ?? 12;if num on was null return num 2
// string[] name=new string[3];
// string name="jfhjkkahfafh";
// char[] all=name.ToCharArray();
// foreach (var item in all){

// System.Console.WriteLine(item);
// }
// 
// man m = new man(new List<I>());
// m.g();

// var t=typeof(woman);
// var me=t.GetElementType();
// var me1=t.GetConstructors();
// var me2=t.GetFields();
// var me3w=t.GetInterfaces(); 
// var me3wa=t.GetType(); 
// var me3a=t.GetProperties(); 
// var ame3a=t.GetMethods(); 
// var ass=t.GetMembers(); 
// var h=t.; 
//man m1=new man ("hasan",17);
//m1.g();
#endregion
using System.Reflection;

using System.Linq;
using System;
using taturial;


var assemblies = typeof(ICar).Assembly;

IEnumerable<Type> t=assemblies.GetExportedTypes().Where(n=>n.IsClass &&!n.IsAbstract&& n.IsPublic&& typeof(ICar).IsAssignableFrom(n));

if(t!=null){
// foreach (var item in t)
// {
// System.Console.WriteLine(item.FullName);
    
// }
 //foreach (Type type in t)
               // modelBuilder.Entity(type);
}