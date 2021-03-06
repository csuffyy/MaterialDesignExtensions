﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialDesignExtensionsDemo.ViewModel
{
    public class FileSystemDialogViewModel : FileSystemControlViewModel
    {
        public override string DocumentationUrl
        {
            get
            {
                return "https://github.com/spiegelp/MaterialDesignExtensions/wiki/File-system-controls";
            }
        }

        public FileSystemDialogViewModel() : base() { }
    }
}
