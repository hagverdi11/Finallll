﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Services.Interface
{
    public interface IFileService
    {
        string ReadFile(string path, string template);
    }
}
