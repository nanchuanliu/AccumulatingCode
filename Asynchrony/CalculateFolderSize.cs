using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace AccumulatingCode.Asynchrony
{

    class CalculateFolderSize
    {
        public delegate long CalculateFolderSizeDelegate(string FolderName);

        private static CalculateFolderSizeDelegate d = CalculateFolderSize.Calculate;


        public CalculateFolderSize()
        {
            while (true)
            {
                Console.WriteLine("请输入文件夹名称（quit退出）：");
                string FolderName = Console.ReadLine();
                if (FolderName == "quit")
                    break;
                d.BeginInvoke(FolderName, ShowFolderSize, FolderName);
            }
        }

        public static long Calculate(string FolderName)
        {
            if (Directory.Exists(FolderName) == false)
            {
                throw new DirectoryNotFoundException("文件不存在！");
            }

            DirectoryInfo RootDir = new DirectoryInfo(FolderName);

            DirectoryInfo[] ChildDirs = RootDir.GetDirectories();
            FileInfo[] files = RootDir.GetFiles();

            long totalSize = 0;

            foreach (FileInfo file in files)
            {
                totalSize += file.Length;
            }


            foreach (DirectoryInfo dir in ChildDirs)
            {
                totalSize += Calculate(dir.FullName);
            }

            return totalSize;
        }


        public static void ShowFolderSize(IAsyncResult result)
        {
            //异步调用过程中发生的异常，需在异步调用的线程中捕获并处理
            //在EndInvoke()所在的代码处捕获异步调用抛出的异常
            try
            {
                long size = d.EndInvoke(result);

                //实现异步调用的同步，避免用户输入时系统信息输出
                while (Console.CursorLeft != 0)
                {
                    Thread.Sleep(2000);
                }

                Console.WriteLine("\n文件夹{0}的容量为：{1}字节\n", (string)result.AsyncState, size);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("您输入的文件夹不存在");
            }

        }
    }
}
