using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theta {
    class TestingUtilities {

        public static void setDanger() {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public static void setSuccess() {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static void reset() {
            Console.ResetColor();
        }

        public static void testThetha(int precision) {
            Console.WriteLine("Testing thetha tests");
            var threshold = Math.Exp(-precision);
            Console.WriteLine($"With threshold: {threshold}");
            var table = new Dictionary<Tuple<double, double>, double>();
            table.Add(new Tuple<double, double>(2, 0.1), 1);
            table.Add(new Tuple<double, double>(2, 0.5), 0.822980316925566);
            table.Add(new Tuple<double, double>(2, 0.6), 0.6729063448212012);
            table.Add(new Tuple<double, double>(2, 10), 3.805205000580282E-16);
            table.Add(new Tuple<double, double>(19, 10), 0.2711290092155905);
            table.Add(new Tuple<double, double>(55, 10), -1.710234381118538E-16);
            foreach (var pair in table) {
                var args = pair.Key;
                var answer = pair.Value;
                var thetha = Utilities.Theta(args.Item1, args.Item2);
                var diff = thetha - answer;

                if (Math.Abs(diff) < threshold) {
                    setSuccess();
                } else {
                    setDanger();
                }
                Console.WriteLine($"With args a = {args.Item1}, x = {args.Item2} diff is {diff}");
                Console.WriteLine($"Expected {answer} got {thetha}");
                Console.WriteLine("");
                reset();
            }
        }
    }
}
