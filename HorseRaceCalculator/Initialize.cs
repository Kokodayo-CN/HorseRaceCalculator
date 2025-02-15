using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRaceCalculator
{
    internal static class Initialize
    {
        public static void OnStartup()
        {
            FileStream file = File.Create("HorseRaceCalculator.exe.manifest");
            file.Write(Encoding.UTF8.GetBytes(Manifest()), 0, Manifest().Length);
        }

        public static void OnShutdown()
        {
            File.Delete("HorseRaceCalculator.exe.manifest");
        }

        public static string Manifest()
        {
            return "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n" +
                "<asmv1:assembly xsi:schemaLocation=\"urn:schemas-microsoft-com:asm.v1 assembly.adaptive.xsd\" manifestVersion=\"1.0\" xmlns:asmv1=\"urn:schemas-microsoft-com:asm.v1\" xmlns=\"urn:schemas-microsoft-com:asm.v2\" xmlns:asmv2=\"urn:schemas-microsoft-com:asm.v2\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:co.v1=\"urn:schemas-microsoft-com:clickonce.v1\" xmlns:asmv3=\"urn:schemas-microsoft-com:asm.v3\" xmlns:dsig=\"http://www.w3.org/2000/09/xmldsig#\" xmlns:co.v2=\"urn:schemas-microsoft-com:clickonce.v2\">\r\n" +
                "  <asmv1:assemblyIdentity name=\"HorseRaceCalculator.exe\" version=\"1.0.0.1\" publicKeyToken=\"0000000000000000\" language=\"neutral\" processorArchitecture=\"msil\" type=\"win32\" />\r\n" +
                "  <description asmv2:iconFile=\"ico.ico\" xmlns=\"urn:schemas-microsoft-com:asm.v1\" />\r\n" +
                "  <application />\r\n" +
                "  <entryPoint>\r\n" +
                "    <assemblyIdentity name=\"HorseRaceCalculator\" version=\"1.0.0.0\" language=\"neutral\" processorArchitecture=\"msil\" />\r\n" +
                "    <commandLine file=\"HorseRaceCalculator.exe\" parameters=\"\" />\r\n" +
                "  </entryPoint>\r\n" +
                "  <trustInfo>\r\n" +
                "    <security>\r\n" +
                "      <applicationRequestMinimum>\r\n" +
                "        <PermissionSet Unrestricted=\"true\" ID=\"Custom\" SameSite=\"site\" />\r\n" +
                "        <defaultAssemblyRequest permissionSetReference=\"Custom\" />\r\n" +
                "      </applicationRequestMinimum>\r\n" +
                "      <requestedPrivileges xmlns=\"urn:schemas-microsoft-com:asm.v3\">\r\n" +
                "        <requestedExecutionLevel level=\"asInvoker\" uiAccess=\"false\" />\r\n" +
                "      </requestedPrivileges>\r\n" +
                "    </security>\r\n" +
                "  </trustInfo>\r\n" +
                "  <dependency>\r\n" +
                "    <dependentOS>\r\n" +
                "      <osVersionInfo>\r\n" +
                "        <os majorVersion=\"5\" minorVersion=\"1\" buildNumber=\"2600\" servicePackMajor=\"0\" />\r\n" +
                "      </osVersionInfo>\r\n" +
                "    </dependentOS>\r\n" +
                "  </dependency>\r\n" +
                "  <dependency>\r\n" +
                "    <dependentAssembly dependencyType=\"preRequisite\" allowDelayedBinding=\"true\">\r\n" +
                "      <assemblyIdentity name=\"Microsoft.Windows.CommonLanguageRuntime\" version=\"4.0.30319.0\" />\r\n" +
                "    </dependentAssembly>\r\n" +
                "  </dependency>\r\n" +
                "  <dependency>\r\n" +
                "    <dependentAssembly dependencyType=\"install\" allowDelayedBinding=\"true\" codebase=\"HorseRaceCalculator.exe\" size=\"447504\">\r\n" +
                "      <assemblyIdentity name=\"HorseRaceCalculator\" version=\"1.0.0.0\" language=\"neutral\" processorArchitecture=\"msil\" />\r\n" +
                "      <hash>\r\n" +
                "        <dsig:Transforms>\r\n" +
                "          <dsig:Transform Algorithm=\"urn:schemas-microsoft-com:HashTransforms.Identity\" />\r\n" +
                "        </dsig:Transforms>\r\n" +
                "        <dsig:DigestMethod Algorithm=\"http://www.w3.org/2000/09/xmldsig#sha256\" />\r\n" +
                "        <dsig:DigestValue>LfpvKyDQ8ygcJfzU4WecM9L4O5i1CxswHIfbUOQQg0Y=</dsig:DigestValue>\r\n" +
                "      </hash>\r\n" +
                "    </dependentAssembly>\r\n" +
                "  </dependency>\r\n" +
                "  <file name=\"HorseRaceCalculator.exe.config\" size=\"187\">\r\n" +
                "    <hash>\r\n" +
                "      <dsig:Transforms>\r\n" +
                "        <dsig:Transform Algorithm=\"urn:schemas-microsoft-com:HashTransforms.Identity\" />\r\n" +
                "      </dsig:Transforms>\r\n" +
                "      <dsig:DigestMethod Algorithm=\"http://www.w3.org/2000/09/xmldsig#sha256\" />\r\n" +
                "      <dsig:DigestValue>+CM46OnHRrXZXNLMx7+U3V3iubiYL//d8hGOR13lDhU=</dsig:DigestValue>\r\n" +
                "    </hash>\r\n" +
                "  </file>\r\n" +
                "  <file name=\"ico.ico\" size=\"129296\">\r\n" +
                "    <hash>\r\n" +
                "      <dsig:Transforms>\r\n" +
                "        <dsig:Transform Algorithm=\"urn:schemas-microsoft-com:HashTransforms.Identity\" />\r\n" +
                "      </dsig:Transforms>\r\n" +
                "      <dsig:DigestMethod Algorithm=\"http://www.w3.org/2000/09/xmldsig#sha256\" />\r\n" +
                "      <dsig:DigestValue>AxiiGom7O3JQsRpivWrLonLEQRNWK/4AnIkYCtbJ5UE=</dsig:DigestValue>\r\n" +
                "    </hash>\r\n" +
                "  </file>\r\n" +
                "  <compatibility xmlns=\"urn:schemas-microsoft-com:compatibility.v1\">\r\n" +
                "    <application />\r\n" +
                "  </compatibility>\r\n" +
                "  <asmv3:application xmlns=\"urn:schemas-microsoft-com:asm.v1\">\r\n" +
                "    <asmv3:windowsSettings xmlns=\"http://schemas.microsoft.com/SMI/2005/WindowsSettings\">\r\n" +
                "      <dpiAware>true</dpiAware>\r\n" +
                "    </asmv3:windowsSettings>\r\n" +
                "  </asmv3:application>\r\n" +
                "</asmv1:assembly>";
        }
    }
}
