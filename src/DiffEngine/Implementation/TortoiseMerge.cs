﻿using System;
using DiffEngine;

static partial class Implementation
{
    public static Definition TortoiseMerge()
    {
        return new Definition(
            name: DiffTool.TortoiseMerge,
            url: "https://tortoisesvn.net/TortoiseMerge.html",
            autoRefresh: false,
            isMdi: false,
            supportsText: true,
            requiresTarget: true,
            binaryExtensions: Array.Empty<string>(),
            windows: new OsSettings(
                (temp, target) => $"\"{temp}\" \"{target}\"",
                @"%ProgramFiles%\TortoiseSVN\bin\TortoiseMerge.exe"));
    }
}