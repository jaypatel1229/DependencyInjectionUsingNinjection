using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectEX
{
    public class Program : Ninject.Modules.NinjectModule
    {
        static void Main(string[] args)
        {

        }
        public override void Load()
        {
            throw new NotImplementedException();
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
            return Value;
        }
    }
    interface IProduct
    {
        string InsertProduct(); // Create Method InsertProduct() : 22
    }
}
