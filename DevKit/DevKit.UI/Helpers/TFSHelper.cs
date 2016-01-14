using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DevKit.Model;

namespace DevKit.UI.Helpers
{
    public class TFSHelper
    {
        public static ShellOutput GetLatest(string path,TFSAuthModel login)
        {
            try
            {
                string command = "tf get \"" + path +  "\" /login:" + login.Username + "," + login.Password + " /noprompt";
                CommandHelper shell = new CommandHelper();
                return shell.ExecuteCommand(command,null);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public static ShellOutput Checkout(string path, TFSAuthModel login)
        {
            try
            {
                string command = "tf checkout \"" + path + "\" /login:" + login.Username + "," + login.Password + " /noprompt";
                CommandHelper shell = new CommandHelper();
                return shell.ExecuteCommand(command,null);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public static ShellOutput CheckIn(string comment,TFSAuthModel login)
        {
            try
            {
                string command = "tf checkin /comment:\"" + comment + "\" /login:" + login.Username + "," + login.Password + " /noprompt";
                CommandHelper shell = new CommandHelper();
                return shell.ExecuteCommand(command, null);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public static ShellOutput AddFile(string path,string name, TFSAuthModel login)
        {
            try
            {
                string command = "tf add "+ name + " /login:" + login.Username + "," + login.Password + " /noprompt";
                CommandHelper shell = new CommandHelper();
                return shell.ExecuteCommand(command, path);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public static ShellOutput AddFiles(string path, TFSAuthModel login)
        {
            try
            {
                string command = "tf add *.sql" + " /login:" + login.Username + "," + login.Password + " /noprompt";
                CommandHelper shell = new CommandHelper();
                return shell.ExecuteCommand(command, path);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }
    }
}
