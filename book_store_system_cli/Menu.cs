using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace book_store_system_cli
{
    internal class Menu : Account
    {
        public void Start()
        {
            Console.WriteLine(" _______                       __               ______    __                                           ______                         __                              __     __    __   \r\n/       \\                     /  |             /      \\  /  |                                         /      \\                       /  |                            /  |   /  | _/  |  \r\n$$$$$$$  |  ______    ______  $$ |   __       /$$$$$$  |_$$ |_     ______    ______    ______        /$$$$$$  | __    __   _______  _$$ |_     ______   _____  ____  $$ |   $$ |/ $$ |  \r\n$$ |__$$ | /      \\  /      \\ $$ |  /  |      $$ \\__$$// $$   |   /      \\  /      \\  /      \\       $$ \\__$$/ /  |  /  | /       |/ $$   |   /      \\ /     \\/    \\ $$ |   $$ |$$$$ |  \r\n$$    $$< /$$$$$$  |/$$$$$$  |$$ |_/$$/       $$      \\$$$$$$/   /$$$$$$  |/$$$$$$  |/$$$$$$  |      $$      \\ $$ |  $$ |/$$$$$$$/ $$$$$$/   /$$$$$$  |$$$$$$ $$$$  |$$  \\ /$$/   $$ |  \r\n$$$$$$$  |$$ |  $$ |$$ |  $$ |$$   $$<         $$$$$$  | $$ | __ $$ |  $$ |$$ |  $$/ $$    $$ |       $$$$$$  |$$ |  $$ |$$      \\   $$ | __ $$    $$ |$$ | $$ | $$ | $$  /$$/    $$ |  \r\n$$ |__$$ |$$ \\__$$ |$$ \\__$$ |$$$$$$  \\       /  \\__$$ | $$ |/  |$$ \\__$$ |$$ |      $$$$$$$$/       /  \\__$$ |$$ \\__$$ | $$$$$$  |  $$ |/  |$$$$$$$$/ $$ | $$ | $$ |  $$ $$/__  _$$ |_ \r\n$$    $$/ $$    $$/ $$    $$/ $$ | $$  |      $$    $$/  $$  $$/ $$    $$/ $$ |      $$       |      $$    $$/ $$    $$ |/     $$/   $$  $$/ $$       |$$ | $$ | $$ |   $$$//  |/ $$   |\r\n$$$$$$$/   $$$$$$/   $$$$$$/  $$/   $$/        $$$$$$/    $$$$/   $$$$$$/  $$/        $$$$$$$/        $$$$$$/   $$$$$$$ |$$$$$$$/     $$$$/   $$$$$$$/ $$/  $$/  $$/     $/ $$/ $$$$$$/ \r\n                                                                                                               /  \\__$$ |                                                               \r\n                                                                                                               $$    $$/                                                                \r\n                                                                                                                $$$$$$/                                                                 \r\n\r\n");
            Login();
        }
        private static bool Login()
        {
            bool access;
            string inputAccount, inputPassWords;
            while (true)
            {
                Console.WriteLine("\t[ Login ]");
                Console.Write("Account :");
                inputAccount = Console.ReadLine();
                Console.Write("Passwds :");
                inputPassWords = Console.ReadLine();
                if( inputAccount || inputPassWords != null)
                {
                    //open Db and Compare to list of user and password;
                }
                else
                {
                    Console.WriteLine("Error Null Input!!!");
                }
            }
            
        }
            
        }
    }
}
