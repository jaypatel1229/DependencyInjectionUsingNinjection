using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NinjectEX
{
    public class Program 
    {
       
        static void Main(string[] args)
        {
            StandardKernel _Kernal = new StandardKernel();
            _Kernal.Load(Assembly.GetExecutingAssembly());
            IProduct _objePro = _Kernal.Get<IProduct>();
            Bl objBl = new Bl(_objePro);
            objBl.Insert();
            Console.ReadKey();
        }
        
    }
    public class NinjectBinding : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
           
            Bind<IProduct>().To<Dl>();    //Inject DL Using IProduct
        } 
    }
    class Bl
    {
        IProduct objPro;    // Create one Interface Variable
        public Bl(IProduct objIProduct) // Parameter Costructor pass the Interface variable
        {
            objPro = objIProduct;
        }

        public void Insert()  // Create Insert Method to Invoke DL Class method Through Interface Variable
        {
            objPro.InsertProduct(); 
        }

    }
    class Dl : IProduct
    {
        public string InsertProduct() //User Interface Method : 30
        {
            string Value = "Dependency Injection using Ninjection";
            Console.WriteLine(Value);
            return Value;
        }
    }
    interface IProduct
    {
        string InsertProduct(); // Create Method InsertProduct() : 22
    }
}
