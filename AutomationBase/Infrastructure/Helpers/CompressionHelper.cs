﻿using ICSharpCode.SharpZipLib.Zip;

namespace AutomationBase.Infrastructure.Helpers
{
    public static class CompressionHelper
    {
        public static void ExtractZip(string filePath, string fileName)
        {
            var fastZip = new FastZip();

            // Will always overwrite if target filenames already exist
            fastZip.ExtractZip(fileName, filePath, null);
        }
    }
}
