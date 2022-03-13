using System;
using SampSharp.GameMode;
using SampSharp.GameMode.Controllers;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.World;

namespace Rivershell.Controllers
{
    [Controller]
    public class VehiclesController : IEventListener
    {
        public void RegisterEvents(BaseMode gameMode)
        {
            gameMode.Initialized += GameMode_Initialized;
        }

        private void GameMode_Initialized(object sender, EventArgs e)
        {
            // Objective vehicles
            GameMode.BlueTeam.TargetVehicle = BaseVehicle.Create(VehicleModelType.Reefer, new Vector3(2184.7156f, -188.5401f, -0.0239f), 0.0000f, 114, 1,  100); // gr reefer
            GameMode.GreenTeam.TargetVehicle = BaseVehicle.Create(VehicleModelType.Reefer, new Vector3(2380.0542f, 535.2582f, -0.0272f), 178.4999f, 79, 7, 100); // bl reefer

            // Green Dhingys
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2096.0833f, -168.7771f, 0.3528f), 4.5000f, 114, 1, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2103.2510f, -168.7598f, 0.3528f), 3.1800f, 114, 1, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2099.4966f, -168.8216f, 0.3528f), 2.8200f, 114, 1, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2107.1143f, -168.7798f, 0.3528f), 3.1800f, 114, 1, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2111.0674f, -168.7609f, 0.3528f), 3.1800f, 114, 1, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2114.8933f, -168.7898f, 0.3528f), 3.1800f, 114, 1, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2167.2217f, -169.0570f, 0.3528f), 3.1800f, 114, 1, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2170.4294f, -168.9724f, 0.3528f), 3.1800f, 114, 1, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2173.7952f, -168.9217f, 0.3528f), 3.1800f, 114, 1, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2177.0386f, -168.9767f, 0.3528f), 3.1800f, 114, 1, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2161.5786f, -191.9538f, 0.3528f), 89.1000f, 114, 1, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2161.6394f, -187.2925f, 0.3528f), 89.1000f, 114, 1, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2161.7610f, -183.0225f, 0.3528f), 89.1000f, 114, 1, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2162.0283f, -178.5106f, 0.3528f), 89.1000f, 114, 1, 100);

            // Green Mavericks
            BaseVehicle.Create(VehicleModelType.Maverick, new Vector3(2088.7905f, -227.9593f, 8.3662f), 0.0000f, 114, 1, 100);
            BaseVehicle.Create(VehicleModelType.Maverick, new Vector3(2204.5991f, -225.3703f, 8.2400f), 0.0000f, 114, 1, 100);

            // Blue Dhingys
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2370.3198f, 518.3151f, 0.1240f), 180.3600f, 79, 7, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2362.6484f, 518.3978f, 0.0598f), 180.3600f, 79, 7, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2358.6550f, 518.2167f, 0.2730f), 180.3600f, 79, 7, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2366.5544f, 518.2680f, 0.1080f), 180.3600f, 79, 7, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2354.6321f, 518.1960f, 0.3597f), 180.3600f, 79, 7, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2350.7449f, 518.1929f, 0.3597f), 180.3600f, 79, 7, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2298.8977f, 518.4470f, 0.3597f), 180.3600f, 79, 7, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2295.6118f, 518.3963f, 0.3597f), 180.3600f, 79, 7, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2292.3237f, 518.4249f, 0.3597f), 180.3600f, 79, 7, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2289.0901f, 518.4363f, 0.3597f), 180.3600f, 79, 7, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2304.8232f, 539.7859f, 0.3597f), 270.5998f, 79, 7, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2304.6936f, 535.0454f, 0.3597f), 270.5998f, 79, 7, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2304.8245f, 530.3308f, 0.3597f), 270.5998f, 79, 7, 100);
            BaseVehicle.Create(VehicleModelType.Dinghy, new Vector3(2304.8142f, 525.7471f, 0.3597f), 270.5998f, 79, 7, 100);

            // Blue Mavericks
            BaseVehicle.Create(VehicleModelType.Maverick, new Vector3(2260.2637f, 578.5220f, 8.1223f), 182.3401f, 79, 7, 100);
            BaseVehicle.Create(VehicleModelType.Maverick, new Vector3(2379.9792f, 580.0323f, 8.0178f), 177.9601f, 79, 7, 100);
        }
    }
}
