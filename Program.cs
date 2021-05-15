using System;

namespace eo
{
    class Program
    {
        static void Main(string[] args)
        {
            new Phrase("Угадай число!", ConsoleColor.Yellow).Say();
            new FareWell(
                new Attempts((secret, times)=>{
                    int t = 0;
                    while (true)
                    {
                        if (++t > times)
                        {
                            new Phrase($"Вы проиграли ...это было число {secret.Value()}", ConsoleColor.DarkRed).Say();
                            break;
                        }
                        
                        var str = new VerboseDiff(
                                new Diff(new Guess(
                                    new Wellcom(
                                        new Phrase("Введите число от 1 до 100 > ")
                                        )
                                    ), secret)
                                ).value();
                        
                        if(str.Length == 0){
                            new Phrase("Победа!", ConsoleColor.Magenta).Say();
                            break;
                        }

                        new Phrase(str, ConsoleColor.Red).Say();
                    }
                }, new Secret())
            ).Say();  
        }
    }
}
