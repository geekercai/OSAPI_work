﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using OSAPI;

namespace OSAPI.Struct
{

    [Flags]
    public enum OpenSaveFileDialgueFlags : int
    {
        OFN_READONLY = 0x1,
        OFN_OVERWRITEPROMPT = 0x2,
        OFN_HIDEREADONLY = 0x4,
        OFN_NOCHANGEDIR = 0x8,
        OFN_SHOWHELP = 0x10,
        OFN_ENABLEHOOK = 0x20,
        OFN_ENABLETEMPLATE = 0x40,
        OFN_ENABLETEMPLATEHANDLE = 0x80,
        OFN_NOVALIDATE = 0x100,
        OFN_ALLOWMULTISELECT = 0x200,
        OFN_EXTENSIONDIFFERENT = 0x400,
        OFN_PATHMUSTEXIST = 0x800,
        OFN_FILEMUSTEXIST = 0x1000,
        OFN_CREATEPROMPT = 0x2000,
        OFN_SHAREAWARE = 0x4000,
        OFN_NOREADONLYRETURN = 0x8000,
        OFN_NOTESTFILECREATE = 0x10000,
        OFN_NONETWORKBUTTON = 0x20000,
        /// <summary>
        /// Force no long names for 4.x modules
        /// </summary>
        OFN_NOLONGNAMES = 0x40000,
        /// <summary>
        /// New look commdlg
        /// </summary>
        OFN_EXPLORER = 0x80000,
        OFN_NODEREFERENCELINKS = 0x100000,
        /// <summary>
        /// Force long names for 3.x modules
        /// </summary>
        OFN_LONGNAMES = 0x200000
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct OpenFileName
    {
        public int lStructSize;
        public IntPtr hwndOwner;
        public IntPtr hInstance;
        public string lpstrFilter;
        public string lpstrCustomFilter;
        public int nMaxCustFilter;
        public int nFilterIndex;
        public string lpstrFile;
        public int nMaxFile;
        public string lpstrFileTitle;
        public int nMaxFileTitle;
        public string lpstrInitialDir;
        public string lpstrTitle;
        public int Flags;
        public short nFileOffset;
        public short nFileExtension;
        public string lpstrDefExt;
        public IntPtr lCustData;
        public IntPtr lpfnHook;
        public string lpTemplateName;
        public IntPtr pvReserved;
        public int dwReserved;
        public int flagsEx;
    }



}

