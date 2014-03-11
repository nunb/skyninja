﻿using System;

using NLog;

using SkyNinja.Core.Classes;
using SkyNinja.Core.Classes.Factories;

namespace SkyNinja.Core.Outputs.PlainText
{
    internal class PlainTextOutputFactory: OutputFactory
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public override string Description
        {
            get
            {
                return "Plain text files.";
            }
        }

        public override Connector CreateConnector(Uri uri)
        {
            string path = uri.LocalPath;
            Logger.Info("Using output path: {0}", path);
            return new PlainTextOutput();
        }
    }
}