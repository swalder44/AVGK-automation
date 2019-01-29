using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace Podp
{
    class Podpis
    {


        ////                 Подпись документа:
        //private static Org.BouncyCastle.Crypto.ISigner signer = new Gost3410DigestSigner(new Gost3410Signer(), new Org.BouncyCastle.Crypto.IDigest.GOST3411_2012_512Digest());
        //private static AsymmetricKeyEntry PrivKey;

        //public static Pkcs12Store LoadKeyAndGenerateSetificate(out Gost3410PublicKeyParameters publicKey)
        //{

        //    Gost3410PrivateKeyParameters privateKey = (Gost3410PrivateKeyParameters)PrivateKeyFactory.CreateKey(Convert.FromBase64String(File.ReadAllText(PathPrivateFile)));
        //    publicKey = (Gost3410PublicKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(File.ReadAllText(PathPublicKey)));
        //    Pkcs12StoreBuilder ksBuilder = new Pkcs12StoreBuilder();
        //    Pkcs12Store ks = ksBuilder.Build();
        //    AsymmetricCipherKeyPair new_p = new AsymmetricCipherKeyPair(publicKey, privateKey);
        //    X509V3CertificateGenerator certGen = new X509V3CertificateGenerator();
        //    certGen.SetSerialNumber(BigInteger.One);
        //    certGen.SetIssuerDN(new X509Name("CN=VimSistemi"));
        //    certGen.SetNotBefore(DateTime.UtcNow.AddSeconds(-360));
        //    certGen.SetNotAfter(DateTime.UtcNow.AddYears(2));
        //    certGen.SetSubjectDN(new X509Name("CN=Test"));
        //    certGen.SetPublicKey(publicKey);
        //    //certGen.SetSignatureAlgorithm("GOST3411withGOST3410");
        //    //certGen.SetSignatureAlgorithm("GOST3411-2012-512withGOST3410");
        //    //certGen.SetSignatureAlgorithm("GOST3411withECGOST3410");
        //    certGen.SetSignatureAlgorithm("GOST3411withGOST3410");
        //    X509Certificate cert = certGen.Generate(privateKey);
        //    X509CertificateEntry certEntry = new X509CertificateEntry(cert);

        //    ks.SetKeyEntry("gost", new AsymmetricKeyEntry(privateKey), new X509CertificateEntry[] { certEntry });

        //    MemoryStream bOut = new MemoryStream();

        //    ks.Save(bOut, "gost".ToCharArray(), new SecureRandom());

        //    //ks = ksBuilder.Build();

        //    return ks;
        //}


        //public static void GenerateAndSaveCertificate()
        //{
        //    IAsymmetricCipherKeyPairGenerator g = GeneratorUtilities.GetKeyPairGenerator("GOST3410");
        //    g.Init(
        //     new Gost3410KeyGenerationParameters(
        //         new SecureRandom(),
        //         CryptoProObjectIdentifiers.GostR3410x94CryptoProA));

        //    AsymmetricCipherKeyPair p = g.GenerateKeyPair();

        //    AsymmetricKeyParameter sKey = p.Private;
        //    AsymmetricKeyParameter vKey = p.Public;

        //    PrivateKeyInfo privateKeyInfo = PrivateKeyInfoFactory.CreatePrivateKeyInfo(sKey);
        //    byte[] serializedPrivateBytes = privateKeyInfo.ToAsn1Object().GetDerEncoded();
        //    string serializedPrivate = Convert.ToBase64String(serializedPrivateBytes);

        //    File.WriteAllText(PathPrivateFile, serializedPrivate);

        //    SubjectPublicKeyInfo publicKeyInfo = SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(vKey);
        //    byte[] serializedPublicBytes = publicKeyInfo.ToAsn1Object().GetDerEncoded();
        //    string serializedPublic = Convert.ToBase64String(serializedPublicBytes);
        //    File.WriteAllText(PathPublicKey, serializedPublic);
        //}


        //public static string SignData(byte[] msg, AsymmetricKeyParameter PrivKey)
        //{
        //    try
        //    {
        //        signer.Init(true, PrivKey);
        //        signer.BlockUpdate(msg, 0, msg.Length);
        //        var sigBytes = signer.GenerateSignature();
        //        return Convert.ToBase64String(sigBytes);
        //    }
        //    catch (Exception exc)
        //    {
        //        Console.WriteLine(" Signing Failed: " + exc.ToString());
        //        return null;
        //    }
        //}

    }
}
