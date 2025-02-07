﻿using CodectoryCore.UI.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHDR.Profiles.Actions
{
    public interface IProfileAction
    {
        string Name { get; set; }
        string LocalizeCaption { get; }
        ActionEndResult RunAction();
    }
}
