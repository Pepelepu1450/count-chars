using System;
using System.Linq;
using System.Collections.Generic;

namespace count_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            //string data = "gwvuv syrbk sjrwf yspsm akpki yhznw wkpbt kpboq rjlpe nejku sxteo ihufz lgsiu jlypa lgqin ubave hjxav mgoeu gddnp mdicm dynxu pkcyf plubt aotmi ymbtr yczgi eacns oklwp buvve naymc wrbgv yjdif fjcgp xcyxs pnlcx fgrjt jvuzh pcvqq zhgwq keuyd cwdam weptg uidvz pfoug uvmaq wuzho utbln arsoj nnwid bjfeu mnqmp mziej phacb nymoz uqbzr fdzjp gmshg ckvjs jyeik xfgyp";
            // string data = "abcabda";
            string data = "asdfghjklñ qwertyuiop zxcvbnm asdfghjklñ zxcvbnm qwertyuiop asdfghzxcvb qwertyuiop";

            //Char count by char
            Dictionary<char, int> countByChar = new Dictionary<char, int>();

            //for each char in data, iterear lo caracteres uno por uno
            foreach (var c in data)
            {
                //saltearse espacios vacios
                if (c == ' ')
                {
                    continue;
                }
                //caracter es tipo char
                // 1. revisar si existe en el diccionario
                if (countByChar.ContainsKey(c))
                {
                    //3. Consultar valor actual del diccionario
                    countByChar.TryGetValue(c, out int conteoActual);
                    int siguienteC = conteoActual + 1;

                    //4. registrar diccionario
                    //4.1 borrar registro actual

                    countByChar.Remove(c);

                    //4.2 agregar valor
                    countByChar.Add(c, siguienteC);
                }
                else
                {
                    //2. agregar a diccionario con valor 1
                    countByChar.Add(c, 1);

                    //se termina la iteracion
                }
            }

            char queSeRepiteMasChar = ' ';
            int queSeRepiteMas = 0;

            foreach (var item in countByChar)
            {
                if (item.Value > queSeRepiteMas)
                {
                    queSeRepiteMasChar = item.Key;
                    queSeRepiteMas = item.Value;
                }
                System.Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            char queSeRepiteMenosChar = ' ';
            int queSeRepiteMenos = countByChar.Count;
            foreach (var item2 in countByChar)
            {
                if (item2.Value < queSeRepiteMenos)
                {
                    queSeRepiteMenosChar = item2.Key;
                    queSeRepiteMenos = item2.Value;
                }
                System.Console.WriteLine($"{item2.Key} -> {item2.Value}");
            }
            System.Console.WriteLine($"Conteo mas alto: {queSeRepiteMasChar} -> {queSeRepiteMas}");
            System.Console.WriteLine($"Conteo mas bajo: {queSeRepiteMenosChar} -> {queSeRepiteMenos}");
        }
    }
}
