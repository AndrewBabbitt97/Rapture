﻿// Licensed to the Rapture Contributors under one or more agreements.
// The Rapture Contributors licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Rapture.Services.PatchServer.Data;

/// <summary>
/// The repository of info hashes
/// </summary>
public class InfoHashRepository
{
    /// <summary>
    /// The peer id for the info hashes
    /// </summary>
    public string PeerId { get; } = "-SQ0001-krMehjLVpOso";

    /// <summary>
    /// The info hashes
    /// </summary>
    public IDictionary<string, string> InfoHashes { get; } = new Dictionary<string, string>()
    {
        // Boot 2010.09.19.0000
        { "D8CC5488E9847936232AF91AC31B56306F03E88D", "B5EB8FD62545932C1118A3432CF36DF66F03E88D" },

        // Game 2010.09.19.0000
        { "7D1B47F18EE588908400C68F44DF7D9AA871D258", "8BF7F9204466FF0A3FAE0C0254AA0699A871D258" },

        // Game 2010.09.23.0000
        { "2E30FF56283E68CB8D4A64B4C8A47AFDF859ABA3", "792BF7BE150FEFCB9DC9CFCC0C5721B1F859ABA3" },

        // Game 2010.09.28.0000
        { "7810D98000037AF121643D244F64FDD8A15C3608", "8439D339254D1C892E133734B199979DA15C3608" },

        // Game 2010.10.07.0001
        { "8B72F402543CD7FDA5196EA43F6C9229E8A55D56", "5B695DC7706CED284F011E3889418DBAE8A55D56" },

        // Game 2010.10.14.0000
        { "25C7503E2A27BC3DB2D0674958E88402144FF8FF", "033FF6FDE7097815496755C2C89380EA144FF8FF" },

        // Game 2010.10.22.0000
        { "1FA26F9BA68993F5CB67AC274360F8462C3049BD", "D6C3557B5B7580C0FC6C29C5E0A39A572C3049BD" },

        // Game 2010.10.26.0000
        { "497C24B68B134EA926BCEE77B2AAB5F1F362D78A", "F1E5370545CCE39228CA49FD6A543939F362D78A" },

        // Game 2010.11.25.0002
        { "4AD898623B0D412EBE7D9ADEE0CAFA3F1835593D", "7E2E022699639D71BCCB6120D548FF531835593D" },

        // Game 2010.11.30.0000
        { "361D7496C915A640E8BF58F8FA011F98B380372E", "6B45EEFA46F4966CD98B6D572ADCFCB8B380372E" },

        // Game 2010.12.06.0000
        { "7CAA78C5420E2B4AF173B1746937253581752DBF", "F3F2AB149EDA48F99510347D4A8EB2BA81752DBF" },

        // Game 2010.12.13.0000
        { "3739EE21E177BD6C3B0DE8C5C218E3F14758909D", "D1E0B6A00980BC7A8F49B892406443D84758909D" },

        // Game 2010.12.21.0000
        { "C85FDF7D6188D31A0935A6FEC7E27E8C165A600D", "B508CA49C0146603C5170095E6C9A930165A600D" },

        // Game 2011.01.18.0000
        { "40F85094158B02F0B4BC4F3B70AFF0C94E50BA62", "F609DA895050640544D2D6BD8FB6DE9D4E50BA62" },

        // Game 2011.02.01.0000
        { "06DD408A6DFB6A9C3E958E760DAADFDD44928D23", "3535CDE28E948B7247279FD78E5250F444928D23" },

        // Game 2011.02.10.0000
        { "0DCD0DA3E76D0D4D04CF551731C9604E39F57C56", "E9D6AAC15D0633318A3CC2D52E2D507439F57C56" },

        // Game 2011.03.01.0000
        { "3302E4BB94DF0486CC6275DE5A0D4CFED05E90FF", "2227A09E7EA9B4FFB3E76CFFB6A86F5DD05E90FF" },

        // Game 2011.03.24.0000
        { "5606931753B7FCB4FF00E0ABF7ACAB774E384493", "94C255CDFD162955E9CC2C489891500B4E384493" },

        // Game 2011.03.30.0000
        { "9850F59758FB69BACCF3607DCA09BBF6361CC521", "EBB8A47A7A9876DE5765E0E258C9D475361CC521" },

        // Game 2011.04.13.0000
        { "6EC3382ADF25111FD480909644F1AD5F86335C5E", "2BCC2CF72BD3E1BB092D45212B9BDE6786335C5E" },

        // Game 2011.04.21.0000
        { "E649583127483CA8F0C83FB786F5D863394B22B3", "7115DAFA11B99A16F2D38AE9E0EE7060394B22B3" },

        // Game 2011.05.19.0000
        { "0E9788FCA8FFBCF5D64568F9144902B68992E9F5", "958CFE71DB1D02CBEA0445DC72F07DC38992E9F5" },

        // Game 2011.06.10.0000
        { "087732057958AF38FFDB9D62D7BDF90C4C440F66", "60BBC4F4C041C520A32D89A4B516A2D44C440F66" },

        // Game 2011.07.20.0000
        { "BC77CC348C44121865435E1AD66FE2651617E099", "154C306A512A17E942F34FD22537DF761617E099" },

        // Game 2011.07.26.0000
        { "EAC1CED52200307B67B81467D9A5D4C6B5CEA917", "585EB51D1E58A8F0298C1B67079182BFB5CEA917" },

        // Game 2011.08.05.0000
        { "CDA30987FD7995F40E01C350739825C3D6D1C5B2", "389E0D385A6B9F56AE0766641F3912EBD6D1C5B2" },

        // Game 2011.08.09.0000
        { "56C2436A04E33D5BC8052A035482B2C48DDF5A1B", "C3B47BAB830C70B3E403FC37C710D1668DDF5A1B" },

        // Game 2011.08.16.0000
        { "D4006C4576642EA7875E2CB7C9338168A96F8BF4", "4A13C8AD591D87AA3B055B30799A6C7CA96F8BF4" },

        // Game 2011.10.04.0000
        { "459CD0F98A503AC8C7F45CF2D3FEE2B86A4E6165", "DD4253CC21393C4F7C4D2EAA8BC2F56F6A4E6165" },

        // Game 2011.10.12.0001
        { "D17B6A598CEFA3E8A64D33610052D3422E9566DB", "91D2950EE46E739C88CF1C31DD11DE0B2E9566DB" },

        // Game 2011.10.27.0000
        { "B63BDBE56CA7F7152087BD7F0617FCA4386027F1", "7E01C39AB942F32BD1E94A1926F0DC8C386027F1" },

        // Game 2011.12.14.0000
        { "A7DF7EAC7C7BCE14D5DBBB7818BF7F7F7ECC3D4A", "D64E79AAEB346F9D30555AE85BAFCFE97ECC3D4A" },

        // Game 2011.12.23.0000
        { "15CDF35FADD0AA37FF9F69A894A2952334FAC5F3", "00D5CCEA64B9664BD5771FF8E5D326B234FAC5F3" },

        // Game 2012.01.18.0000
        { "1C745EDED96B0C64F12556D58A3D23F2B81563CA", "FA524591C194A6EEFD402FEF65ED0B91B81563CA" },

        // Game 2012.01.24.0000
        { "0F18874F8E588E3FE619EDA959A3996E3E1E2A14", "884C4C4B5B4E3F1BF5399E52AE2A87593E1E2A14" },

        // Game 2012.01.31.0000
        { "FBA579FC492098DB87ECFF8841105DE4E245C826", "805A69D79C40BE6A1A06D5E34D3CA657E245C826" },

        // Game 2012.03.07.0000
        { "2E814FC6E20F2426426B51C082786B5DDE64E0F0", "B3FA96E226BB60963EF366B4455ECACDDE64E0F0" },

        // Game 2012.03.09.0000
        { "0289A9527A847DFA448D30BF33CF325553FC0206", "AEDEAC7F2C2C1E67672163FA20CDBE1D53FC0206" },

        // Game 2012.03.22.0000
        { "11055EBF6F0240B3CC75D017DC742782012C0119", "6D92F43FE4824BCE0E0EF3BCCA697B9A012C0119" },

        // Game 2012.03.29.0000
        { "552ADF573C6FEE9EDC89CC00261CFA79CD1377AF", "1301134B2A530987FE5AE619CB045A24CD1377AF" },

        // Game 2012.04.04.0000
        { "4E013C2FC808F43AC72451469E1FA3E6B01497EE", "E36DE8016EC64A3A084DBA3BC1D2E4D7B01497EE" },

        // Game 2012.04.23.0001
        { "E57A24EB227A56CB6F6DD7F6EACA791CD34DE9F8", "2DE77ADD1F5C223291B9800C246C45B4D34DE9F8" },

        // Game 2012.05.08.0000
        { "22FFB528E445FF43F699CC585C0FCE0E287D5C76", "429B8329A69784AD85F92A881E864026287D5C76" },

        // Game 2012.05.15.0000
        { "587FBCA7FCD4A0CAB0CDBA8F81AF1F054AE2785C", "A4E69D5FE8FBAEC8C9EE20C3C9D4F3494AE2785C" },

        // Game 2012.05.22.0000
        { "E76894E0E565242586FC661C0773A8A3FFC8ED42", "FE6A19D782EE1942E2EFC6523A666F52FFC8ED42" },

        // Game 2012.06.06.0000
        { "4B7845E7D7024E646E0F0DC9BAB65104F435EF1C", "056A3B69CFEA764147730FF09134B103F435EF1C" },

        // Game 2012.06.19.0000
        { "82FECCB7811F3C12FABD20D1B54080F3C628DA2E", "0F12102922541C557810215ECEB76AFCC628DA2E" },

        // Game 2012.06.26.0000
        { "BCE11E3A8BA0A37491C084ECF637B5ACFFC045C5", "B150472DBBC7943B1442288BCF06ED1BFFC045C5" },

        // Game 2012.07.21.0000
        { "1BD074689229681D7A3291BA3DA5A765C2655837", "8C9347C6CA278D1D4A150D512F24E77EC2655837" },

        // Game 2012.08.10.0000
        { "7948F3B701E6250D163826294D0D23E7C3442357", "FA248B6AFC7454B6D6FCF5A3AB7CCA22C3442357" },

        // Game 2012.09.06.0000
        { "289FC6B430CCA0923C854CE9421870007CF140C9", "D1B3FD9EA18CB2778606E4DF9B6A34607CF140C9" },

        // Game 2012.09.19.0001
        { "6F597AE7FA2E9711D878E1E409682483FE6AFF48", "CEE3645EA9996170CED2BD1C21CE1FDEFE6AFF48" }
    };
}