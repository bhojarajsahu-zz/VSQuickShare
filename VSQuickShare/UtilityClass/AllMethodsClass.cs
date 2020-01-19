using bhojarajsahu88.VSQuickShare.VSQuickShareServiceReference;
using System;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;
using System.Xml;

namespace bhojarajsahu88.VSQuickShare.UtilityClass
{
    class AllMethodsClass
    {
        ErrorModel errorModel;
        //string connectionString = string.Empty;
        public AllMethodsClass()
        {
            //connectionString = UtilityOperations.getConnectionString();
        }
        //getShareKey
        public string getShareKey(string sharedKey)
        {
            errorModel = new ErrorModel();
            string searchResult = string.Empty;
            try {

                EndpointAddress endpointAdd = new EndpointAddress(Config.GetSettings("URL"));
                VSQuickShareServiceReference.ServiceClient newReference = new VSQuickShareServiceReference.ServiceClient(GetBinding(), endpointAdd);
                newReference.ClientCredentials.UserName.UserName = Config.GetSettings("UID");
                newReference.ClientCredentials.UserName.Password = Config.GetSettings("PWD");
                searchResult = newReference.GetShareKey(sharedKey,out errorModel);
            }
            catch (Exception ex){
            }
            return searchResult;
        }
        public string addSharedCode(string userId, string code, string uniqueCode)
        {
            errorModel = new ErrorModel();
            string searchResult = string.Empty;
            string shareId = string.Empty;
            try
            {
                EndpointAddress endpointAdd = new EndpointAddress(Config.GetSettings("URL"));
                VSQuickShareServiceReference.ServiceClient newReference = new VSQuickShareServiceReference.ServiceClient(GetBinding(), endpointAdd);
                newReference.ClientCredentials.UserName.UserName = Config.GetSettings("UID");
                newReference.ClientCredentials.UserName.Password = Config.GetSettings("PWD");
                searchResult = newReference.AddSharedCode(userId,code, uniqueCode, out errorModel);
            }
            catch (Exception ex)
            {
            }
            return searchResult;            
        }
        public BasicHttpBinding GetBinding()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            try
            {
                BasicHttpSecurity security = new BasicHttpSecurity();
                security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
                security.Transport.ProxyCredentialType = HttpProxyCredentialType.None;
                security.Transport.Realm = String.Empty;
                security.Message.ClientCredentialType = BasicHttpMessageCredentialType.UserName;
                security.Message.AlgorithmSuite = SecurityAlgorithmSuite.Default;
                security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;

                binding.Name = "BasicHttpBinding_IService";
                binding.CloseTimeout = new TimeSpan(0, 0, 30);
                binding.OpenTimeout = new TimeSpan(0, 0, 30);
                binding.ReceiveTimeout = new TimeSpan(0, 10, 0);
                binding.SendTimeout = new TimeSpan(0, 0, 30);
                binding.AllowCookies = false;
                binding.BypassProxyOnLocal = false;
                binding.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;
                binding.MaxBufferSize = 999999999;
                binding.MaxBufferPoolSize = 999999999;
                binding.MaxReceivedMessageSize = 999999999;
                binding.MessageEncoding = WSMessageEncoding.Text;
                binding.TextEncoding = Encoding.UTF8;
                binding.TransferMode = TransferMode.Buffered;
                binding.UseDefaultWebProxy = true;


                XmlDictionaryReaderQuotas readerQuotas = new XmlDictionaryReaderQuotas();
                readerQuotas.MaxDepth = 999999999;
                readerQuotas.MaxStringContentLength = 999999999;
                readerQuotas.MaxArrayLength = 999999999;
                readerQuotas.MaxBytesPerRead = 999999999;
                readerQuotas.MaxNameTableCharCount = 999999999;
                binding.ReaderQuotas = readerQuotas;

                binding.Security = security;
            }
            catch (Exception ex)
            {

            }

            return binding;
        }
    }
}
