using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Com esta class de Utils, o que é pretendido é guardar e consultar strings.
// Para este caso, é requerido métodos para consulta rápida e organizada.
// É necessário 4 funções.
// 1. Adicionar string
// 2. Obter todas as strings que comecem por uma letra escolhida.
// 3. Obter a string que foi inserida na posição X.
// 4. Se já foi inserida X string.
// 5. Máximo de 100 entradas.

// Não te esqueças de mudar o return type dos métodos.

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Utils ut = new Utils();
            for(int i = 0; i < 110; i++){
                if(!ut.AddNewString("a")){
                    Console.WriteLine($" {i}: Failed to add");
                }
            }
        }
    }

    public class Utils
    {
        string[] strings;
        int stringCount;

        public Utils(){
            strings = new string[100];
            stringCount = 0;
        }

        public bool AddNewString(string newString)
        {
            if(stringCount < 99){
                strings[stringCount] = newString;
                stringCount++;
                return true;
            }
            return false;
        }

        public void GetAllStringStartingWithLetter(char value)
        {
            
        }

        public void ContainsThisString(string hasString)
        {

        }

        public void StringAtPosition(int pos)
        {

        }
    }
}
