using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> lista = new List<int>
        {
            2386737, 2409300, 2409594, 2413939, 2422692, 2465146, 2475577, 2476753,
            2476936, 2477476, 2477800, 2478521, 2482280, 2499369, 2510733, 2519729,
            2552088, 2567220, 2569608, 2572493, 2576498, 2608572, 2634578, 2636307,
            2639731, 2662153, 2702548, 2713341, 2741581, 2750239, 2766023, 2782570,
            2832579, 2858140, 2861743, 2867394, 2869390, 2870087, 2872811, 2874805,
            2875823, 2894631, 2896637, 2902958, 2902991, 2906911, 2933310, 2933679,
            2935101, 2935312, 2935447, 2936523, 2939890, 2952864
        };

        var repetidos = lista.GroupBy(x => x).Where(group => group.Count() > 1).Select(group => group.Key).ToList();

        if (repetidos.Any())
        {
            Console.WriteLine("Números repetidos:");
            foreach (var repetido in repetidos)
            {
                Console.WriteLine(repetido);
            }
        }
        else
        {
            Console.WriteLine("Nenhum número repetido na lista.");
        }
    }
}
