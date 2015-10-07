
using System;
using WPCordovaClassLib.Cordova;
using WPCordovaClassLib.Cordova.Commands;
using WPCordovaClassLib.Cordova.JSON;

namespace WPCordovaClassLib.Cordova.Commands
{
    public class Hello : BaseCommand
    {
        public void greet(string args)
        {
            string name = JsonHelper.Deserialize<string[]>(args)[0];
            string message = "Hello " + name;
            PluginResult result = new PluginResult(PluginResult.Status.OK, message);
            DispatchCommandResult(result);
        }
    }
}
