// See https://aka.ms/new-console-template for more information
namespace DotnetLists{
    class Program{
        static void Main(string[] args){
            Console.Clear();
            var meuArray = new int[5]{1,2,3,4,5};

            Console.WriteLine(meuArray[0]);
         
            for(var index=0; index<meuArray.Length; index++){
                Console.WriteLine(meuArray[index]);
            }

            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario(){Id=2579, Nome="Sebastiao"};

            foreach(var funcionario in funcionarios){
              Console.WriteLine(funcionario.Id +"- " + funcionario.Nome);
            }

        }

        public struct Funcionario{
            public int Id{get;set;}
            public string  Nome{get;set;}
        }
    }
}
