using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Correlatio
{
    public static class ColorTheme
    {
        public static Color BG { get; set; }
        public static Color BGPanel { get; set; }
        public static Color Title { get; set; }
        public static Color SubTitle { get; set; }
        public static Color SubTitle2 { get; set; }
        public static Color Text { get; set; }

        public static void FromXML(string xmlFP)
        {
            XmlDocument document = new();
            document.Load(xmlFP);
            foreach (XmlNode node in document.DocumentElement.ChildNodes)
            {
                if (node.Name == "element")
                {
                    Color color = ColorTranslator.FromHtml(node.InnerText);
                    switch (node.Attributes["name"].Value)
                    {
                        case "bg":
                            BG = color;
                            break;
                        case "bgPanel":
                            BGPanel = color;
                            break;
                        case "title":
                            Title = color;
                            break;
                        case "subtitle":
                            SubTitle = color;
                            break;
                        case "subtitle2":
                            SubTitle2 = color;
                            break;
                        case "text":
                            Text = color;
                            break;
                    }
                }
            }
        }

        public static Color AdjustLuminance(Color color, float percentage)
        {
            // Convert RGB to HSL
            (float hue, float saturation, float luminance) = RgbToHsl(color);

            // Adjust the luminance by the given percentage
            luminance = Math.Max(0, Math.Min(1, luminance + (percentage / 100f)));

            // Convert HSL back to RGB
            return HslToRgb(hue, saturation, luminance, color.A);
        }

        private static (float hue, float saturation, float luminance) RgbToHsl(Color color)
        {
            float r = color.R / 255f;
            float g = color.G / 255f;
            float b = color.B / 255f;

            float max = Math.Max(r, Math.Max(g, b));
            float min = Math.Min(r, Math.Min(g, b));
            float delta = max - min;

            float hue = 0;
            if (delta != 0)
            {
                if (max == r)
                {
                    hue = (g - b) / delta;
                }
                else if (max == g)
                {
                    hue = 2f + (b - r) / delta;
                }
                else
                {
                    hue = 4f + (r - g) / delta;
                }
            }
            hue = (hue * 60) % 360;
            if (hue < 0)
            {
                hue += 360;
            }

            float luminance = (max + min) / 2;
            float saturation = (delta == 0) ? 0 : delta / (1 - Math.Abs(2 * luminance - 1));

            return (hue / 360f, saturation, luminance);
        }

        private static Color HslToRgb(float hue, float saturation, float luminance, int alpha)
        {
            hue *= 360f;

            float c = (1 - Math.Abs(2 * luminance - 1)) * saturation;
            float x = c * (1 - Math.Abs((hue / 60f) % 2 - 1));
            float m = luminance - c / 2;

            float r = 0, g = 0, b = 0;
            if (0 <= hue && hue < 60)
            {
                r = c; g = x; b = 0;
            }
            else if (60 <= hue && hue < 120)
            {
                r = x; g = c; b = 0;
            }
            else if (120 <= hue && hue < 180)
            {
                r = 0; g = c; b = x;
            }
            else if (180 <= hue && hue < 240)
            {
                r = 0; g = x; b = c;
            }
            else if (240 <= hue && hue < 300)
            {
                r = x; g = 0; b = c;
            }
            else if (300 <= hue && hue < 360)
            {
                r = c; g = 0; b = x;
            }

            int red = (int)((r + m) * 255);
            int green = (int)((g + m) * 255);
            int blue = (int)((b + m) * 255);

            return Color.FromArgb(alpha, red, green, blue);
        }
    }
}
