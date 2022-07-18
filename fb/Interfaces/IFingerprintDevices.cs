using fb.Models.Entites;

using System.Collections.Generic;

namespace fb.Interfaces
{
    public interface IFingerprintDevices
    {
        List<FingerprintDevices> GetItems();
        FingerprintDevices GetFingerprintDevices(int id);
        FingerprintDevices Create(FingerprintDevices fingerprintDevices);
        FingerprintDevices Edit(FingerprintDevices fingerprintDevices);
        FingerprintDevices Delete(FingerprintDevices fingerprintDevices);
        List<FingerprintDevices> Search(string term);

    }
}
