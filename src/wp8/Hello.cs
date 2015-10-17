
using System;
using WPCordovaClassLib.Cordova;
using WPCordovaClassLib.Cordova.Commands;
using WPCordovaClassLib.Cordova.JSON;
using Windows.Storage;
using System.Diagnostics;

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
        
        public async void folder(string path)
        {
            string name = JsonHelper.Deserialize<string[]>(path)[0];
            string message = "Hello " + name;
            //StorageFolder folder = ApplicationData.Current.LocalFolder;
            StorageFolder folder = await ApplicationData.Current.LocalFolder.CreateFolderAsync("myFolder", CreationCollisionOption.ReplaceExisting);
            var fpath = folder.Path;
            Debug.WriteLine("conSole ===>>> " + folder.Path);
            DispatchCommandResult(new PluginResult(PluginResult.Status.OK, fpath));

        }
        
    }
}
