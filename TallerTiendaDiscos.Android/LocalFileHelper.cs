using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TallerTiendaDiscos.Droid;
using TallerTiendaDiscos.Interface;
using Xamarin.Forms;


[assembly: Xamarin.Forms.Dependency(typeof(LocalFileHelper))]

namespace TallerTiendaDiscos.Droid
{
    public class LocalFileHelper : IStdLocHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string docFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            string libFolder = Path.Combine(docFolder);

            return Path.Combine(libFolder, filename);
        }
    }
}