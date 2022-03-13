using System;
using SampSharp.GameMode;
using SampSharp.GameMode.Controllers;
using SampSharp.GameMode.World;

namespace Rivershell.Controllers
{
    [Controller]
    public class GlobalObjectsController : IEventListener
    {
        public void RegisterEvents(BaseMode gameMode)
        {
            gameMode.Initialized += GameMode_Initialized;
        }

        private void GameMode_Initialized(object sender, EventArgs e)
        {
            // Green Base Section
            _ = new GlobalObject(9090, new Vector3(2148.64f, -222.88f, -20.60f), new Vector3(0.00f, 0.00f, 179.70f));
            // Green resupply hut
            _ = new GlobalObject(12991, new Vector3(2140.83f, -235.13f, 7.13f), new Vector3(0.00f, 0.00f, -89.94f));

            // Blue Base Section
            _ = new GlobalObject(9090, new Vector3(2317.09f, 572.27f, -20.97f), new Vector3(0.00f, 0.00f, 0.00f));
            // Blue resupply hut
            _ = new GlobalObject(12991, new Vector3(2318.73f, 590.96f, 6.75f), new Vector3(0.00f, 0.00f, 89.88f));

            // General mapping
            _ = new GlobalObject(12991, new Vector3(2140.83f, -235.13f, 7.13f), new Vector3(0.00f, 0.00f, -89.94f));
            _ = new GlobalObject(19300, new Vector3(2137.33f, -237.17f, 46.61f), new Vector3(0.00f, 0.00f, 180.00f));
            _ = new GlobalObject(12991, new Vector3(2318.73f, 590.96f, 6.75f), new Vector3(0.00f, 0.00f, 89.88f));
            _ = new GlobalObject(19300, new Vector3(2325.41f, 587.93f, 47.37f), new Vector3(0.00f, 0.00f, 180.00f));
            _ = new GlobalObject(12991, new Vector3(2140.83f, -235.13f, 7.13f), new Vector3(0.00f, 0.00f, -89.94f));
            _ = new GlobalObject(12991, new Vector3(2318.73f, 590.96f, 6.75f), new Vector3(0.00f, 0.00f, 89.88f));
            _ = new GlobalObject(12991, new Vector3(2140.83f, -235.13f, 7.13f), new Vector3(0.00f, 0.00f, -89.94f));
            _ = new GlobalObject(12991, new Vector3(2318.73f, 590.96f, 6.75f), new Vector3(0.00f, 0.00f, 89.88f));
            _ = new GlobalObject(18228, new Vector3(1887.93f, -59.78f, -2.14f), new Vector3(0.00f, 0.00f, 20.34f));
            _ = new GlobalObject(17031, new Vector3(1990.19f, 541.37f, -22.32f), new Vector3(0.00f, 0.00f, 0.00f));
            _ = new GlobalObject(18227, new Vector3(2000.82f, 494.15f, -7.53f), new Vector3(11.70f, -25.74f, 154.38f));
            _ = new GlobalObject(17031, new Vector3(1992.35f, 539.80f, -2.97f), new Vector3(9.12f, 30.66f, 0.00f));
            _ = new GlobalObject(17031, new Vector3(1991.88f, 483.77f, -0.66f), new Vector3(-2.94f, -5.22f, 12.78f));
            _ = new GlobalObject(17029, new Vector3(2070.57f, -235.87f, -6.05f), new Vector3(-7.20f, 4.08f, 114.30f));
            _ = new GlobalObject(17029, new Vector3(2056.50f, -228.77f, -19.67f), new Vector3(14.16f, 19.68f, 106.56f));
            _ = new GlobalObject(17029, new Vector3(2074.00f, -205.33f, -18.60f), new Vector3(16.02f, 60.60f, 118.86f));
            _ = new GlobalObject(17029, new Vector3(2230.39f, -242.59f, -11.41f), new Vector3(5.94f, 7.56f, 471.24f));
            _ = new GlobalObject(17029, new Vector3(2252.53f, -213.17f, -20.81f), new Vector3(18.90f, -6.30f, -202.38f));
            _ = new GlobalObject(17029, new Vector3(2233.04f, -234.08f, -19.00f), new Vector3(21.84f, -8.88f, -252.06f));
            _ = new GlobalObject(17027, new Vector3(2235.05f, -201.49f, -11.90f), new Vector3(-11.94f, -4.08f, 136.32f));
            _ = new GlobalObject(17029, new Vector3(2226.11f, -237.07f, -2.45f), new Vector3(8.46f, 2.10f, 471.24f));
            _ = new GlobalObject(4368, new Vector3(2433.79f, 446.26f, 4.67f), new Vector3(-8.04f, -9.30f, 61.02f));
            _ = new GlobalObject(4368, new Vector3(2031.23f, 489.92f, -13.20f), new Vector3(-8.04f, -9.30f, -108.18f));
            _ = new GlobalObject(17031, new Vector3(2458.36f, 551.10f, -6.95f), new Vector3(0.00f, 0.00f, 0.00f));
            _ = new GlobalObject(17031, new Vector3(2465.37f, 511.35f, -7.70f), new Vector3(0.00f, 0.00f, 0.00f));
            _ = new GlobalObject(17031, new Vector3(2474.80f, 457.71f, -5.17f), new Vector3(0.00f, 0.00f, 172.74f));
            _ = new GlobalObject(17031, new Vector3(2466.03f, 426.28f, -5.17f), new Vector3(0.00f, 0.00f, 0.00f));
            _ = new GlobalObject(791, new Vector3(2310.45f, -229.38f, 7.41f), new Vector3(0.00f, 0.00f, 0.00f));
            _ = new GlobalObject(791, new Vector3(2294.00f, -180.15f, 7.41f), new Vector3(0.00f, 0.00f, 60.90f));
            _ = new GlobalObject(791, new Vector3(2017.50f, -305.30f, 7.29f), new Vector3(0.00f, 0.00f, 60.90f));
            _ = new GlobalObject(791, new Vector3(2106.45f, -279.86f, 20.05f), new Vector3(0.00f, 0.00f, 60.90f));
            _ = new GlobalObject(706, new Vector3(2159.13f, -263.71f, 19.22f), new Vector3(356.86f, 0.00f, -17.18f));
            _ = new GlobalObject(706, new Vector3(2055.75f, -291.53f, 13.98f), new Vector3(356.86f, 0.00f, -66.50f));
            _ = new GlobalObject(791, new Vector3(1932.65f, -315.88f, 6.77f), new Vector3(0.00f, 0.00f, -35.76f));
            _ = new GlobalObject(790, new Vector3(2429.40f, 575.79f, 10.42f), new Vector3(0.00f, 0.00f, 3.14f));
            _ = new GlobalObject(790, new Vector3(2403.40f, 581.56f, 10.42f), new Vector3(0.00f, 0.00f, 29.48f));
            _ = new GlobalObject(791, new Vector3(2083.44f, 365.48f, 13.19f), new Vector3(356.86f, 0.00f, -1.95f));
            _ = new GlobalObject(791, new Vector3(2040.15f, 406.02f, 13.33f), new Vector3(356.86f, 0.00f, -1.95f));
            _ = new GlobalObject(791, new Vector3(1995.36f, 588.10f, 7.50f), new Vector3(356.86f, 0.00f, -1.95f));
            _ = new GlobalObject(791, new Vector3(2126.11f, 595.15f, 5.99f), new Vector3(0.00f, 0.00f, -35.82f));
            _ = new GlobalObject(791, new Vector3(2188.35f, 588.90f, 6.04f), new Vector3(0.00f, 0.00f, 0.00f));
            _ = new GlobalObject(791, new Vector3(2068.56f, 595.58f, 5.99f), new Vector3(0.00f, 0.00f, 52.62f));
            _ = new GlobalObject(698, new Vector3(2385.32f, 606.16f, 9.79f), new Vector3(0.00f, 0.00f, 34.62f));
            _ = new GlobalObject(698, new Vector3(2309.29f, 606.92f, 9.79f), new Vector3(0.00f, 0.00f, -54.54f));
            _ = new GlobalObject(790, new Vector3(2347.14f, 619.77f, 9.94f), new Vector3(0.00f, 0.00f, 3.14f));
            _ = new GlobalObject(698, new Vector3(2255.28f, 606.94f, 9.79f), new Vector3(0.00f, 0.00f, -92.76f));
            _ = new GlobalObject(4298, new Vector3(2121.37f, 544.12f, -5.74f), new Vector3(-10.86f, 6.66f, 3.90f));
            _ = new GlobalObject(4368, new Vector3(2273.18f, 475.02f, -15.30f), new Vector3(4.80f, 8.10f, 266.34f));
            _ = new GlobalObject(18227, new Vector3(2232.38f, 451.61f, -30.71f), new Vector3(-18.54f, -6.06f, 154.38f));
            _ = new GlobalObject(17031, new Vector3(2228.15f, 518.87f, -16.51f), new Vector3(13.14f, -1.32f, -20.10f));
            _ = new GlobalObject(17031, new Vector3(2230.42f, 558.52f, -18.38f), new Vector3(-2.94f, -5.22f, 12.78f));
            _ = new GlobalObject(17031, new Vector3(2228.97f, 573.62f, 5.17f), new Vector3(17.94f, -15.60f, -4.08f));
            _ = new GlobalObject(17029, new Vector3(2116.67f, -87.71f, -2.31f), new Vector3(5.94f, 7.56f, 215.22f));
            _ = new GlobalObject(17029, new Vector3(2078.66f, -83.87f, -27.30f), new Vector3(13.02f, -53.94f, -0.30f));
            _ = new GlobalObject(17029, new Vector3(2044.80f, -36.91f, -9.26f), new Vector3(-13.74f, 27.90f, 293.76f));
            _ = new GlobalObject(17029, new Vector3(2242.41f, 426.16f, -15.43f), new Vector3(-21.54f, 22.26f, 154.80f));
            _ = new GlobalObject(17029, new Vector3(2220.06f, 450.07f, -34.78f), new Vector3(-1.32f, 10.20f, -45.84f));
            _ = new GlobalObject(17029, new Vector3(2252.49f, 439.08f, -19.47f), new Vector3(-41.40f, 20.16f, 331.86f));
            _ = new GlobalObject(17031, new Vector3(2241.41f, 431.93f, -5.62f), new Vector3(-2.22f, -4.80f, 53.64f));
            _ = new GlobalObject(17029, new Vector3(2141.10f, -81.30f, -2.41f), new Vector3(5.94f, 7.56f, 39.54f));
            _ = new GlobalObject(17031, new Vector3(2277.07f, 399.31f, -1.65f), new Vector3(-2.22f, -4.80f, -121.74f));
            _ = new GlobalObject(17026, new Vector3(2072.75f, -224.40f, -5.25f), new Vector3(0.00f, 0.00f, -41.22f));

            // Ramps
            _ = new GlobalObject(1632, new Vector3(2131.97f, 110.24f, 0.00f), new Vector3(0.00f, 0.00f, 153.72f));
            _ = new GlobalObject(1632, new Vector3(2124.59f, 113.69f, 0.00f), new Vector3(0.00f, 0.00f, 157.56f));
            _ = new GlobalObject(1632, new Vector3(2116.31f, 116.44f, 0.00f), new Vector3(0.00f, 0.00f, 160.08f));
            _ = new GlobalObject(1632, new Vector3(2113.22f, 108.48f, 0.00f), new Vector3(0.00f, 0.00f, 340.20f));
            _ = new GlobalObject(1632, new Vector3(2121.21f, 105.21f, 0.00f), new Vector3(0.00f, 0.00f, 340.20f));
            _ = new GlobalObject(1632, new Vector3(2127.84f, 102.06f, 0.00f), new Vector3(0.00f, 0.00f, 334.68f));
            _ = new GlobalObject(1632, new Vector3(2090.09f, 40.90f, 0.00f), new Vector3(0.00f, 0.00f, 348.36f));
            _ = new GlobalObject(1632, new Vector3(2098.73f, 39.12f, 0.00f), new Vector3(0.00f, 0.00f, 348.36f));
            _ = new GlobalObject(1632, new Vector3(2107.17f, 37.94f, 0.00f), new Vector3(0.00f, 0.00f, 348.36f));
            _ = new GlobalObject(1632, new Vector3(2115.88f, 36.47f, 0.00f), new Vector3(0.00f, 0.00f, 348.36f));
            _ = new GlobalObject(1632, new Vector3(2117.46f, 45.86f, 0.00f), new Vector3(0.00f, 0.00f, 529.20f));
            _ = new GlobalObject(1632, new Vector3(2108.98f, 46.95f, 0.00f), new Vector3(0.00f, 0.00f, 529.20f));
            _ = new GlobalObject(1632, new Vector3(2100.42f, 48.11f, 0.00f), new Vector3(0.00f, 0.00f, 526.68f));
            _ = new GlobalObject(1632, new Vector3(2091.63f, 50.02f, 0.00f), new Vector3(0.00f, 0.00f, 526.80f));
        }
    }
}
