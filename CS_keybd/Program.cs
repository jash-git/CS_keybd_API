using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;//DLL
using System.Text;
using System.Threading;
using System.Threading.Tasks;//SLEEP
//https://blog.csdn.net/u014434080/article/details/50838117
//https://www.jianshu.com/p/a0c88a765bfd
namespace CS_keybd
{
    class Program
    {
        [DllImport("user32")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,uint dwExtraInfo);
        static void Main(string[] args)
        {
            /*
            //單純數字 & 英文
            do
            {

                for (int i=48;i<59;i++)
                {
                    keybd_event((byte)i, 0, 0, 0); //按下i
                    keybd_event((byte)i, 0, 2, 0); //按下后松开i
                    Thread.Sleep(400);
                }
                Thread.Sleep(400);
                keybd_event(13, 0, 0, 0);// ENTER key down
                keybd_event(13, 0, 2, 0);// ENTER key up
                

                for (int j= 65; j < 91; j++)
                {
                    keybd_event((byte)j, 0, 0, 0); //按下j
                    keybd_event((byte)j, 0, 2, 0); //按下后松开j
                    Thread.Sleep(400);
                }
                Thread.Sleep(400);
                keybd_event(13, 0, 0, 0);// ENTER key down
                keybd_event(13, 0, 2, 0);// ENTER key up
                

            }
            while (true);
            */

            //---
            //語系切換
            keybd_event(0x11, 0, 0, 0);  //0x11---ctrl  按下
            keybd_event(32, 0, 0, 0); // 32--空格键按下
            Thread.Sleep(400);
            keybd_event(32, 0, 0x02, 0);// 32--空格键弹起
            keybd_event(0x11, 0, 0x02, 0); //0x11---ctrl弹起 
            Thread.Sleep(400);
            //---語系切換
            do
            {
                //注音 天 中文輸入模擬
                //W
                keybd_event(0x57, 0, 0, 0);
                keybd_event(0x57, 0, 0x02, 0);
                Thread.Sleep(400);
                //U
                keybd_event(0x55, 0, 0, 0);
                keybd_event(0x55, 0, 0x02, 0);
                Thread.Sleep(400);
                //0
                keybd_event(0x30, 0, 0, 0);
                keybd_event(0x30, 0, 0x02, 0);
                Thread.Sleep(400);

                keybd_event(32, 0, 0, 0); // 32--空格键按下
                keybd_event(32, 0, 0x02, 0);// 32--空格键弹起
                Thread.Sleep(400);

                //確定選字
                keybd_event(13, 0, 0, 0);// ENTER key down
                keybd_event(13, 0, 2, 0);// ENTER key up
            }
            while (true);
        }
    }
}
