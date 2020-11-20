using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Singleton
    {
        //PRIMERA FORMA PARA APLICAR SINGLETON

        /*
    
        private static Singleton instance = null;

        private Singleton()
        {
            
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }
        }

        */

        //SEGUNDA FORMA

        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

        //Para prueba
        public string name;

        //Para Ejemplo
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        private Singleton()
        {
            this.ProductName = "Sandía";
            this.ProductPrice = 375.25;
            this.ProductQuantity = 6;
        }

        public static Singleton Instance
        {
            get
            {
                return instance.Value;
            }
        }

    }
}
