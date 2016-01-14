using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKit.Model;

namespace DevKit.UI.Helpers
{
    public class CommandHelper
    {
        private ShellOutput output = new ShellOutput();
        public ShellOutput ExecuteCommand(string command,string workingdir)
        {
            try
            {
                string path = System.Environment.GetEnvironmentVariable("path", EnvironmentVariableTarget.Machine);

                
                ProcessStartInfo cmdStartInfo = new ProcessStartInfo();
                cmdStartInfo.FileName = "cmd.exe";
                cmdStartInfo.RedirectStandardOutput = true;
                cmdStartInfo.RedirectStandardError = true;
                cmdStartInfo.RedirectStandardInput = true;
                cmdStartInfo.UseShellExecute = false;
                cmdStartInfo.CreateNoWindow = true;
                cmdStartInfo.Arguments = "/c " + command;
                cmdStartInfo.EnvironmentVariables["path"] = path;
                if (workingdir != null)
                    cmdStartInfo.WorkingDirectory = workingdir;

                Process cmdProcess = new Process();
                cmdProcess.StartInfo = cmdStartInfo;
                cmdProcess.ErrorDataReceived += cmd_Error;
                cmdProcess.OutputDataReceived += cmd_DataReceived;
                cmdProcess.EnableRaisingEvents = true;
                cmdProcess.Start();
                cmdProcess.BeginOutputReadLine();
                cmdProcess.BeginErrorReadLine();
                cmdProcess.WaitForExit();
                return output;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        void cmd_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if(e.Data != null)
                output.Output = e.Data;
        }

        void cmd_Error(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                output.IsError = true;
                output.Error = e.Data;
            } 
        }
    }
}
