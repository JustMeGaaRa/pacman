﻿namespace PacMan
{
    public static class TilemapExtentions
    {
        public static ISprite ToSprite(this ITilemap map, Offset offset)
        {
            Color[,] currentView = new Color[map.Size.Height * 8, map.Size.Width * 8];

            foreach (ISprite sprite in map.All)
            {
                currentView.RenderBitmap(sprite);
            }

            return new GenericSprite(offset, currentView);
        }

        public static ISprite ToSprite(this ITilemap map)
        {
            return ToSprite(map, Offset.Default);
        }
    }
}