using System;
using System.Globalization;
using NetDiagTool.Core.Models;

namespace NetDiagTool.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // PortStatus 
            // ScanProfile
            // ScanOptions
            // PortResult
            // HostResult
            // ScanResult
            // IPortProbe
            // IServiceDetector
            // IPortScanner
            // PortScannerService
            // TcpPortProbe
            // ServiceDetector
            // HostRangeParser


            // zobrazení viditělných znaků
            //for (int i = 0; i <= 0xFFFF; i++)
            //{
            //    char znak = (char)i;

            //    if (!char.IsControl(znak))
            //    {
            //        System.Console.WriteLine($"{i:X4}: {znak}");
            //    }
            //}

            // Testování zobrazení znaků
            var encoding = System.Console.OutputEncoding;

            for (int i = 0; i < 256; i++)
            {
                byte[] bytes = new byte[] { (byte)i };
                string znak = encoding.GetString(bytes); 
                System.Console.WriteLine($"{i}: {znak}");
            }


            System.Console.ReadKey();
        }
    }
}
