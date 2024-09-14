using System; /* Contexto principal */

namespace CSharpHelloWorld  /* Da un contexto a el espacio en el que creamos ciertas clases o metodos */
{
    class HelloWorld
    {
        static void Main(string[] args){

            Console.WriteLine("Hola, C#");

            string myString = "esto es una cadena de texto";
            myString = "Aqui cambio el valor de la cadena de texto";
            Console.WriteLine(myString);

            int myInt = 7;
            myInt = myInt + 4;
            Console.WriteLine(myInt);
            Console.WriteLine(myInt - 1);

            double myDouble = 6.5;
            Console.WriteLine(myDouble);

            float myFloat = 6.5f;
            Console.WriteLine(myFloat);

            Console.WriteLine(myInt + myDouble + myFloat);

            bool myBool = true;
            Console.WriteLine(myBool);

            dynamic myDynamic = 6;
            myDynamic = "Mi dato dinamico ";
            Console.WriteLine(myDynamic + myFloat);

            //string myString2 = "Mi nueva cadena de texto";
            // var (redundante ya que luego del tipado va una variable)
            // En todo caso usar var myString2 = "hola" (ya sabe que es string debido a las comillas. Lo mismo sucede con otros tipos de datos)

            var myVar = "Mi variable de tipo indiferido";
            //myVar = 6; Error
            Console.WriteLine(myVar);

            Console.WriteLine($"El valor de mi entero es {myInt} y el de mi bool {myBool}");

            const string MyConst = "Mi constante"; //En constantes es obligatorio poner el tipo de dato
            Console.WriteLine(MyConst);

            //Estructuras

            var myArray = new string[] {"Sequeira", "Juan", "JuanDev"};
            Console.WriteLine(myArray[1]);

            myArray[2] = "36"; //Se puede reasignar valores fuera de un array pero no agregar nuevos valores o aumentar la longitud
            Console.WriteLine(myArray[2]);

            var myDictionary = new Dictionary<string, int> 
            {
                {"JuanDev", 36},
                {"Pepe", 25},
                {"Maria", 19}
            };

            Console.WriteLine(myDictionary["Maria"]);

            var mySet = new HashSet<string> {"JuanDev" ,"Pepe" ,"Maria", "Maria", "Papo"}; //Estructura sin orden y sin repetidos

            var myTuple = ("JuanDev" ,"Pepe" ,"Maria");
            Console.WriteLine(myTuple);

            //Bucles

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine(index);
            };

            foreach (var myItem in myArray)
            {
                Console.WriteLine(myItem);
            }


            foreach (var myItem in myDictionary)
            {
                Console.WriteLine(myItem);
            }

            foreach (var myItem in mySet)
            {
                Console.WriteLine(myItem);
            }

            // Flujos

            if (myInt == 11 && myBool == true)
            {
                Console.WriteLine("el valor es 11 y el bool es true");
            }
            else if(myInt == 12 || myBool == false)
            {
                Console.WriteLine("el valor es 12 o el bool es false");
            }
            else
            {
                Console.WriteLine("el valor no es 11 ni 12");
            }

            //Funciones
            Console.WriteLine(MyFunctionWithReturn(5));

            //Clases
            var myClass = new MyClass("juan");
            myClass.myName = "JuanDev"; /* Se puede modificar debido a la propiedad de set */
            Console.WriteLine(myClass.myName);
            myClass.miMetodo();

        } 
        static int MyFunctionWithReturn(int param)
            {
                return 10 + param;
            }

        class MyClass
        {
            public string myName {get; set;} /* La propiedad get permite acceder al valor referenciado mientras que la propiedad set permite modificarlo por fuera de la clase */

            public MyClass(string myName)
            {
                this.myName = myName;
            }

            public void miMetodo(){
                Console.WriteLine("este es mi metodo");
            }
        }
    }
}




