using Android.Bluetooth.LE;
using Android.Runtime;

namespace Plugin.BLE.Android
{
    internal class AdvertiseCallbackImp : AdvertiseCallback
    {

        public override void OnStartFailure([GeneratedEnum] AdvertiseFailure errorCode)
        {
            base.OnStartFailure(errorCode);
        }

        public override void OnStartSuccess(AdvertiseSettings settingsInEffect)
        {
            base.OnStartSuccess(settingsInEffect);
        }
    }
}
