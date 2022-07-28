using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Console_Application_Custom1   // namespace "name" => musíte přepsat name na váš namespace. (např. namespace ConsoleApplication1)
{
    class FajnMethods
    {
        public static List<string> log = new List<string>();


        // Vypíše jen "[   OK   ]", bez žádných parametrů
        public static void Ok()
        {
            var defaultColor = Console.ForegroundColor; Console.Write("[     ");
            Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("OK");
            Console.ForegroundColor = defaultColor; Console.WriteLine("     ] ");
        }
        // Vypíše "[   OK   ] msg"
        public static void Ok(string msg)
        {
            var defaultColor = Console.ForegroundColor; Console.Write("[     ");
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("OK");
            Console.ForegroundColor = defaultColor; Console.WriteLine("     ] " + msg);
        }
        // Vypíše "[   OK   ] msg", a můžete určit barvu zprávy (color_of_msg)
        public static void Ok(string msg, ConsoleColor color_of_msg)
        {
            var defaultColor = Console.ForegroundColor; Console.Write("[     ");
            Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("OK");
            Console.ForegroundColor = defaultColor; Console.Write("     ] ");
            Console.ForegroundColor = color_of_msg; Console.WriteLine(msg);
            Console.ForegroundColor = defaultColor;
        }
        // Vypíše "[   OK   ] msg: msg2", a můžete určit barvu msg2 (v parametru color_of_msg2)
        public static void Ok(string msg, string msg2, ConsoleColor color_of_msg2)
        {
            var defaultColor = Console.ForegroundColor; Console.Write("[     ");
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("OK");
            Console.ForegroundColor = defaultColor; Console.Write("     ] " + msg + ": ");
            Console.ForegroundColor = color_of_msg2; Console.WriteLine(msg2);
            Console.ForegroundColor = defaultColor;
        }


        // Error a Log fungují stejně jako Ok.

        public static void Error()
        {
            var defaultColor = Console.ForegroundColor; Console.Write("[    ");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("ERROR");
            Console.ForegroundColor = defaultColor; Console.WriteLine("   ]");
        }
        public static void Error(string msg)
        {
            var defaultColor = Console.ForegroundColor; Console.Write("[    ");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("ERROR");
            Console.ForegroundColor = defaultColor; Console.WriteLine("   ] " + msg);
        }
        public static void Error(string msg, ConsoleColor color_of_msg)
        {
            var defaultColor = Console.ForegroundColor; Console.Write("[    ");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("ERROR");
            Console.ForegroundColor = defaultColor; Console.Write("   ] ");
            Console.ForegroundColor = color_of_msg; Console.WriteLine(msg);
            Console.ForegroundColor = defaultColor;
        }
        public static void Error(string msg, string msg2, ConsoleColor color_of_msg2)
        {
            var defaultColor = Console.ForegroundColor; Console.Write("[    ");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("ERROR");
            Console.ForegroundColor = defaultColor; Console.Write("   ] " + msg + ": ");
            Console.ForegroundColor = color_of_msg2; Console.WriteLine(msg2);
            Console.ForegroundColor = defaultColor;
        }
        public static void Log()
        {
            var defaultColor = Console.ForegroundColor; Console.Write("[     ");
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("LOG");
            Console.ForegroundColor = defaultColor; Console.Write("    ] ");
            Console.WriteLine();
        }
        public static void Log(string msg)
        {
            var defaultColor = Console.ForegroundColor; Console.Write("[     ");
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("LOG");
            Console.ForegroundColor = defaultColor; Console.WriteLine("    ] " + msg);
        }
        public static void Log(string msg, ConsoleColor color_of_msg)
        {
            var defaultColor = Console.ForegroundColor; Console.Write("[     ");
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("LOG");
            Console.ForegroundColor = defaultColor; Console.Write("    ] ");
            Console.ForegroundColor = color_of_msg; Console.WriteLine(msg);
            Console.ForegroundColor = defaultColor;
        }
        public static void Log(string msg, string msg2, ConsoleColor color_of_msg2)
        {
            var defaultColor = Console.ForegroundColor; Console.Write("[     ");
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("LOG");
            Console.ForegroundColor = defaultColor; Console.Write("    ] " + msg + ": ");
            Console.ForegroundColor = color_of_msg2; Console.WriteLine(msg2);
            Console.ForegroundColor = defaultColor;
        }




        // Vypíše msg, se zvýrazněnými chary(highlight_letter)
        public static void Highlight(string msg, char highlighted_letter, ConsoleColor highlight_color)
        {
            for (int i = 0; i < msg.Length; i++)
            {
                var defaultColor = Console.ForegroundColor;
                if (msg[i] == highlighted_letter)
                {
                    Console.ForegroundColor = highlight_color;
                    Console.Write(msg[i]);
                    Console.ForegroundColor = defaultColor;
                    continue;
                }
                Console.Write(msg[i]);
            }
        }
        // Vypíše msg, se zvýrazněnými stringy(highlight_string)
        public static void Highlight(string msg, string highlighted_string, ConsoleColor highlight_color)
        {
            string temp = msg;
            int index = 0;
            var defaultColor = Console.ForegroundColor;
            while (true)
            {
                index = temp.IndexOf(highlighted_string);

                for (int i = 0; i < index; i++)
                {
                    Console.Write(temp[i]);

                }
                Console.ForegroundColor = highlight_color;
                Console.Write(highlighted_string);
                Console.ForegroundColor = defaultColor;
                temp = temp.Remove(0, index + highlighted_string.Length);
                if (!temp.Contains(highlighted_string))
                    break;
            }
            Console.ForegroundColor = defaultColor;
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i]);
            }
        }
        // To stejné, ale můžeme určit barvu msg
        public static void Highlight(string msg, char highlighted_letter, ConsoleColor color_of_msg, ConsoleColor color_of_highlighted_letter)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color_of_msg;
            for (int i = 0; i < msg.Length; i++)
            {
                if (msg[i] == highlighted_letter)
                {
                    Console.ForegroundColor = color_of_highlighted_letter;
                    Console.Write(msg[i]);
                    Console.ForegroundColor = color_of_msg;
                    continue;
                }
                Console.Write(msg[i]);
            }
            Console.ForegroundColor = defaultColor;
        }
        // To stejné, ale můžeme určit barvu msg
        public static void Highlight(string msg, string highlighted_string, ConsoleColor color_of_msg, ConsoleColor color_of_highlighted_string)
        {
            string temp = msg;
            int index = 0;
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color_of_msg;
            while (true)
            {
                index = temp.IndexOf(highlighted_string);
                for (int i = 0; i < index; i++)
                {
                    Console.Write(temp[i]);

                }
                Console.ForegroundColor = color_of_highlighted_string;
                Console.Write(highlighted_string);
                Console.ForegroundColor = color_of_msg;
                temp = temp.Remove(0, index + highlighted_string.Length);
                if (!temp.Contains(highlighted_string))
                    break;
            }
            Console.ForegroundColor = color_of_msg;
            for (int i = 0; i < temp.Length; i++)
            {

                Console.Write(temp[i]);
            }
            Console.ForegroundColor = defaultColor;
        }
        // Zvyraznuje podle indexu. Např.: "ABC is highlighted". Dáme index 3, takže se zvýrazní první tři písmena ABC.
        public static void Highlight(string msg, int index, ConsoleColor highlight_color)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = highlight_color;
            for (int i = 0; i < index; i++)
            {

                Console.Write(msg[i]);
            }
            Console.ForegroundColor = defaultColor;
            for (int i = index + 1; i < msg.Length; i++)
            {
                Console.Write(msg[i]);
            }

        }
        // Vypíše msg v určité barvě
        public static void Highlight(string msg, ConsoleColor color)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(msg);
            Console.ForegroundColor = defaultColor;

        }
        public static void br()
        {
            Console.WriteLine("________________________________________________________");
        }
        public static void Percentage(int from, int to)
        {
            Console.ResetColor();
            for (int i = from; i <= to; i++)
            {
                Console.Write($"\rLoading: {i}%");
                Thread.Sleep(10);
            }
        }
        public static void TestFajnMethods()
        {
            Highlight("Testing fajn methods: \n", "fajn methods", ConsoleColor.Red);
            br();
            Ok("Test1 Test1 Test1", "Test", ConsoleColor.Magenta);
            Thread.Sleep(24);
            Ok("Test2 Test2 Test2");
            Thread.Sleep(41);
            Ok();
            Ok("Test4 Test4 Test4", ConsoleColor.Magenta);
            Thread.Sleep(84);
            Error("Test5 Test5 Test5");
            Thread.Sleep(14);
            Error("Test6 Test6 Test6");
            Thread.Sleep(90);
            Log();
            Log("Test8 Test8 Test8");
            Thread.Sleep(57);
            Log("Test9 Test9 Test9", ConsoleColor.Magenta);
            Highlight("Test10 Test10 Test10", 'e', ConsoleColor.Magenta);
            Console.WriteLine();
            Thread.Sleep(94);
            Highlight("Test11 Test11 Test11", "est", ConsoleColor.Magenta);
            Console.WriteLine();
            Highlight("Test12 Test12 Test12", 'e', ConsoleColor.Magenta, ConsoleColor.Cyan);
            Console.WriteLine();
            Thread.Sleep(28);
            Highlight("Test12 Test12 Test12\n", "est", ConsoleColor.Magenta, ConsoleColor.Cyan);
            br();
            Log("Testing ended");
        }
        public static void ComplexLoading()
        {
            bool error = false;
            if (Console.ForegroundColor == ConsoleColor.White)
                Ok("Console Foreground Color set to default");
            else
            {
                error = true;
                Error("Console Foreground Color isn't conventional", "(" + Console.ForegroundColor.ToString() + ")", ConsoleColor.DarkRed);
            }
            Thread.Sleep(25);
            if (Console.BackgroundColor == ConsoleColor.Black)
                Ok("Console Background Color set to default");
            else
            {
                error = true;
                Error("Console Background Color isn't conventional", "(" + Console.BackgroundColor.ToString() + ")", ConsoleColor.DarkRed);
            }
            Ok("420 Console is high");
            Thread.Sleep(25);
            Ok("Sklep is locked == true");
            Thread.Sleep(16);
            Ok("Prestiž found");
            Thread.Sleep(22);
            TestFajnMethods();
            if (error)
            {
                while (true)
                {
                    Console.WriteLine("Errors were detected. Do you wish to switch back to default settings? [Y/n]");
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        Console.Clear();
                        Highlight("Running repair script\n", "Running repair script", ConsoleColor.Green);
                        Thread.Sleep(500);
                        Console.ResetColor();
                        Ok("Console color has been reset");
                        TestFajnMethods();
                        Ok("Repair script runned successfully");
                        break;
                    }
                    else
                        break;
                }
            }
        }
        public static void Percentage()
        {
            Console.ResetColor();
            string d = Console.Title;
            for (int i = 0; i <= 100; i++)
            {
                string s = $"\rLoading: {i}%";
                Console.Write(s);
                Console.Title = s;
                Thread.Sleep(10);
            }
            Console.Title = d;
        }
        public static void Percentage(int from, int to, int speed)
        {
            string d = Console.Title;
            for (int i = from; i <= to; i++)
            {
                string s = $"\rLoading: {i}%";
                Console.Write(s);
                Console.Title = s;
                Thread.Sleep(speed);
            }
            Console.Title = d;
        }
        public static int Contains(string s, string word)
        {
            string temp = s;
            int count = 0;
            while (true)
            {
                if (!temp.Contains(word))
                    break;
                else
                {
                    temp = temp.Remove(temp.IndexOf(word), word.Length);
                    count++;
                }
            }
            return count;
        }
        public static ConsoleColor RandomColor()
        {
            Random r = new Random();
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(r.Next(consoleColors.Length));
        }
        public static ConsoleColor RandomColor(bool black)
        {
            Random r = new Random();
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(r.Next(1, consoleColors.Length));
        }
        public static void Arch(ConsoleColor color)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            string arch1 = "\n\n                  /#\\\r\n" + "                 /##" + "#\\\r\n" + "                /###" + "##\\\r\n" + "               /####" + "###\\\r\n" + "              _ \"=#";
            string arch2 = "#####\\\r\n" + "             /##=,_" + "\\#####\\\r\n" + "            /#######" + "######\\\r\n" + "           /########";
            string arch3 = "#######\\\r\n" + "          /#########" + "########\\\r\n" + "         /##########" + "#########\\\r\n" + "        /########*\"" + "\"\"*########\\\r\n" + "       /#######/    " + "   \\#######\\\r\n";
            string arch4 = "      /########     " + "    ########\\\r\n" + "     /#########     " + "    ######m=,_\r\n" + "    /##########     " + "    ##########\\\r\n" + "   /######***       " + "      ***######\\\r" + "\n" + "  /###**            " + "           **###\\\r" + "\n" + " /**                " + "               **\\" + "\\\n\n";
            Console.Write(arch1);
            Console.Write(arch2);
            Console.Write(arch3);
            Console.Write(arch4);
            Console.ForegroundColor = defaultColor;
        }
        public static void Arch()
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            string arch1 = "\n\n                  /#\\\r\n" + "                 /##" + "#\\\r\n" + "                /###" + "##\\\r\n" + "               /####" + "###\\\r\n" + "              _ \"=#";
            string arch2 = "#####\\\r\n" + "             /##=,_" + "\\#####\\\r\n" + "            /#######" + "######\\\r\n" + "           /########";
            string arch3 = "#######\\\r\n" + "          /#########" + "########\\\r\n" + "         /##########" + "#########\\\r\n" + "        /########*\"" + "\"\"*########\\\r\n" + "       /#######/    " + "   \\#######\\\r\n";
            string arch4 = "      /########     " + "    ########\\\r\n" + "     /#########     " + "    ######m=,_\r\n" + "    /##########     " + "    ##########\\\r\n" + "   /######***       " + "      ***######\\\r" + "\n" + "  /###**            " + "           **###\\\r" + "\n" + " /**                " + "               **\\" + "\\\n\n";
            Console.Write(arch1);
            Console.Write(arch2);
            Console.Write(arch3);
            Console.Write(arch4);
            Console.ForegroundColor = defaultColor;
        }
        public static void Arch(ConsoleColor color1, ConsoleColor color2, ConsoleColor color3, ConsoleColor color4)
        {
            var defaultColor = Console.ForegroundColor;
            string arch1 = "\n\n                  /#\\\r\n" + "                 /##" + "#\\\r\n" + "                /###" + "##\\\r\n" + "               /####" + "###\\\r\n" + "              _ \"=#";
            string arch2 = "#####\\\r\n" + "             /##=,_" + "\\#####\\\r\n" + "            /#######" + "######\\\r\n" + "           /########";
            string arch3 = "#######\\\r\n" + "          /#########" + "########\\\r\n" + "         /##########" + "#########\\\r\n" + "        /########*\"" + "\"\"*########\\\r\n" + "       /#######/    " + "   \\#######\\\r\n";
            string arch4 = "      /########     " + "    ########\\\r\n" + "     /#########     " + "    ######m=,_\r\n" + "    /##########     " + "    ##########\\\r\n" + "   /######***       " + "      ***######\\\r" + "\n" + "  /###**            " + "           **###\\\r" + "\n" + " /**                " + "               **\\" + "\\\n\n";
            Console.ForegroundColor = color1;
            Console.Write(arch1);
            Console.ForegroundColor = color2;
            Console.Write(arch2);
            Console.ForegroundColor = color3;
            Console.Write(arch3);
            Console.ForegroundColor = color4;
            Console.Write(arch4);
            Console.ForegroundColor = defaultColor;
        }
        public static void Arch(int delay, ConsoleColor color1, ConsoleColor color2, ConsoleColor color3, ConsoleColor color4)
        {
            Random r = new Random();
            var defaultColor = Console.ForegroundColor;
            string arch1 = "\n\n                  /#\\\r\n" + "                 /##" + "#\\\r\n" + "                /###" + "##\\\r\n" + "               /####" + "###\\\r\n" + "              _ \"=#";
            string arch2 = "#####\\\r\n" + "             /##=,_" + "\\#####\\\r\n" + "            /#######" + "######\\\r\n" + "           /########";
            string arch3 = "#######\\\r\n" + "          /#########" + "########\\\r\n" + "         /##########" + "#########\\\r\n" + "        /########*\"" + "\"\"*########\\\r\n" + "       /#######/    " + "   \\#######\\\r\n";
            string arch4 = "      /########     " + "    ########\\\r\n" + "     /#########     " + "    ######m=,_\r\n" + "    /##########     " + "    ##########\\\r\n" + "   /######***       " + "      ***######\\\r" + "\n" + "  /###**            " + "           **###\\\r" + "\n" + " /**                " + "               **\\" + "\\\n\n";
            Console.ForegroundColor = color1;
            Console.Write(arch1);
            Thread.Sleep(r.Next(delay, 2 * delay));
            Console.ForegroundColor = color2;
            Console.Write(arch2);
            Thread.Sleep(r.Next(delay, 2 * delay));
            Console.ForegroundColor = color3;
            Console.Write(arch3);
            Thread.Sleep(r.Next(delay, 2 * delay));
            Console.ForegroundColor = color4;
            Console.Write(arch4);
            Thread.Sleep(r.Next(delay, 2 * delay));
            Console.ForegroundColor = defaultColor;
        }
        public static void Arch(int delay)
        {
            Random r = new Random();
            string arch1 = "\n\n                  /#\\\r\n" + "                 /##" + "#\\\r\n" + "                /###" + "##\\\r\n" + "               /####" + "###\\\r\n" + "              _ \"=#";
            string arch2 = "#####\\\r\n" + "             /##=,_" + "\\#####\\\r\n" + "            /#######" + "######\\\r\n" + "           /########";
            string arch3 = "#######\\\r\n" + "          /#########" + "########\\\r\n" + "         /##########" + "#########\\\r\n" + "        /########*\"" + "\"\"*########\\\r\n" + "       /#######/    " + "   \\#######\\\r\n";
            string arch4 = "      /########     " + "    ########\\\r\n" + "     /#########     " + "    ######m=,_\r\n" + "    /##########     " + "    ##########\\\r\n" + "   /######***       " + "      ***######\\\r" + "\n" + "  /###**            " + "           **###\\\r" + "\n" + " /**                " + "               **\\" + "\\\n\n";
            Console.Write(arch1);
            Thread.Sleep(r.Next(delay, 2 * delay));
            Console.Write(arch2);
            Thread.Sleep(r.Next(delay, 2 * delay));
            Console.Write(arch3);
            Thread.Sleep(r.Next(delay, 2 * delay));
            Console.Write(arch4);
        }
        public static void Arch(int delay, bool RandomColors)
        {
            var defaultColor = Console.ForegroundColor;
            Random r = new Random();
            string arch1 = "\n\n                  /#\\\r\n" + "                 /##" + "#\\\r\n" + "                /###" + "##\\\r\n" + "               /####" + "###\\\r\n" + "              _ \"=#";
            string arch2 = "#####\\\r\n" + "             /##=,_" + "\\#####\\\r\n" + "            /#######" + "######\\\r\n" + "           /########";
            string arch3 = "#######\\\r\n" + "          /#########" + "########\\\r\n" + "         /##########" + "#########\\\r\n" + "        /########*\"" + "\"\"*########\\\r\n" + "       /#######/    " + "   \\#######\\\r\n";
            string arch4 = "      /########     " + "    ########\\\r\n" + "     /#########     " + "    ######m=,_\r\n" + "    /##########     " + "    ##########\\\r\n" + "   /######***       " + "      ***######\\\r" + "\n" + "  /###**            " + "           **###\\\r" + "\n" + " /**                " + "               **\\" + "\\\n\n";
            Console.ForegroundColor = RandomColor(false);
            Console.Write(arch1);
            Thread.Sleep(r.Next(delay, 2 * delay));
            Console.ForegroundColor = RandomColor(false);
            Console.Write(arch2);
            Thread.Sleep(r.Next(delay, 2 * delay));
            Console.ForegroundColor = RandomColor(false);
            Console.Write(arch3);
            Console.ForegroundColor = RandomColor(false);
            Thread.Sleep(r.Next(delay, 2 * delay));
            Console.Write(arch4);
            Console.ForegroundColor = defaultColor;
        }
        public static bool LoginScreen()
        {
            bool debug = false;
            while (true)
            {
                Console.Write("username: ");
                string username = Console.ReadLine();
                Console.Write("password: ");
                switch (Console.ReadLine())
                {
                    case "1234":
                        if (username == "user")
                        {
                            Highlight("Login successful", "successful", ConsoleColor.Green);
                            goto End;
                        }
                        else
                            Error("Authentication failure");
                        break;
                    case "365247":
                        if (username == "admin")
                        {
                            Ok("Login successful");
                            debug = true;
                            goto End;
                        }
                        else
                            Error("Authentication failure");
                        break;
                    default:
                        Error("Authentication failure");
                        break;
                }
            }
        End:
            Arch(100);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Press any key to continue: ");
            Console.ReadLine();
            Console.Clear();
            if (debug)
                ComplexLoading();
            else
                Percentage();
            Console.Clear();
            return debug;
        }
        public static int RandomGenerator(int a)
        {
            Random x = new Random();
            a = x.Next(a);
            return a;
        }
        public static void ShowColors()
        {
            Random r = new Random();
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            List<ConsoleColor> colors = new List<ConsoleColor>();
            foreach (var item in consoleColors)
            {
                colors.Add((ConsoleColor)item);
            }
            foreach (var item in colors)
            {
                Console.ForegroundColor = item;
                Console.WriteLine(item.ToString());

            }
            foreach (var item in colors)
            {
                Console.BackgroundColor = item;
                Console.WriteLine(item.ToString());
            }
            Console.ResetColor();

        }
        public static void FuckTheScreen()
        {
            while (true)
            {
                Console.ForegroundColor = RandomColor();
                Console.BackgroundColor = RandomColor();
                List<char> shits = new List<char>() { '<', '>', '#', '?', ']', '[', ';', '*', '!', '%', '@', '$', '`', '~', '\\', ' ', ' ', ' ', ' ', ' ', ' ', };
                Console.Write(' ');

            }

        }
        public static void FuckTheScreen(bool pain)
        {
            while (true)
            {
                Console.ForegroundColor = RandomColor();
                Console.BackgroundColor = RandomColor();
                List<char> shits = new List<char>() { '<', '>', '#', '?', ']', '[', ';', '*', '!', '%', '@', '$', '`', '~', '\\', ' ', ' ', ' ', ' ', ' ', ' ', };
                Random r = new Random();
                Console.Write(shits[r.Next(0, shits.Count)]);

            }

        }
        public static int MaxValue(int[] p)
        {
            int a = -2147483648;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] > a)
                    a = p[i];
            }
            return a;
        }
        public static int MaxValue(List<int> p)
        {
            int a = -2147483648;
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i] > a)
                    a = p[i];
            }
            return a;
        }
        public static int MinValue(int[] p)
        {
            int a = 2147483647;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] < a)
                    a = p[i];
            }
            return a;
        }
        public static int MinValue(List<int> p)
        {
            int a = 2147483647;
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i] < a)
                    a = p[i];
            }
            return a;
        }
        public static void ShowArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Highlight("[  " + i + "  ]: ", i.ToString(), ConsoleColor.Green);
                Highlight(i.ToString(), i.ToString(), ConsoleColor.Red);
                Console.WriteLine();
            }
        }
        public static void WriteRan(string s)
        {
            var dC = Console.ForegroundColor;
            for (int i = 0; i < s.Length; i++)
            {
                Console.ForegroundColor = RandomColor(false);
                Console.Write(s[i]);
            }
            Console.WriteLine();
            Console.ForegroundColor = dC;
        }
        public static string ReadLine()
        {
            string s = Console.ReadLine();
            log.Add(s);
            return s;
        }
        public static void ShowLog()
        {
            for (int i = 0; i < log.Count; i++)
            {
                Console.WriteLine(i + 1 + "|" + log[i]);
            }
        }
        public static double FromBinToDouble(string s)
        {
            double a = 0;
            int temp = 0;
            for (int i = s.Length - 1; i > -1; i--)
            {
                if (s[temp] == '1')
                    a += Math.Pow(2, i);
                temp++;



            }
            return a;
        }
        public static string InvertBinNum(string s)
        {
            string ret = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0')
                    ret += "1";
                if (s[i] == '1')
                    ret += "0";
            }
            return ret;
        }





    }
}
