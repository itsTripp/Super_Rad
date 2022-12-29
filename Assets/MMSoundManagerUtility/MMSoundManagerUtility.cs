using MoreMountains.Tools;
using UnityEngine;

[CreateAssetMenu(fileName = "MMSoundManagerUtility")]
public class MMSoundManagerUtility : ScriptableObject
{
    public void SetVolumeMaster(float newVolume) => MMSoundManagerTrackEvent.Trigger(
    MMSoundManagerTrackEventTypes.SetVolumeTrack, MMSoundManager.MMSoundManagerTracks.Master, newVolume);

    public void SetVolumeMusic(float newVolume) => MMSoundManagerTrackEvent.Trigger(
        MMSoundManagerTrackEventTypes.SetVolumeTrack, MMSoundManager.MMSoundManagerTracks.Music, newVolume);

    public void SetVolumeSfx(float newVolume) => MMSoundManagerTrackEvent.Trigger(
    MMSoundManagerTrackEventTypes.SetVolumeTrack, MMSoundManager.MMSoundManagerTracks.Sfx, newVolume);

    public void SetVolumeUi(float newVolume) => MMSoundManagerTrackEvent.Trigger(
    MMSoundManagerTrackEventTypes.SetVolumeTrack, MMSoundManager.MMSoundManagerTracks.UI, newVolume);
}
