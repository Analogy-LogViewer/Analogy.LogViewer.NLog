﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.LogViewer.NLogProvider
{
    public static class Utils
    {
        public static string GetFileNameAsDataSource(string fileName)
        {
            string file = Path.GetFileName(fileName);
            return fileName.Equals(file) ? fileName : $"{file} ({fileName})";
        }
    }
    public static class GeneralExtensionMethods
    {    /// <summary>
        /// Case insensitive contains(string)
        /// </summary>
        /// <param name="source">the original string</param>
        /// <param name="toCheck">the string</param>
        /// <param name="comp">string comparison</param>
        /// <returns></returns>
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return string.IsNullOrEmpty(toCheck) || (!string.IsNullOrEmpty(source) && source.IndexOf(toCheck, comp) >= 0);
        }

        /// <summary>
        /// Case insensitive contains(string)
        /// </summary>
        /// <param name="source">the original list of strings</param>
        /// <param name="toCheck">the string</param>
        /// <param name="comp">string comparison</param>
        /// <returns></returns>
        public static bool Contains(this IEnumerable<string> source, string toCheck, StringComparison comp)
        {
            return string.IsNullOrEmpty(toCheck) ||
                   source.Any(itm => itm.Contains(toCheck, comp));
        }
    }
}