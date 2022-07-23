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
            ut.AddNewString("a");
            ut.AddNewString("abc");
            ut.AddNewString("daac");
            ut.AddNewString("sa");
            ut.AddNewString("abddf");
            ut.AddNewString("Adff");
            ut.AddNewString("Offs");
            ut.AddNewString("Lasagna");

            string[] aStrings = ut.GetAllStringStartingWithLetter('a');
            for(int i = 0; i < aStrings.Length; i++){
                Console.WriteLine(aStrings[i]);
            }

            bool test = ut.ContainsThisString("Lasagna");
            if(test){
                Console.WriteLine("Contains string");
            }
            else{
                Console.WriteLine("Does not contain string");
            }

            bool test2 = ut.ContainsThisString("lasagna");
            if (test2){
                Console.WriteLine("Contains string");
            }
            else{
                Console.WriteLine("Does not contain string");
            }

            string s = ut.StringAtPosition(5);
            Console.WriteLine(s);

            string s2 = ut.StringAtPosition(7);
            Console.WriteLine(s2);

            string s3 = ut.StringAtPosition(8);
            Console.WriteLine(s3);
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

        public string[] GetAllStringStartingWithLetter(char value)
        {
            List<string> strL = new List<string>(stringCount);
            char valueLower = char.ToLower(value);

            for (int i = 0; i < stringCount; i++){
                if(char.ToLower(strings[i][0]) == valueLower){
                    strL.Add(strings[i]);
                }
            }
            return strL.ToArray();
        }

        public bool ContainsThisString(string hasString)
        {
            for(int i = 0; i < stringCount; i++){
                if(strings[i] == hasString){
                    return true;
                }
            }
            return false;
        }

        public string StringAtPosition(int pos)
        {
            if(pos >= stringCount){
                return null;
            }
            return strings[pos];
        }
    }
}
