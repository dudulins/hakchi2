﻿using com.clusterrr.Famicom;
using com.clusterrr.hakchi_gui.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.XPath;

namespace com.clusterrr.hakchi_gui
{
    public class SmsGame : NesMiniApplication
    {
        public const char Prefix = 'M';
        public static Image DefaultCover { get { return Resources.blank_sms; } }
        internal const string DefaultApp = "/bin/sms";

        public SmsGame(string path, bool ignoreEmptyConfig)
            : base(path, ignoreEmptyConfig)
        {
        }
    }
}

