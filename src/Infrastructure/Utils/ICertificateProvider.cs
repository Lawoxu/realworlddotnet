using System.Security.Cryptography.X509Certificates;

namespace realworlddotnet.Infrastructure.Utils
{
    public interface ICertificateProvider
    {
        X509Certificate2 LoadFromUserStore(string thumbprint);
    }
}