// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System;
using System.Numerics;
using SixLabors.Fonts.Tables.General;

namespace SixLabors.Fonts
{
    /// <summary>
    /// provide metadata about a font.
    /// </summary>
    internal class FileFontInstance : IFontInstance
    {
        private readonly Lazy<IFontInstance> font;

        public FileFontInstance(string path)
        {
            this.Description = FontDescription.LoadDescription(path);
            this.font = new Lazy<Fonts.IFontInstance>(() => FontInstance.LoadFont(path));
        }

        public FontDescription Description { get; }

        public ushort EmSize => this.font.Value.EmSize;

        public short Ascender => this.font.Value.Ascender;

        public short Descender => this.font.Value.Descender;

        public short LineGap => this.font.Value.LineGap;

        public int LineHeight => this.font.Value.LineHeight;

        public CMapTable CMapTable => this.font.Value.CMapTable;

        public OS2Table OS2Table => this.font.Value.OS2Table;

        public GlyphTable GlyphTable => this.font.Value.GlyphTable;

        public HorizontalMetricsTable HorizontalMetricsTable => this.font.Value.HorizontalMetricsTable;

        public HeadTable HeadTable => this.font.Value.HeadTable;

        public KerningTable KerningTable => this.font.Value.KerningTable;

        public HorizontalHeadTable HorizontalHeadTable => this.font.Value.HorizontalHeadTable;

        public ushort GetGlyphIndex(int codePoint)
        {
            return this.font.Value.GetGlyphIndex(codePoint);
        }

        GlyphInstance IFontInstance.GetGlyph(int codePoint)
            => this.font.Value.GetGlyph(codePoint);

        Vector2 IFontInstance.GetOffset(GlyphInstance glyph, GlyphInstance previousGlyph)
            => this.font.Value.GetOffset(glyph, previousGlyph);
    }
}
