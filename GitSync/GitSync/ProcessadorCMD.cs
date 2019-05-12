﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace GitSync
{
    class ProcessadorCMD
    {

        ProcessStartInfo InfoProcCMD { get;  }

        public ProcessadorCMD()
        {
            InfoProcCMD = new ProcessStartInfo("cmd")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
        }
        private Boolean ExecutarComandoCMD(String comando)
        {
            try
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process()
                {
                    StartInfo = InfoProcCMD                    
                };
                proc.Start();
                string result = proc.StandardOutput.ReadToEnd();
                Console.WriteLine(result);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}