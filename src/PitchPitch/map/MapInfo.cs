﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace PitchPitch.map
{
    enum MapSourceType
    {
        None,
        Image,
        Text,
        Music,
    }

    enum MapChipType
    {
        None,
        Builtin,
        Image,
    }

    enum MapChipBuiltinType
    {
        None,
        Binary,
        Colors,
    }

    enum PitchType
    {
        Undefined,
        Fixed,
        Variable,
    }

    class MapInfo
    {
        public string Id = "";
        public string DirectoryPath = "";
        public string MapName = "";
        public string AuthorName = "Unknown";

        public BgmInfo BgmInfo = null;

        public int Level = 3;
        public int OctaveLevel = 0;
        public bool HasEnd = true;

        public string MapSourceFileName = "";
        public MapSourceType MapSourceType = MapSourceType.None;
        public string Mapping = "";

        public ChipDataInfo ChipDataInfo = new ChipDataInfo();

        public int PlayerVx = 1;

        public PitchType PitchType = PitchType.Variable;
        public double MaxPitch = 880;
        public double MinPitch = 220;

        public Color ForegroundColor = Color.Black;
        public Color StrongColor = Color.Red;
        public Color BackgroundColor = Color.White;
    }

    class BgmInfo
    {
        public string Name;
        public int Volume;
    }

    class ChipInfo
    {
        public Color? Color;
        public int Hardness;
    }
    class ChipDataInfo
    {
        public string FileName = "";
        public MapChipType ChipType = MapChipType.Builtin;
        public MapChipBuiltinType BuiltinType = MapChipBuiltinType.Binary;
        public Size Size = new Size(16, 16);

        public List<ChipInfo> ChipInfos = new List<ChipInfo>();
    }

    class BuiltinMapInfo : MapInfo { }
}
