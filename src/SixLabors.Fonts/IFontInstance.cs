// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System.Numerics;
using SixLabors.Fonts.Tables.General;

namespace SixLabors.Fonts
{
    public interface IFontInstance
    {
        /// <summary>
        /// Gets the CMap table
        /// </summary>
        public CMapTable CMapTable { get; }

        /// <summary>
        /// Gets the OS/2 table
        /// </summary>
        public OS2Table OS2Table { get; }

        /// <summary>
        /// Gets the Glyph table
        /// </summary>
        public GlyphTable GlyphTable { get; }

        /// <summary>
        /// Gets the Horizontal Metrics table
        /// </summary>
        public HorizontalMetricsTable HorizontalMetricsTable { get; }

        /// <summary>
        /// Gets the Horizontal Head table
        /// </summary>
        public HorizontalHeadTable HorizontalHeadTable { get; }

        /// <summary>
        /// Gets the Head table
        /// </summary>
        public HeadTable HeadTable { get; }

        /// <summary>
        /// Gets the Kerning table
        /// </summary>
        public KerningTable KerningTable { get; }

        FontDescription Description { get; }

        ushort EmSize { get; }

        int LineHeight { get; }

        short Ascender { get; }

        short Descender { get; }

        short LineGap { get; }

        GlyphInstance GetGlyph(int codePoint);

        ushort GetGlyphIndex(int codePoint);

        Vector2 GetOffset(GlyphInstance glyph, GlyphInstance previousGlyph);
    }
}
