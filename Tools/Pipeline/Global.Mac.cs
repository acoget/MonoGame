﻿﻿// MonoGame - Copyright (C) The MonoGame Team
// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System;
using Eto.Drawing;
using Eto.Forms;

namespace MonoGame.Tools.Pipeline
{
    static partial class Global
    {
        private static void PlatformInit()
        {
            
        }
    
        private static Image PlatformGetDirectoryIcon(bool exists)
        {
            throw new NotImplementedException();
        }

        private static Image PlatformGetFileIcon(string path, bool exists)
        {
            throw new NotImplementedException();
        }

        private static void PlatformShowOpenWithDialog(string filePath)
        {
            throw new NotImplementedException();
        }

        private static bool PlatformSetIcon(Command cmd)
        {
            return false;
        }
    }
}

