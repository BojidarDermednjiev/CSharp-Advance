namespace _01._Unique_Usernames
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        static void Main()
        {
            int countOfUsersNamesThatComing;
            HashSet<string> userNameList;
            GetInfo(out countOfUsersNamesThatComing, out userNameList);
            FillUserNameList(countOfUsersNamesThatComing, userNameList);
            IO(userNameList);
        }
        private static void GetInfo(out int countOfUsersNamesThatComing, out HashSet<string> userNameList)
        {
            countOfUsersNamesThatComing = int.Parse(Console.ReadLine());
            userNameList = new HashSet<string>();
        }
        private static void FillUserNameList(int countOfUsersNamesThatComing, HashSet<string> userNameList)
        {
            for (int currentUserName = 0; currentUserName < countOfUsersNamesThatComing; currentUserName++)
            {
                var userName = Console.ReadLine();
                userNameList.Add(userName);
            }
        }
        private static void IO(HashSet<string> userNameList)
        {
            Console.WriteLine(string.Join(Environment.NewLine, userNameList));
        }
    }
}
