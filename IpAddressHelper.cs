using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

class IpAddressHelper
{
    /*
    ** Check if string is ipaddress
    */
    public static bool isAddress(string ipaddress){
        string pattern = @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$";
        // var r = Regex.Matches(ipaddress,@"(\d{1,3}\.){3}\d{1,3}");
        var r = Regex.Matches(ipaddress,pattern);
        if(r.Count>0){
            return true;
        }else
            return false;
    }
    
    public static List<string> GetHostIpAddresses()
    {
        var server = Dns.GetHostName();
        var list = new List<string>();
        IPHostEntry heserver = Dns.GetHostEntry(server);
        Console.WriteLine(heserver.AddressList.Length);
        foreach (IPAddress curAdd in heserver.AddressList){
            // Console.WriteLine(curAdd.ToString());
            // Console.WriteLine(curAdd.GetType());
            list.Add(curAdd.ToString());
        }
        return list;
    }
    
    // Get the list of the addresses associated with the requested server.
    public static void IPAddresses(string server)
    {
        try
        {
            System.Text.ASCIIEncoding ASCII = new System.Text.ASCIIEncoding();

            // Get server related information.
            IPHostEntry heserver = Dns.GetHostEntry(server);

            Console.WriteLine("{0} address.",heserver.AddressList.Length);

            // Loop on the AddressList
            foreach (IPAddress curAdd in heserver.AddressList)
            {

                Console.WriteLine("....");
                // Display the type of address family supported by the server. If the
                // server is IPv6-enabled this value is: InterNetworkV6. If the server
                // is also IPv4-enabled there will be an additional value of InterNetwork.
                Console.WriteLine("AddressFamily: " + curAdd.AddressFamily.ToString());

                // Display the ScopeId property in case of IPV6 addresses.
                if (curAdd.AddressFamily.ToString() == ProtocolFamily.InterNetworkV6.ToString())
                    Console.WriteLine("Scope Id: " + curAdd.ScopeId.ToString());


                // Display the server IP address in the standard format. In
                // IPv4 the format will be dotted-quad notation, in IPv6 it will be
                // in in colon-hexadecimal notation.
                Console.WriteLine("Address: " + curAdd.ToString());

                // Display the server IP address in byte format.
                Console.Write("AddressBytes: ");

                Byte[] bytes = curAdd.GetAddressBytes();
                for (int i = 0; i < bytes.Length; i++)
                {
                    Console.Write(bytes[i]);
                }

                Console.WriteLine("\r\n");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("[DoResolve] Exception: " + e.ToString());
        }
    }

    // This IPAddressAdditionalInfo displays additional server address information.
    public static void IPAddressAdditionalInfo()
    {
        try
        {
            // Display the flags that show if the server supports IPv4 or IPv6
            // address schemas.
            Console.WriteLine("\r\nSupportsIPv4: " + Socket.OSSupportsIPv4);
            Console.WriteLine("SupportsIPv6: " + Socket.OSSupportsIPv6);

            if (Socket.OSSupportsIPv6)
            {
                // Display the server Any address. This IP address indicates that the server
                // should listen for client activity on all network interfaces.
                Console.WriteLine("\r\nIPv6Any: " + IPAddress.IPv6Any.ToString());

                // Display the server loopback address.
                Console.WriteLine("IPv6Loopback: " + IPAddress.IPv6Loopback.ToString());

                // Used during autoconfiguration first phase.
                Console.WriteLine("IPv6None: " + IPAddress.IPv6None.ToString());

                Console.WriteLine("IsLoopback(IPv6Loopback): " + IPAddress.IsLoopback(IPAddress.IPv6Loopback));
            }
            Console.WriteLine("IsLoopback(Loopback): " + IPAddress.IsLoopback(IPAddress.Loopback));
        }
        catch (Exception e)
        {
            Console.WriteLine("[IPAddresses] Exception: " + e.ToString());
        }
    }

}