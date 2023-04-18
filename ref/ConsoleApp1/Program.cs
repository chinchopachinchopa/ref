using System;
using System.Reflection;

namespace LazyClassMethods
{
    class Program
    {
        public static object LazyType;

        static void Main()
        {
            Type Type = typeof(System.Lazy<>);
            Console.WriteLine($"Имя класса: {Type.Name}\n");
            Console.WriteLine("Методы:");
            MethodInfo[] methods = Type.GetMethods();
            foreach (MethodInfo method in methods)
            { 
                Console.WriteLine($"Имя метода: {method.Name}");
                Console.WriteLine($"IsAbstract: {method.IsAbstract}");
                Console.WriteLine($"IsFamily: {method.IsFamily}");
                Console.WriteLine($"IsFamilyAndAssembly: {method.IsFamilyAndAssembly}");
                Console.WriteLine($"IsFamilyOrAssembly: {method.IsFamilyOrAssembly}");
                Console.WriteLine($"IsAssembly: {method.IsAssembly}");
                Console.WriteLine($"IsPrivate: {method.IsPrivate}");
                Console.WriteLine($"IsPublic: {method.IsPublic}");
                Console.WriteLine($"IsConstructor: {method.IsConstructor}");
                Console.WriteLine($"IsStatic: {method.IsStatic}");
                Console.WriteLine($"IsVirtual: {method.IsVirtual}");
                Console.WriteLine($"ReturnType: {method.ReturnType}\n");
            }
            Console.WriteLine("\nКонструкторы:");
            ConstructorInfo[] constructors = Type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            { 
                Console.WriteLine($"Имя конструктора: {constructor.Name}");
                Console.WriteLine($"IsFamily: {constructor.IsFamily}");
                Console.WriteLine($"IsFamilyAndAssembly: {constructor.IsFamilyAndAssembly}");
                Console.WriteLine($"IsFamilyOrAssembly: {constructor.IsFamilyOrAssembly}");
                Console.WriteLine($"IsAssembly: {constructor.IsAssembly}");
                Console.WriteLine($"IsPrivate: {constructor.IsPrivate}");
                Console.WriteLine($"IsPublic: {constructor.IsPublic}\n");
            }
            Console.WriteLine("\nПоля:"); FieldInfo[] fields = Type.GetFields();
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine($"Имя поля: {field.Name}");
                Console.WriteLine($"IsFamily: {field.IsFamily}");
                Console.WriteLine($"IsFamilyAndAssembly: {field.IsFamilyAndAssembly}");
                Console.WriteLine($"IsFamilyOrAssembly: {field.IsFamilyOrAssembly}");
                Console.WriteLine($"IsAssembly: {field.IsAssembly}");
                Console.WriteLine($"IsPrivate: {field.IsPrivate}");
                Console.WriteLine($"IsPublic: {field.IsPublic}");
                Console.WriteLine($"IsStatic: {field.IsStatic}\n");
            }
            Console.WriteLine("\nСвойства:");
            PropertyInfo[] properties = Type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"Имя Свойства: {property.Name}");
                Console.WriteLine($"Attributes: {property.Attributes}");
                Console.WriteLine($"CanRead: {property.CanRead}");
                Console.WriteLine($"CanWrite: {property.CanWrite}");
                Console.WriteLine($"GetMethod: {property.GetMethod}");
                Console.WriteLine($"SetMethod: {property.SetMethod}");
                Console.WriteLine($"PropertyType: {property.PropertyType}\n");
            }
        }
    }
}

